![Schema.NET Banner](https://raw.githubusercontent.com/RehanSaeed/Schema.NET/master/Images/Banner.png)

Schema.org objects turned into strongly typed C# POCO classes for use in .NET. All classes can be serialized into JSON/JSON-LD and XML, typically used to represent structured data in the `head` section of `html` page.

## Simple Example

```
var website = new WebSite()
{
    AlternateName = "An Alternative Name",
    Name = "Your Site Name",
    Url = new Uri("https://example.com")
};
var jsonLd = website.ToString();
```

The code above outputs the following JSON-LD:

```
{
    "@context":"http://schema.org",
    "@type":"WebSite",
    "alternateName":"An Alternative Name",
    "name":"Your Site Name",
    "url":"https://example.com"
}
```

## What is Schema.org?

[schema.org](https://schema.org) defines a set of standard classes and their properties for objects and services in the real world. This machine readable format is a common standard used across the web for describing things.

## Where is Schema.org Used?

#### Websites

Websites can define Structured Data in the `head` section of their `html` to enable search engines to show richer information in their search results. Here is an example of how [Google](https://developers.google.com/search/docs/guides/intro-structured-data) can display extended metadata about your site in it's search results.

![Google Logo Structured Data Example](https://raw.githubusercontent.com/RehanSaeed/Schema.NET/master/Images/Google%20Logo%20Structured%20Data%20Example.png)

#### Windows UWP Sharing

Windows UWP apps let you share data using schema.org classes. [Here](https://docs.microsoft.com/en-us/uwp/schemas/appxpackage/appxmanifestschema/element-sharetarget) is an example showing how to share metadata about a book.

## Continuous Integration

| Name      | Operating System | Status |
| :---      | :---             | :---   |
| AppVeyor  | Windows          | [![AppVeyor Build status](https://ci.appveyor.com/api/projects/status/djxrpkw8ckyf24c1?svg=true)](https://ci.appveyor.com/project/RehanSaeed/schema-net) |
| Travis CI | Linux & Mac      | [![Travis CI Build Status](https://img.shields.io/travis/RehanSaeed/Schema.NET.svg?maxAge=3600&label=travis)](https://travis-ci.org/RehanSaeed/Schema.NET) |

## NuGet Packages

| Name | NuGet | MyGet |
| :--- | :---  | :---  |
| Schema.NET | [![Schema.NET NuGet Package](https://img.shields.io/nuget/v/Schema.NET.svg)](https://www.nuget.org/packages/Schema.NET) | [![Schema.NET MyGet Package](https://img.shields.io/myget/schema-net/v/Schema.Net.svg)](http://myget.org/gallery/schema-net) |
