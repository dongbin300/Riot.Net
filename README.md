# Riot.Net
[![NuGet latest version](https://badgen.net/nuget/v/Riot.Lol.Net/latest)](https://nuget.org/packages/Riot.Lol.Net)
[![GitHub forks](https://badgen.net/github/forks/dongbin300/Riot.Net/)](https://GitHub.com/dongbin300/Riot.Net/network/)
![Profile views](https://gpvc.arturio.dev/dongbin300)
<br/><br/>
RiotGames Open API wrapper for .NET includes League of Legends(LoL), Legends of Runeterra(LoR), Teamfight Tactics(TFT) and Valorant(VAL).

## Documentation
### Official Docs
- official docs: https://developer.riotgames.com/docs/portal
  - LoL docs: https://developer.riotgames.com/docs/lol
  - LoR docs: https://developer.riotgames.com/docs/lor
  - TFT docs: https://developer.riotgames.com/docs/tft
  - VAL docs: https://developer.riotgames.com/docs/valorant
- about API key: https://developer.riotgames.com/apis

### Example
#### Create a client with `apiKey`
```C#
var apiKey = ""; /* Your API key */
var client = new LolClient(apiKey, Riot.Net.Enums.PlatformRouting.EUN1, Riot.Net.Enums.RegionalRouting.AMERICAS);
```

#### Get champion info
```C#
var version = "13.4.1";
var language = Riot.Net.Enums.Language.English_UnitedStates;
var result = await client.DataDragon.Champions.GetChampionsAsync(version, language);
```

## Feedback
[Issue](https://github.com/dongbin300/Riot.Net/issues)

## Donate
[Donate](https://www.buymeacoffee.com/psS4YtQ)

## Release Notes
- Version 2.0.16 - _2023-03-14_
  - Initial commit
