namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using Schema.NET.Tool.CustomOverrides;
    using Schema.NET.Tool.Repositories;
    using Schema.NET.Tool.Services;
    using Schema.NET.Tool.ViewModels;

    public class Program : Disposable
    {
#pragma warning disable CA2213 // Object is being disposed
        private readonly SchemaRepository schemaRepository;
#pragma warning restore CA2213 // Object is being disposed
        private readonly SchemaService schemaService;

        public Program()
        {
            this.schemaRepository = new SchemaRepository();
            this.schemaService = new SchemaService(
                new List<IClassOverride>()
                {
                    new AddQueryInputPropertyToSearchAction(),
                    new AddTextTypeToActionTarget(),
                    new AddNumberTypeToMediaObjectHeightAndWidth(),
                    new RenameEventProperty(),
                },
                new List<IEnumerationOverride>()
                {
                    new WarnEmptyEnumerations(),
                },
                this.schemaRepository);
        }

        public static async Task<int> Main()
        {
            var program = new Program();

            try
            {
                await program.ExecuteAsync().ConfigureAwait(false);
                return 0;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception exception)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(exception.ToString());
                Console.ForegroundColor = ConsoleColor.Gray;
                return -1;
            }
            finally
            {
                program.Dispose();
            }
        }

        public async Task ExecuteAsync()
        {
            Console.WriteLine(Resources.StartedClassAndPropertyDownload);
            var (enumerations, classes) = await this.schemaService.GetObjectsAsync().ConfigureAwait(false);
            Console.WriteLine(Resources.FinishedClassAndPropertyDownload);

            var assemblyLocation = typeof(Program).GetTypeInfo().Assembly.Location;
            var outputDirectory = GetOutputDirectory(Path.GetDirectoryName(assemblyLocation));

            Console.WriteLine(Resources.StartedCleanProjectFolder);
            await ClearOutputDirectoryAsync(outputDirectory).ConfigureAwait(false);
            Console.WriteLine(Resources.FinishedCleanProjectFolder);

            Console.WriteLine(Resources.StartedWriteClasses);
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
                    File.WriteAllText(filePath, schemaObject.ToString(), Encoding.UTF8);
                    Console.WriteLine(Path.GetFileName(filePath));
                }
            }

            Console.WriteLine(Resources.FinishedWriteClasses);
        }

        protected override void DisposeManaged() => this.schemaRepository.Dispose();

        private static async Task ClearOutputDirectoryAsync(string directoryPath)
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
#pragma warning disable CA1031 // Do not catch general exception types
                        catch
                        {
                            await Task.Delay(100).ConfigureAwait(false);
                        }
#pragma warning restore CA1031 // Do not catch general exception types
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
                .Where(x => x.EndsWith("Schema.NET.csproj", StringComparison.Ordinal))
                .FirstOrDefault();
            if (projectFilePath is null)
            {
                return GetOutputDirectory(directory.Parent.FullName);
            }

            return Path.GetDirectoryName(projectFilePath);
        }
    }
}
