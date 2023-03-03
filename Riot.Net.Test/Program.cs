using Lol.Net.Clients;
using Lol.Net.Enums;

namespace Riot.Net.Test
{
    internal class Program
    {
        static string version = "13.4.1";
        static LanguageEnum language = Language.Korean_Korea;

        static void Main(string[] args)
        {
            var app = new LolClient();
            var result = app.DataDragon.Champions.GetChampionAbilityAssetsAsync("FlashFrost", version);
            result.Wait();

            Console.WriteLine(result);
        }
    }
}