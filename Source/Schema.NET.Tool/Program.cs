namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using Schema.NET.Tool.Overrides;
    using Schema.NET.Tool.Repositories;
    using Schema.NET.Tool.Services;
    using Schema.NET.Tool.ViewModels;

    public class Program
    {

        private readonly SchemaService schemaService;

        public Program() =>
            this.schemaService = new SchemaService(
                new List<IClassOverride>()
                {
                    new AddQueryInputPropertyToSearchAction(),
                    new AddTextTypeToActionTarget(),
                    new AddNumberTypeToMediaObjectHeightAndWidth()
                },
                new List<IEnumerationOverride>()
                {
                    new WarnEmptyEnumerations()
                },
                new SchemaRepository());

        public static void Main(string[] args) => new Program().Execute().Wait();

        public async Task Execute()
        {
            Console.WriteLine("Executing Class and Property Download");
            var (enumerations, classes) = await this.schemaService.GetObjects();
            Console.WriteLine("Finished Class and Property Download");

            var assemblyLocation = typeof(Program).GetTypeInfo().Assembly.Location;
            var outputDirectory = GetOutputDirectory(Path.GetDirectoryName(assemblyLocation));

            Console.WriteLine("Executing Clean Project Folder");
            await ClearOutputDirectory(outputDirectory);
            Console.WriteLine("Finished Clean Project Folder");

            Console.WriteLine("Executing Write Classes");
            foreach (var schemaObjectGroup in enumerations
                .OfType<SchemaObject>()
                .Concat(classes.OfType<SchemaObject>())
                .GroupBy(x => x.Layer))
            {
                var directoryPath = Path.Combine(outputDirectory, schemaObjectGroup.Key);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                    Console.WriteLine("=====================" + schemaObjectGroup.Key);
                }

                foreach (var schemaObject in schemaObjectGroup)
                {
                    var filePath = Path.Combine(directoryPath, schemaObject.Name + ".cs");
                    File.WriteAllText(filePath, schemaObject.ToString());
                    Console.WriteLine(Path.GetFileName(filePath));
                }
            }
            Console.WriteLine("Finished Write Classes");
        }

        private static async Task ClearOutputDirectory(string directoryPath)
        {
            foreach (var filePath in Directory.GetFiles(directoryPath, "*.cs", SearchOption.AllDirectories))
            {
                var fileDirectoryPath = Path.GetDirectoryName(filePath);
                if (!string.Equals(fileDirectoryPath, directoryPath, StringComparison.OrdinalIgnoreCase))
                {
                    while (true)
                    {
                        try
                        {
                            File.Delete(filePath);
                            break;
                        }
                        catch
                        {
                            await Task.Delay(100);
                        }
                    }
                }
            }

            foreach (var subDirectoryPath in Directory.GetDirectories(directoryPath))
            {
                var subDirectoryName = Path.GetFileNameWithoutExtension(subDirectoryPath);
                if (!string.Equals(subDirectoryName, "bin", StringComparison.Ordinal) &&
                    !string.Equals(subDirectoryName, "obj", StringComparison.Ordinal))
                {
                    Directory.Delete(subDirectoryPath, true);
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