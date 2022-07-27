namespace Schema.NET.Test;

#if NET472 || NET461
using System;
#endif
using System.IO;
using Newtonsoft.Json;

public static class StringExtensions
{
#if NET472 || NET461
#pragma warning disable IDE0060 // Remove unused parameter
    public static int GetHashCode(this string target, StringComparison stringComparison) => target.GetHashCode();
#pragma warning restore IDE0060 // Remove unused parameter

#endif
    public static string MinifyJson(this string json, Formatting formatting = Formatting.None)
    {
        using (var stringReader = new StringReader(json))
        using (var stringWriter = new StringWriter())
        {
            MinifyJson(stringReader, stringWriter, formatting);
            return stringWriter.ToString();
        }
    }

    private static void MinifyJson(TextReader textReader, TextWriter textWriter, Formatting formatting)
    {
        using (JsonReader jsonReader = new JsonTextReader(textReader))
        using (JsonWriter jsonWriter = new JsonTextWriter(textWriter))
        {
            jsonWriter.Formatting = formatting;
            jsonWriter.WriteToken(jsonReader);
        }
    }
}
