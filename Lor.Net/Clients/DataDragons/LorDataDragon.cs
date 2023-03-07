using Riot.Net.Clients;

namespace Lor.Net.Clients.DataDragons
{
    public class LorDataDragon : BaseClient
    {
        public CoreBundlesDataDragon CoreBundles { get; }
        public SetBundlesDataDragon SetBundles { get; }

        public LorDataDragon(HttpClient client) : base(client)
        {
            CoreBundles = new CoreBundlesDataDragon(client);
            SetBundles = new SetBundlesDataDragon(client);
        }
    }
}
