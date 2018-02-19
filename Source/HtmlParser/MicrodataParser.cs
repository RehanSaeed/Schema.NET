using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using Schema.NET;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace HtmlParser
{
    /// <summary>
    /// todo: add support for itemref ....
    /// </summary>
    public class ThingsParser
    {
        private const string ItemScopeString = "itemscope";
        private const string ItemTypeString = "itemtype";
        private const string ItemPropString = "itemprop";
        private const string MetaString = "meta";
        private const string ContentString = "content";

        private readonly ILogger<ThingsParser> logger;
        private Dictionary<string, Type> typesByName = new Dictionary<string, Type>();
        
        public ThingsParser(ILogger<ThingsParser> logger)
        {
            this.logger = logger;

            //create a dictionary of string to type for all types in Schema.Net

            Assembly schemaTypes = typeof(Thing).Assembly;
            foreach (Type type in schemaTypes.GetTypes())
            {
                if (type.IsSubclassOf(typeof(Thing))) typesByName[type.Name.ToLower()] = type;
            }
        }

        bool IsItemScopeNode(HtmlNode node)
        {
            return node.Attributes[ItemScopeString] != null;
        }

        public IEnumerable<Thing> ParseMicroDataThings(HtmlDocument document)
        {
            var queueOfNodes = new Queue<HtmlNode>();
            queueOfNodes.Enqueue(document.DocumentNode);
            do
            {
                var currentNode = queueOfNodes.Dequeue();

                if (IsItemScopeNode(currentNode))
                {
                    var ret = ParseItemScopeNode(currentNode);
                    if (ret != null) yield return ret;
                } else
                {
                    var children = currentNode.ChildNodes;
                    foreach (var child in children)
                    {
                        queueOfNodes.Enqueue(child);
                    }
                }
            } while (queueOfNodes.Any());
        }

        public IEnumerable<Thing> ParseLdJsonThings(HtmlDocument document)
        {
            //get all script elements with type application/ld+json
            var ldTags = document.DocumentNode.SelectNodes("//script[@type='application/ld+json']");
            if (ldTags != null)
            {
                foreach (var ldTag in ldTags)
                {
                    Thing t = null;
                    try
                    {
                        t = Newtonsoft.Json.JsonConvert.DeserializeObject<Thing>(ldTag.InnerText);
                    }
                    catch (Exception e)
                    {
                        if (logger != null) logger.LogInformation($"Problem parsing ld+json ({ldTag.InnerText})");
                    }
                    if (t != null) yield return t;
                }
            }
        }

        private Dictionary<Type, Dictionary<Type, Type>> interfaceImplementors = new Dictionary<Type, Dictionary<Type, Type>>();

        Type FindType(object value, string itemProp, Dictionary<Type,Type> dictionary, out object transformedObject)
        {
            transformedObject = value;
            var targetType = value.GetType();

            if (targetType == typeof(string))
            {
                string strValue = (string)value;
                //first try other stuff
                foreach (var item in dictionary.Where(x => !x.Key.IsSubclassOf(typeof(Thing)) && x.Key != typeof(string)))
                {
                    if (item.Key == typeof(Uri))
                    {
                        if (IsUrl(strValue, out Uri result))
                        {
                            transformedObject = result;
                            return typeof(Uri);
                        }
                    } else if (item.Key == typeof(int))
                    {
                        if (int.TryParse(strValue, out int result))
                        {
                            transformedObject = result;
                            return typeof(int);
                        }
                    }
                    else if (item.Key == typeof(bool))
                    {
                        if (bool.TryParse(strValue, out bool result))
                        {
                            transformedObject = result;
                            return typeof(bool);
                        }
                    }
                    else if (item.Key == typeof(double))
                    {
                        var testValue = Regex.Replace(strValue, @"\s", "").Replace(",", ".");
                        var t2 = Regex.Replace(testValue, @"[^\d|\.]", "");
                        if (t2.Length + 1 >= testValue.Length && double.TryParse(t2, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
                        {
                            transformedObject = result;
                            return typeof(double);
                        }
                    }
                    else if (item.Key == typeof(decimal))
                    {
                        var testValue = Regex.Replace(strValue, @"\s", "").Replace(",", ".");
                        var t2 = Regex.Replace(testValue, @"[^\d|\.]", "");
                        if (t2.Length + 1 >= testValue.Length && decimal.TryParse(t2, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result))
                        {
                            transformedObject = result;
                            return typeof(decimal);
                        }
                    } else
                    {
                        //don't understand type yet
                        if (logger != null) logger.LogDebug($"{item.Key} not handled");
                        else Console.WriteLine($"{item.Key} not handled");
                    }
                }
            }

            if (dictionary.TryGetValue(targetType, out Type returnType)) {
                return targetType;
            }

            foreach (var continueTest in dictionary)
            {
                //is there a type looking a lot like itemprop?
                if (targetType == typeof(string) && continueTest.Key.Name.ToLower() == itemProp && continueTest.Key.IsSubclassOf(typeof(Thing)))
                {
                    var obj = (Thing) Activator.CreateInstance(continueTest.Key);
                    obj.Name = (string) value;
                    transformedObject = obj;
                    return continueTest.Key;
                }
                
            }

            if (logger != null) logger.LogDebug($"Don't know what to do with {value.GetType()} for {itemProp}");
            else Console.WriteLine($"Don't know what to do with {value.GetType()} for {itemProp}");
            return null;
        }

        bool GetValuesObject(Type targetType, string itemProp, object currentValue, object valueToSetOrAdd, out object newCurrentValue)
        {
            newCurrentValue = currentValue;
            if (valueToSetOrAdd == null) return false;

            //targettype is always Nullable<Values<T>>
            //Values<T> always contains .Add(T)
            //we are interested in T and need to create a T
            
            var realTargettype = targetType.GetGenericArguments().First();
            var genericType = targetType.GetGenericArguments().First().GetGenericArguments().First();

            //generic type is either an interface or an object
            if (genericType.IsInterface)
            {
                //create a type implementing the generic with T same as type valueToSetOrAdd
                //valuesToAdd as string might prove difficult, as numeric values are never a string ...
                if (!interfaceImplementors.TryGetValue(genericType, out Dictionary<Type, Type> impl))
                {
                    Assembly schemaTypes = typeof(Thing).Assembly;
                    interfaceImplementors[genericType] = impl = new Dictionary<Type, Type>();
                    var allImplementations = schemaTypes.GetTypes().Where(p => genericType.IsAssignableFrom(p) && !p.IsInterface);
                    foreach (var implType in allImplementations)
                    {
                        var interfaceType = implType.GetInterfaces().First(p => p.GetGenericArguments().Any()).GetGenericArguments().First();
                        impl[interfaceType] = implType;
                    }
                }
                var typeToFind = valueToSetOrAdd.GetType();

                //get the base impl for this value
                //first try and find full match (simplest)
                var foundType = FindType(valueToSetOrAdd, itemProp, impl, out object val);
                if (foundType == null) return false;
                                
                //create an instance of this type with parameter valueToSetOrAdd
                var interfaceValue = Activator.CreateInstance(impl[foundType], val);
                var valuesType = typeof(Values<>).MakeGenericType(genericType);
                if (currentValue == null)
                {
                    //create an object of type Values<T> where t is type of generic
                    var listType = typeof(List<>).MakeGenericType(genericType);
                    var listObject = Activator.CreateInstance(listType);
                    listType.InvokeMember("Add", BindingFlags.InvokeMethod, Type.DefaultBinder, listObject, new[] { interfaceValue });

                    newCurrentValue = Activator.CreateInstance(valuesType, listObject);
                    return true;
                }
                else
                {
                    valuesType.InvokeMember("Add", BindingFlags.InvokeMethod, Type.DefaultBinder, currentValue, new[] { interfaceValue });
                    return false;
                }
            }
            else
            {
                var val = valueToSetOrAdd;
                if (!genericType.IsAssignableFrom(valueToSetOrAdd.GetType()))
                {
                    try
                    {
                        //try to use serialization
                        val = Newtonsoft.Json.JsonConvert.DeserializeObject(Newtonsoft.Json.JsonConvert.SerializeObject(val), genericType);
                    } catch
                    {
                        if (logger != null) logger.LogDebug($"Couldn't convert {valueToSetOrAdd} to {genericType}");
                        else Console.WriteLine($"Couldn't convert {valueToSetOrAdd} to {genericType}");
                        return false;
                    }
                }

                var valuesType = typeof(Values<>).MakeGenericType(genericType);
                if (currentValue == null)
                {
                    //create an object of type Values<T> where t is type of generic
                    newCurrentValue = Activator.CreateInstance(valuesType, val);
                    return true;
                } else
                {
                    valuesType.InvokeMember("Add", BindingFlags.InvokeMethod, Type.DefaultBinder, currentValue, new[] { val });
                    return false;
                }
            }
        }
        
        void SetOrAddProp(Thing target, string itemProp, Thing property)
        {
            Type thingType = target.GetType();
            var prop = thingType.GetProperties(BindingFlags.Public | BindingFlags.Instance).FirstOrDefault(p => p.Name.ToLower() == itemProp.ToLower());

            if (prop == null)
            {
                Console.WriteLine($"Property not found: {itemProp} in class {thingType.Name}, reverting back to ItemList");
                prop = thingType.GetProperties(BindingFlags.Public | BindingFlags.Instance).FirstOrDefault(p => p.Name.ToLower() == "itemlist");
            }

            var targetType = prop.PropertyType;
            var val = prop.GetValue(target);

            if (GetValuesObject(targetType, itemProp, val, property, out object newValue))
            {
                prop.SetValue(target, newValue);
            }            
        }

        bool IsUrl(string url, out Uri result)
        {
            if (!Uri.TryCreate(url, UriKind.Absolute, out result)) {
                return Uri.TryCreate(url, UriKind.Relative, out result);
            }
            return true;
        }

        void SetOrAddProp(Thing target, string itemProp, HtmlNode propertyNode)
        {
            Type thingType = target.GetType();
            var prop = thingType.GetProperties(BindingFlags.Public | BindingFlags.Instance).FirstOrDefault(p => p.Name.ToLower() == itemProp.ToLower());
            if (prop == null)
            {
                Console.WriteLine($"Property not found: {itemProp} in class {thingType.Name}");
                return;
            }

            object propertyValue = null;

            //see also https://www.w3.org/TR/microdata/#dfn-content
            var contentAttr = propertyNode.Attributes["content"];
            if (contentAttr != null) {
                propertyValue = contentAttr.DeEntitizeValue.Trim();
            }
            else if (new [] { "audio", "embed", "iframe", "img", "source", "track", "video" }.Contains(propertyNode.Name))
            {
                var srcAttr = propertyNode.Attributes["src"];
                if (srcAttr != null && IsUrl(srcAttr.DeEntitizeValue.Trim(), out Uri uri)) propertyValue = uri;
            } else if (new[] { "a", "area", "link" }.Contains(propertyNode.Name))
            {
                var hrefAttr = propertyNode.Attributes["href"];
                if (hrefAttr != null && IsUrl(hrefAttr.DeEntitizeValue.Trim(), out Uri uri)) propertyValue = uri;
            }
            else if (new[] { "object" }.Contains(propertyNode.Name))
            {
                var dataAttr = propertyNode.Attributes["data"];
                if (dataAttr != null && IsUrl(dataAttr.DeEntitizeValue.Trim(), out Uri uri)) propertyValue = uri;
            }
            else if (new[] { "data", "meter" }.Contains(propertyNode.Name))
            {
                var valueAttr = propertyNode.Attributes["value"];
                if (valueAttr != null) propertyValue = valueAttr.DeEntitizeValue.Trim();
            }
            else if (new[] { "time" }.Contains(propertyNode.Name))
            {
                var datetimeAttr = propertyNode.Attributes["datetime"];
                if (datetimeAttr != null) propertyValue = datetimeAttr.DeEntitizeValue.Trim();
            } else
            {
                propertyValue = propertyNode.InnerText.Trim();
            }

            var targetType = prop.PropertyType;
            var val = prop.GetValue(target);

            if (GetValuesObject(targetType, itemProp, val, propertyValue, out object newValue))
            {
                prop.SetValue(target, newValue);
            }
        }

        public Thing ParseItemScopeNode (HtmlNode itemScopeNode)
        {
            var itemType = itemScopeNode.Attributes[ItemTypeString];
            var theType = itemType.Value.Split('/').Last();

            //this should be called recursive
            //first get a reference to the object type
            if (!typesByName.TryGetValue(theType.ToLower(), out Type thingType))
                return null;

            //create a thingType
            var result = (Thing) Activator.CreateInstance(thingType);

            //go through all children trying to find itemprop values, and new itemScopes
            var queueOfNodes = new Queue<HtmlNode>();
            
            do
            {
                var currentNode = queueOfNodes.Any() ? queueOfNodes.Dequeue() : null;
                if (currentNode != null && IsItemScopeNode(currentNode))
                {
                    var itemProp = currentNode.Attributes[ItemPropString];
                    Thing t = ParseItemScopeNode(currentNode);
                    if (itemProp != null) SetOrAddProp(result, itemProp.DeEntitizeValue, t);                    
                }
                else
                {
                    //the node might contain itemprop
                    if (currentNode != null)
                    {
                        var itemProp = currentNode.Attributes[ItemPropString];
                        if (itemProp != null) SetOrAddProp(result, itemProp.DeEntitizeValue, currentNode);
                    }

                    var children = (currentNode ?? itemScopeNode).ChildNodes;
                    foreach (var child in children)
                    {
                        queueOfNodes.Enqueue(child);
                    }
                }
            } while (queueOfNodes.Any());

            return result;            
        }
    }
}
