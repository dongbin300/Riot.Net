using Lol.Net.Clients;
using Lol.Net.Enums;

using Riot.Net.Enums;

namespace Riot.Net.Test
{
    internal class Program
    {
        static string summonerId = "h5QkG9WoGSTV7AsrHtTRtrYLrxIIvSeSA5bU1I6Pri3b4g";
        static string puuId = "FfTfELL3_FSozEhxiMhytHAGMHH6cQ8HvYxWLcoKBh43WCLS1cLfoLSW7pgw2GciTBO0ywbxWSazkQ";
        static string version = "13.4.1";

        static void Main(string[] args)
        {
            var apiKey = File.ReadAllText("C:\\riotapi.txt");
            var app = new LolClient(apiKey, defaultPlatformRouting: PlatformRouting.KR, RegionalRouting.ASIA);
            var result = app.ChampionMastery.GetAllChampionMasteryAsync(summonerId);
            result.Wait();

            Console.WriteLine(result);
        }
    }
}