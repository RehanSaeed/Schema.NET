namespace Schema.NET.Test;

#if NET472 || NET462
using System;
#endif
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

public static class StringExtensions
{
#if NET472 || NET462
#pragma warning disable IDE0060 // Remove unused parameter
    public static int GetHashCode(this string target, StringComparison stringComparison) => target.GetHashCode();
#pragma warning restore IDE0060 // Remove unused parameter

#endif
    public static string MinifyJson(this string json)
    {
        var options = new JsonWriterOptions
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            Indented = false,
        };

        using (var stream = new MemoryStream())
        using (var writer = new Utf8JsonWriter(stream, options))
        using (var jsonDocument = JsonDocument.Parse(json))
        {
            jsonDocument.WriteTo(writer);
            writer.Flush();
            return Encoding.UTF8.GetString(stream.ToArray());
        }
    }
}
