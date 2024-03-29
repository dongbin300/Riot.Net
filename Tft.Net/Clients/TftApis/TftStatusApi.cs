﻿using Riot.Net.Clients;
using Riot.Net.Enums;

using Tft.Net.Objects.Models.TftModels;

namespace Tft.Net.Clients.TftApis
{
    public class TftStatusApi : ApiClient
    {
        public TftStatusApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<TftStatusPlatformData> GetStatusAsync()
        {
            return await GetAsync<TftStatusPlatformData>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/status/v1/platform-data?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}
