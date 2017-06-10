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

        public Program() =>
            this.schemaService = new SchemaService();

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

        private static async Task ClearOutputDirectory(string directoryPath)
        {
            foreach (var filePath in Directory.GetFiles(directoryPath, "*.cs"))
            {
                if (!string.Equals(Path.GetFileName(filePath), "Thing.Partial.cs", StringComparison.OrdinalIgnoreCase))
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