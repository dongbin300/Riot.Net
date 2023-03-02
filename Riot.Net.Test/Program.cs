using Lol.Net.Applications;
using Lol.Net.Enums;

namespace Riot.Net.Test
{
    internal class Program
    {
        static string version = "13.4.1";
        static LanguageEnum language = Language.Korean_Korea;

        static void Main(string[] args)
        {
            var app = new LolApplication();
            var result = app.DataDragon.Champions.GetChampionDetailAsync(Champion.Vayne, version, language);
            result.Wait();

            Console.WriteLine(result);
        }
    }
}