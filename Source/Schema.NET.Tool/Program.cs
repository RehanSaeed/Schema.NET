namespace Schema.NET.Tool
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using Schema.NET.Tool.Services;

    public class Program
    {
        private readonly ISchemaService schemaService;

        public Program()
        {
            this.schemaService = new SchemaService();
        }

        public static void Main(string[] args)
        {
            new Program().Execute().Wait();
        }

        public async Task Execute()
        {
            Console.WriteLine("Executing Class and Property Download");

            var schemaClasses = await this.schemaService.GetSchemaClasses();
            var schemaProperties = await this.schemaService.GetSchemaProperties();
            foreach (var schemaProperty in schemaProperties)
            {
                if (string.Equals(schemaProperty.PropertyType, "rdf:Property", StringComparison.OrdinalIgnoreCase))
                {
                    foreach (var schemaClass in schemaClasses.Where(x => schemaProperty.ClassUrls.Contains(x.Url)))
                    {
                        schemaProperty.Classes.Add(schemaClass);
                        schemaClass.Properties.Add(schemaProperty);
                    }
                }
                else if (string.Equals(schemaProperty.PropertyType, "rdfs:Class", StringComparison.OrdinalIgnoreCase))
                {
                    // {
                    //   "@id": "http://schema.org/CafeOrCoffeeShop",
                    //   "@type": "rdfs:Class",
                    //   "rdfs:comment": "A cafe or coffee shop.",
                    //   "rdfs:label": "CafeOrCoffeeShop",
                    //   "rdfs:subClassOf": {
                    //     "@id": "http://schema.org/FoodEstablishment"
                    //   }
                    // }
                }
                else
                {
                    if (schemaProperty.Url.StartsWith("http://schema.org"))
                    {
                        foreach (var schemaClass in schemaClasses
                            .Where(x => string.Equals(schemaProperty.PropertyType, x.Url, StringComparison.Ordinal)))
                        {
                            schemaProperty.Classes.Add(schemaClass);
                            schemaClass.Properties.Add(schemaProperty);
                        }

                        foreach (var schemaClass in collection)
                        {

                        }
                    }
                    else
                    {
                        // {
                        //   "@id": "https://www.w3.org/wiki/WebSchemas/SchemaDotOrgSources#STI_Accommodation_Ontology",
                        //   "@type": "http://schema.org/Organization",
                        //   "rdfs:comment": "This element is based on the STI Accommodation Ontology, see <a href=\"http://ontologies.sti-innsbruck.at/acco/ns.html\">http://ontologies.sti-innsbruck.at/acco/ns.html</a> for details.\n    Many class and property definitions are inspired by or based on abstracts from Wikipedia, the free encyclopedia.",
                        //   "rdfs:label": "STI Accommodation Ontology"
                        // }
                    }
                }
            }

            Console.WriteLine("Finished Class and Property Download");

            var assemblyLocation = typeof(Program).GetTypeInfo().Assembly.Location;
            var outputDirectory = GetOutputDirectory(Path.GetDirectoryName(assemblyLocation));

            Console.WriteLine("Executing Clean Project Folder");
            ClearOutputDirectory(outputDirectory);
            Console.WriteLine("Finished Clean Project Folder");

            Console.WriteLine("Executing Write Classes");

            foreach (var item in schemaClasses)
            {
                var filePath = Path.Combine(outputDirectory, item.Name + ".cs");
                File.WriteAllText(filePath, item.ToString());
                Console.WriteLine(Path.GetFileName(filePath));
            }

            Console.WriteLine("Finished Write Classes");
        }

        private static void ClearOutputDirectory(string directoryPath)
        {
            foreach (var filePath in Directory.GetFiles(directoryPath, "*.cs"))
            {
                if (!string.Equals(Path.GetFileName(filePath), "Thing.Partial.cs", StringComparison.OrdinalIgnoreCase))
                {
                    // File.Delete(filePath);
                }
            }
        }

        private static string GetOutputDirectory(string directoryPath)
        {
            var directory = new DirectoryInfo(directoryPath);
            var projectFilePath = directory
                .GetFiles("*.csproj", SearchOption.AllDirectories)
                .Select(x => x.FullName)
                .Where(x => x.EndsWith("Schema.NET.csproj"))
                .FirstOrDefault();
            if (projectFilePath == null)
            {
                return GetOutputDirectory(directory.Parent.FullName);
            }

            return Path.GetDirectoryName(projectFilePath);
        }
    }
}