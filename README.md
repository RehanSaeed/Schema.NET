![Schema.NET Banner](Images/Banner.png)

[![Schema.NET NuGet Package](https://img.shields.io/nuget/v/Schema.NET.svg)](https://www.nuget.org/packages/Schema.NET) [![Schema.NET Azure Artifacts Package](https://feeds.dev.azure.com/schema-net/_apis/public/Packaging/Feeds/64e69c35-cb00-46e4-9cba-6d8faf1f41d6/Packages/fa72270b-6c54-4403-9307-aa826e43530e/Badge)](https://dev.azure.com/schema-net/Schema.NET/_packaging?_a=package&feed=64e69c35-cb00-46e4-9cba-6d8faf1f41d6&package=fa72270b-6c54-4403-9307-aa826e43530e&preferRelease=true) [![Twitter URL](https://img.shields.io/twitter/url/http/shields.io.svg?style=social)](https://twitter.com/RehanSaeedUK) [![Twitter Follow](https://img.shields.io/twitter/follow/rehansaeeduk.svg?style=social&label=Follow)](https://twitter.com/RehanSaeedUK)

Schema.org objects turned into strongly typed C# POCO classes for use in .NET. All classes can be serialized into JSON/JSON-LD and XML, typically used to represent structured data in the `head` section of `html` page.

## Simple Example

```C#
var website = new WebSite()
{
    AlternateName = "An Alternative Name",
    Name = "Your Site Name",
    Url = new Uri("https://example.com")
};
var jsonLd = website.ToString();
```

The code above outputs the following JSON-LD:

```JSON
{
    "@context":"https://schema.org",
    "@type":"WebSite",
    "alternateName":"An Alternative Name",
    "name":"Your Site Name",
    "url":"https://example.com"
}
```

If writing the result into a `<script>` element, be sure to use the `.ToHtmlEscapedString()` method instead to avoid exposing your website to a Cross-Site Scripting attack. See the [example below](#important-security-notice).

## What is Schema.org?

[schema.org](https://schema.org) defines a set of standard classes and their properties for objects and services in the real world. This machine readable format is a common standard used across the web for describing things.

## Where is Schema.org Used?

#### Websites

Websites can define Structured Data in the `head` section of their `html` to enable search engines to show richer information in their search results. Here is an example of how [Google](https://developers.google.com/search/docs/guides/intro-structured-data) can display extended metadata about your site in it's search results.

![Google Logo Structured Data Example](Images/Google%20Logo%20Structured%20Data%20Example.png)

Using structured data in `html` requires the use of a `script` tag with a MIME type of `application/ld+json` like so:

```HTML
<script type="application/ld+json">
{
  "@context": "https://schema.org",
  "@type": "Organization",
  "url": "https://www.example.com",
  "name": "Unlimited Ball Bearings Corp.",
  "contactPoint": {
    "@type": "ContactPoint",
    "telephone": "+1-401-555-1212",
    "contactType": "Customer service"
  }
}
</script>
```

##### Important Security Notice
When serializing the result for a website's `<script>` tag, you should use the alternate `.ToHtmlEscapedString()` to avoid exposing yourself to a Cross-Site Scripting (XSS) vulnerability if some of the properties in your schema have been set from untrusted sources.
Usage in an ASP.NET MVC project might look like this:

```HTML
<script type="application/ld+json">
    @Html.Raw(Model.Schema.ToHtmlEscapedString())
</script>
```
 

#### Windows UWP Sharing

Windows UWP apps let you share data using schema.org classes. [Here](https://docs.microsoft.com/en-us/uwp/schemas/appxpackage/appxmanifestschema/element-sharetarget) is an example showing how to share metadata about a book.

## Classes & Properties

schema.org defines classes and properties, where each property can have a single value or an array of multiple values. Additionally, properties can have multiple types e.g. an `Address` property could have a type of `string` or a type of `PostalAddress` which has it's own properties such as `StreetAddress` or `PostalCode` which breaks up an address into it's constituent parts.

To facilitate this Schema.NET uses some clever C# generics and implicit type conversions so that setting a single or multiple values is possible and that setting a `string` or `PostalAddress` is also possible:

```C#
// Single string address
var organization = new Organization()
{
    Address = "123 Old Kent Road E10 6RL"
};

// Multiple string addresses
var organization = new Organization()
{
    Address = new List<string>()
    { 
        "123 Old Kent Road E10 6RL",
        "456 Finsbury Park Road SW1 2JS"
    }
};

// Single PostalAddress address
var organization = new Organization()
{
    Address = new PostalAddress()
    {
        StreetAddress = "123 Old Kent Road",
        PostalCode = "E10 6RL"
    }
};

// Multiple PostalAddress addresses
var organization = new Organization()
{
    Address = new List<PostalAddress>()
    {
        new PostalAddress()
        {
            StreetAddress = "123 Old Kent Road",
            PostalCode = "E10 6RL"
        },
        new PostalAddress()
        {
            StreetAddress = "456 Finsbury Park Road",
            PostalCode = "SW1 2JS"
        }
    }
};

// Mixed Author types
var book = new Book()
{
    Author = new List<object>()
    {
        new Organization() { Name = "Penguin" },
        new Person() { Name = "J.D. Salinger" }
    }
};

// Deconstruct a property containing mixed types
if (book.Author.HasValue)
{
    var (organisations, people) = book.Author.Value;
}
```

This magic is all carried out using [implicit conversion operators](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/implicit) in the `OneOrMany<T>`, `Values<T1, T2>`, `Values<T1, T2, T3>` and `Values<T1, T2, T3, T4>` types. These types are all `structs` for best performance too.

## More Examples

For more examples and actual running code samples, take a look at the unit tests in the project source code.

## Continuous Integration

| Name            | Operating System      | Status | History |
| :---            | :---                  | :---   | :---    |
| Azure Pipelines | Ubuntu                | [![Azure Pipelines Ubuntu Build Status](https://dev.azure.com/schema-net/Schema.NET/_apis/build/status/Schema.NET?branchName=master&stageName=Build&jobName=Build&configuration=Build%20Linux)](https://dev.azure.com/schema-net/Schema.NET/_build/latest?definitionId=1&branchName=master) |
| Azure Pipelines | Mac                   | [![Azure Pipelines Mac Build Status](https://dev.azure.com/schema-net/Schema.NET/_apis/build/status/Schema.NET?branchName=master&stageName=Build&jobName=Build&configuration=Build%20Mac)](https://dev.azure.com/schema-net/Schema.NET/_build/latest?definitionId=1&branchName=master) |
| Azure Pipelines | Windows               | [![Azure Pipelines Windows Build Status](https://dev.azure.com/schema-net/Schema.NET/_apis/build/status/Schema.NET?branchName=master&stageName=Build&jobName=Build&configuration=Build%20Windows)](https://dev.azure.com/schema-net/Schema.NET/_build/latest?definitionId=1&branchName=master) |
| Azure Pipelines | Overall               | [![Azure Pipelines Overall Build Status](https://dev.azure.com/schema-net/Schema.NET/_apis/build/status/Schema.NET?branchName=master)](https://dev.azure.com/schema-net/Schema.NET/_build/latest?definitionId=1&branchName=master) | [![Azure DevOps Build History](https://buildstats.info/azurepipelines/chart/schema-net/Schema.NET/1?branch=master&includeBuildsFromPullRequest=false)](https://dev.azure.com/schema-net/Schema.NET/_build/latest?definitionId=1&branchName=master) |
| GitHub Actions  | Ubuntu, Mac & Windows | [![GitHub Actions Status](https://github.com/RehanSaeed/Schema.NET/workflows/Build/badge.svg?branch=master)](https://github.com/RehanSaeed/Schema.NET/actions) | [![GitHub Actions Build History](https://buildstats.info/github/chart/RehanSaeed/Schema.NET?branch=master&includeBuildsFromPullRequest=false)](https://github.com/RehanSaeed/Schema.NET/actions) |
| AppVeyor        | Ubuntu & Windows      | [![AppVeyor Build Status](https://ci.appveyor.com/api/projects/status/djxrpkw8ckyf24c1/branch/master?svg=true)](https://ci.appveyor.com/project/RehanSaeed/schema-net/branch/master) | [![AppVeyor Build History](https://buildstats.info/appveyor/chart/RehanSaeed/schema-net?branch=master&includeBuildsFromPullRequest=false)](https://ci.appveyor.com/project/RehanSaeed/schema-net) |

## Contributions and Thanks

Please view the [contributing guide](/.github/CONTRIBUTING.md) for more information.

- [kirkone](https://github.com/kirkone) - CI reads .NET Core version from new global.json file.
- [Turnerj](https://github.com/Turnerj) - Added `System.Text.Json` support, Had all types implement `IEquatable<T>` `GetHashCode` and added extra unit tests and bug fixes.
- [shervinw](https://github.com/shervinw) - Added better null value handling for structs.
- [kirk-marple](https://github.com/kirk-marple) - Refactoring JSON serialization to be more efficient.
- [nickevansuk](https://github.com/nickevansuk) - Adding better null value handling and use HTTPS instead of HTTP.
- [MEmanuelsson](https://github.com/MEmanuelsson) - Added support for the schema.org Date type without time.
- [halovanic](https://github.com/halovanic) - For adding interfaces to Schema.NET types for greater flexibility.
- [AndreSteenbergen](https://github.com/AndreSteenbergen) - For enabling the tool to work on linux.
- [benmccallum](https://github.com/benmccallum) - For adding XSS vlnerability protection.
- [psampaio](https://github.com/psampaio) - Added deserialization support and unit tests.
- [icunningham88](https://github.com/icunningham88) - Improved a test.
