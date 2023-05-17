namespace Schema.NET.Updater;

using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

/// <summary>
/// Updates the local Schema JSON file with data from Schema.org.
/// </summary>
internal sealed class Program
{
    private const string SchemaJsonSourceUrl = "https://schema.org/version/latest/schemaorg-all-https.jsonld";
    private const string SchemaJsonDestinationFilePath = "../../Data/schemaorg-all-https.jsonld";
    private const string ProjectDirectoryAttributeKey = "ProjectDirectory";

    private static async Task Main()
    {
        Console.WriteLine(Resources.Downloading, SchemaJsonSourceUrl);

        using var httpClient = new HttpClient();
        using var stream = await httpClient.GetStreamAsync(new Uri(SchemaJsonSourceUrl)).ConfigureAwait(true);

        Console.WriteLine(Resources.SavingTo, SchemaJsonDestinationFilePath);

        var fullSavePath = Path.Combine(GetProjectDirectory() ?? string.Empty, SchemaJsonDestinationFilePath);
        using var fileStream = File.Open(fullSavePath, FileMode.Create);
        await stream.CopyToAsync(fileStream).ConfigureAwait(true);

        Console.WriteLine(Resources.UpdateComplete);
    }

    private static string? GetProjectDirectory()
    {
        foreach (var attr in Attribute.GetCustomAttributes(typeof(Program).Assembly))
        {
            if (attr is AssemblyMetadataAttribute metadataAttribute && metadataAttribute.Key == ProjectDirectoryAttributeKey)
            {
                return metadataAttribute.Value;
            }
        }

        return null;
    }
}
