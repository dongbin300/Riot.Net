using Val.Net.Clients;

namespace Riot.Net.Test
{
    internal class Program
    {
        static string developmentApiKey = "RGAPI-dba6629c-fbc3-40a5-8f06-30f4ac9977b2";

        static void Main(string[] args)
        {
            ValClient app = new ValClient(developmentApiKey, Val.Net.Enums.ValRegion.KR);

             var result = app.Content.GetContentOptionallyByLocaleAsync();
            result.Wait();

            Console.WriteLine(result);
        }
    }
}