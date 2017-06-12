namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using Schema.NET.Tool.Overrides;
    using Schema.NET.Tool.Services;

    public class Program
    {
        private readonly List<ISchemaClassOverride> overrides;
        private readonly ISchemaService schemaService;

        public Program()
        {
            this.schemaService = new SchemaService();
            this.overrides = new List<ISchemaClassOverride>()
            {
                new AddTextTypeToActionTarget()
            };
        }

        public static void Main(string[] args) =>
            new Program().Execute().Wait();

        public async Task Execute()
        {
            Console.WriteLine("Executing Class and Property Download");
            var schemaClasses = await this.schemaService.GetSchemaClassesWithProperties();
            Console.WriteLine("Finished Class and Property Download");

            var assemblyLocation = typeof(Program).GetTypeInfo().Assembly.Location;
            var outputDirectory = GetOutputDirectory(Path.GetDirectoryName(assemblyLocation));

            Console.WriteLine("Executing Clean Project Folder");
            await ClearOutputDirectory(outputDirectory);
            Console.WriteLine("Finished Clean Project Folder");

            foreach (var schemaClass in schemaClasses)
            {
                foreach (var overrid in this.overrides)
                {
                    if (overrid.CanOverride(schemaClass))
                    {
                        overrid.Override(schemaClass);
                    }
                }
            }

            Console.WriteLine("Executing Write Classes");

            foreach (var schemaClassGroup in schemaClasses.GroupBy(x => x.Layer))
            {
                var directoryPath = Path.Combine(outputDirectory, schemaClassGroup.Key);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                    Console.WriteLine("=====================" + schemaClassGroup.Key);
                }

                foreach (var schemaClass in schemaClassGroup)
                {
                    var filePath = Path.Combine(directoryPath, schemaClass.Name + ".cs");
                    File.WriteAllText(filePath, schemaClass.ToString());
                    Console.WriteLine(Path.GetFileName(filePath));
                }
            }

            Console.WriteLine("Finished Write Classes");
        }

        private static async Task ClearOutputDirectory(string directoryPath)
        {
            foreach (var filePath in Directory.GetFiles(directoryPath, "*.cs", SearchOption.AllDirectories))
            {
                if (!Path.GetFileName(filePath).EndsWith(".Partial.cs", StringComparison.OrdinalIgnoreCase))
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