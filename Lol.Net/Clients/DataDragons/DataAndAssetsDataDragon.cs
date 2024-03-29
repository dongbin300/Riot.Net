﻿using Lol.Net.Objects;

using Riot.Net.Clients;
using Riot.Net.Extensions;

namespace Lol.Net.Clients.DataDragons
{
    public class DataAndAssetsDataDragon : BaseClient
    {
        public DataAndAssetsDataDragon(HttpClient client) : base(client)
        {
        }

        public async Task<IEnumerable<string>> GetLanguagesAsync()
        {
            return await GetAsync<IEnumerable<string>>(Client, LolApiAddresses.DataDragonHttpsAddress.CombineUri("languages.json")).ConfigureAwait(false);
        }
    }
}
