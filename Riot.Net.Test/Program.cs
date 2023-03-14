using Tft.Net.Clients;

namespace Riot.Net.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TftClient app = new TftClient(Configuration.DevelopmentApiKey, Enums.PlatformRouting.KR, Enums.RegionalRouting.ASIA);

             var result = app.Summoner.GetSummonerBySummonerNameAsync("플라인드");
            result.Wait();

            Console.WriteLine(result);
        }
    }
}