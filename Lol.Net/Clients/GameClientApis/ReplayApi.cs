using Lol.Net.Objects;
using Lol.Net.Objects.Models;
using Lol.Net.Objects.Models.GameClients;
using Lol.Net.Objects.Models.GameClients.Replays;

using Riot.Net.Clients;
using Riot.Net.Extensions;

using System.Text;

namespace Lol.Net.Clients.GameClientApis
{
    /// <summary>
    /// By default the Replay API is disabled.To start using the Replay API,
    /// enable the Replay API in the game client config by locating where your game is installed
    /// and adding the following lines to the game.cfg file:
    /// 
    /// Example file location:
    /// C:\Riot Games\League of Legends\Config\game.cfg
    ///-----------------------------------------------
    /// [General]
    ///    EnableReplayApi = 1
    ///-----------------------------------------------
    /// <see cref="https://developer.riotgames.com/docs/lol#game-client-api_replay-api"/>
    /// </summary>
    public class ReplayApi : BaseClient
    {
        public ReplayApi(HttpClient client) : base(client)
        {

        }

        public async Task<GameClientProcess> GetGameAsync()
        {
            return await GetAsync<GameClientProcess>(client, LolApiAddresses.ReplayAddress.CombineUri("game")).ConfigureAwait(false);
        }

        public async Task<ReplayPlaybackState> GetPlaybackAsync()
        {
            return await GetAsync<ReplayPlaybackState>(client, LolApiAddresses.ReplayAddress.CombineUri("playback")).ConfigureAwait(false);
        }

        public async Task<PostResponse<ReplayPlaybackState>> PostPlaybackAsync(string jsonString)
        {
            return await PostAsync<PostResponse<ReplayPlaybackState>>(client, LolApiAddresses.ReplayAddress.CombineUri("playback"), jsonString).ConfigureAwait(false);
        }

        public async Task<RenderProperty> GetRenderAsync()
        {
            return await GetAsync<RenderProperty>(client, LolApiAddresses.ReplayAddress.CombineUri("render")).ConfigureAwait(false);
        }

        public async Task<PostResponse<RenderProperty>> PostRenderAsync(string jsonString)
        {
            return await PostAsync<PostResponse<RenderProperty>>(client, LolApiAddresses.ReplayAddress.CombineUri("render"), jsonString).ConfigureAwait(false);
        }

        public async Task<VideoRecordingStatus> GetRecordingAsync()
        {
            return await GetAsync<VideoRecordingStatus>(client, LolApiAddresses.ReplayAddress.CombineUri("recording")).ConfigureAwait(false);
        }

        public async Task<PostResponse<VideoRecordingStatus>> PostRecordingAsync(string jsonString)
        {
            return await PostAsync<PostResponse<VideoRecordingStatus>>(client, LolApiAddresses.ReplayAddress.CombineUri("recording"), jsonString).ConfigureAwait(false);
        }

        public async Task<ReplaySequence> GetSequenceAsync()
        {
            return await GetAsync<ReplaySequence>(client, LolApiAddresses.ReplayAddress.CombineUri("sequence")).ConfigureAwait(false);
        }

        public async Task<PostResponse<ReplaySequence>> PostSequenceAsync(string jsonString)
        {
            return await PostAsync<PostResponse<ReplaySequence>>(client, LolApiAddresses.ReplayAddress.CombineUri("sequence"), jsonString).ConfigureAwait(false);
        }
    }
}
