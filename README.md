
# Wom.Net

A comprehensive .NET wrapper for the WiseOldMan API, providing easy access to Old School RuneScape player tracking and statistics.

[![NuGet](https://img.shields.io/nuget/v/Wom.Net.svg)](https://www.nuget.org/packages/Wom.Net/) ![License](https://img.shields.io/github/license/thespragg/Wom.Net)

## Overview

Wom.Net is a modern, fully-featured .NET library for interacting with the WiseOldMan API. This library allows developers to easily integrate OSRS player tracking, group management, and competition features into their .NET applications.

For more info use the [WiseOldMan API Docs](https://docs.wiseoldman.net).

## Features

-   Complete coverage of the WiseOldMan REST API
-   Strong typing for all API responses
-   Result pattern using [Functional.Sharp](https://github.com/thespragg/Functional.Sharp)
-   Dependency Injection ready with `Microsoft.Extensions.DependencyInjection` integration

## Installation

### .NET CLI

```
dotnet add package Wom.Net
```

## Quick Start

```csharp
using Functional.Sharp.Monads;
using Wom.Net;
using Wom.Net.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Wom.Net.Services.Players.Entities;

// Setup dependency injection
var services = new ServiceCollection();
services.AddWiseOldMan();

// Build service provider and get the client
var serviceProvider = services.BuildServiceProvider();
var womClient = serviceProvider.GetRequiredService<IWiseOldManService>();

// Search for a player
Result<IEnumerable<Player>> playerSearchResult = await womClient.Players.Search("zezima");
playerSearchResult.Match(
    players => Console.WriteLine($"Found {players.Count()} players"),
    err => Console.WriteLine($"Error searching players: {err.Message}")
);
```

## Authentication

Providing an API key will increase rate limits, more info can be found here [API Keys](https://docs.wiseoldman.net/):

```csharp
services.AddWiseOldMan(options => {
    options.ApiKey = "your-api-key-here"; // Optional
    options.DiscordUsername = "YourDiscordName"; // Optional
});

```

## Usage Examples

### Players

```csharp
// Get player details
Result<IEnumerable<Player>> playerSearchResult = await womClient.Players.Search("zezima");
```


## Advanced Configuration

### Result Handling

The library uses Results instead of exceptions for different API error scenarios:

```csharp
Result<PlayerDetails> playerDetailsResult = await womClient.Players.GetPlayerDetails("non-existent-player");
playerDetailsResult.Match(
	 player => // use player here,
	 err => err switch {
		 NotFoundError => Console.WriteLine($"Player not found: {err.Message}"),
		 _ =>  Console.WriteLine($"API error: {err.Message}")
	 }
);
```

## Support

-   [Open an issue](https://github.com/thespragg/Wom.Net/issues)
-  (TODO) [Documentation](https://github.com/thespragg/Wom.Net/wiki)

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1.  Fork the repository
2.  Create your  branch using semantic branch names (`git checkout -b feat/amazing-feature`)
3.  Commit your changes (`git commit -m 'feat: add some amazing feature'`)
4.  Push to the branch (`git push origin feat/amazing-feature`)
5.  Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

-   [WiseOldMan](https://wiseoldman.net/) for their excellent OSRS tracking platform and API
-   The Old School RuneScape community
