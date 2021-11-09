namespace Schema.NET.Updater;

using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

/// <summary>
/// Updates the local Schema JSON file with data from Schema.org.
/// </summary>
internal class Program
{
    private const string SchemaJsonSourceUrl = "https://schema.org/version/latest/schemaorg-all-https.jsonld";
    private const string SchemaJsonDestinationFilePath = "../../Data/schemaorg-all-https.jsonld";

    private static async Task Main()
    {
#pragma warning disable CA1303 // Do not pass literals as localized parameters
        Console.WriteLine("Downloading '{0}'...", SchemaJsonSourceUrl);
        using var httpClient = new HttpClient();
        using var stream = await httpClient.GetStreamAsync(new Uri(SchemaJsonSourceUrl)).ConfigureAwait(true);
        Console.WriteLine("Saving to '{0}'...", SchemaJsonDestinationFilePath);
        using var fileStream = File.Open(SchemaJsonDestinationFilePath, FileMode.Create);
        await stream.CopyToAsync(fileStream).ConfigureAwait(true);
        Console.WriteLine("Update complete!");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
    }
}
