# Cogworks.AzureSearch.IoC.Umbraco &middot; [![GitHub license](https://img.shields.io/badge/license-Apache%202.0-blue.svg)](LICENSE.md) [![Github Build](https://img.shields.io/github/workflow/status/thecogworks/cogworks.azuresearch/Changelog%20generator%20and%20NuGet%20Releasing)](https://github.com/thecogworks/Cogworks.AzureSearch/actions?query=workflow%3A%22Changelog+generator+and+NuGet+Releasing%22) [![NuGet Version](https://img.shields.io/nuget/v/Cogworks.AzureSearch)](https://www.nuget.org/packages/Cogworks.AzureSearch/) [![codecov](https://codecov.io/gh/thecogworks/UmbracoAzureSearch/branch/master/graph/badge.svg?token=UMLJ5S8UJX)](undefined)

An Umbraco DI extension to Cogworks.AzureSearch.

## Usage
#### Registration

```csharp

_composing.RegisterAzureSearch()
    .RegisterClientOptions("[AzureSearchServiceName]", "[AzureSearchCredentials]")
    .RegisterIndexOptions(false, false) // for now required
    .RegisterIndexDefinitions<FirstDocumentModel>("first-document-index-name")
    .RegisterIndexDefinitions<SecondDocumentModel>("second-document-index-name")
    .RegisterIndexDefinitions<ThirdDocumentModel>(new Index{
        Name = "third-document-index-name",
        ScoringProfiles = new List<ScoringProfile>()
                {
                    new ScoringProfile("global-sp", new TextWeights(new Dictionary<string, double>()
                    {
                        {"Name", 10}, {"Content", 0.1}, {"Tags/Name", 0.1}
                    }),new List<ScoringFunction>()
                    {
                        new FreshnessScoringFunction("PublishDate", 20, TimeSpan.FromDays(180), ScoringFunctionInterpolation.Quadratic)
                    })
                } //and more custom properties to add
    })
    .RegisterDomainSearcher<SomeDomainSearch, ISomeDomainSearch, FirstDocumentModel>();
```

## License

- Cogworks.AzureSearch is licensed under the [Apache License, Version 2.0](https://opensource.org/licenses/Apache-2.0)

## Code of Conduct

This project has adopted the code of conduct defined by the [Contributor Covenant](https://contributor-covenant.org/) to clarify expected behavior in our community.
For more information, see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

## Blogs

* [How to Simplify Azure Search Implementations](https://www.wearecogworks.com/blog/how-to-simplify-azure-search-implementations/)

## How can you help?

Please... Spread the word, contribute, submit improvements and issues, unit tests, no input is too little. Thank you in advance <3
