using Lol.Net.Clients;
using Lol.Net.Enums;

using Riot.Net.Enums;

namespace Riot.Net.Test
{
    internal class Program
    {
        static string summonerId = "h5QkG9WoGSTV7AsrHtTRtrYLrxIIvSeSA5bU1I6Pri3b4g";
        static string version = "13.4.1";

        static void Main(string[] args)
        {
            var apiKey = File.ReadAllText("C:\\riotapi.txt");
            var app = new LolClient(apiKey, PlatformRouting.KR);
            var result = app.League.GetAllLeagueEntriesAsync(Queue.RankedSolo55, Tier.GOLD, Division.IV, 2);
            result.Wait();

            Console.WriteLine(result);
        }
    }
}