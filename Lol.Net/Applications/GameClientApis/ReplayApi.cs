using Lol.Net.Objects.Models;
using Lol.Net.Objects.Models.GameClients;
using Lol.Net.Objects.Models.GameClients.Replays;

using System.Text;

namespace Lol.Net.Applications.GameClientApis
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
    public class ReplayApi
    {
        private readonly HttpClient client;

        public ReplayApi(HttpClient client)
        {
            this.client = client;
        }

        public async Task<GameClientProcess> GetGameAsync()
        {
            return await BaseApplication.RequestAsync<GameClientProcess>(client, "https://127.0.0.1:2999/replay/game").ConfigureAwait(false);
        }

        public async Task<ReplayPlaybackState> GetPlaybackAsync()
        {
            return await BaseApplication.RequestAsync<ReplayPlaybackState>(client, "https://127.0.0.1:2999/replay/playback").ConfigureAwait(false);
        }

        public async Task<PostResponse<ReplayPlaybackState>> PostPlaybackAsync(string jsonString)
        {
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            return await BaseApplication.RequestPostAsync<PostResponse<ReplayPlaybackState>>(client, "https://127.0.0.1:2999/replay/playback", content).ConfigureAwait(false);
        }

        public async Task<RenderProperty> GetRenderAsync()
        {
            return await BaseApplication.RequestAsync<RenderProperty>(client, "https://127.0.0.1:2999/replay/render").ConfigureAwait(false);
        }

        public async Task<PostResponse<RenderProperty>> PostRenderAsync(string jsonString)
        {
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            return await BaseApplication.RequestPostAsync<PostResponse<RenderProperty>>(client, "https://127.0.0.1:2999/replay/render", content).ConfigureAwait(false);
        }

        public async Task<VideoRecordingStatus> GetRecordingAsync()
        {
            return await BaseApplication.RequestAsync<VideoRecordingStatus>(client, "https://127.0.0.1:2999/replay/recording").ConfigureAwait(false);
        }

        public async Task<PostResponse<VideoRecordingStatus>> PostRecordingAsync(string jsonString)
        {
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            return await BaseApplication.RequestPostAsync<PostResponse<VideoRecordingStatus>>(client, "https://127.0.0.1:2999/replay/recording", content).ConfigureAwait(false);
        }

        public async Task<ReplaySequence> GetSequenceAsync()
        {
            return await BaseApplication.RequestAsync<ReplaySequence>(client, "https://127.0.0.1:2999/replay/sequence").ConfigureAwait(false);
        }

        public async Task<PostResponse<ReplaySequence>> PostSequenceAsync(string jsonString)
        {
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            return await BaseApplication.RequestPostAsync<PostResponse<ReplaySequence>>(client, "https://127.0.0.1:2999/replay/sequence", content).ConfigureAwait(false);
        }
    }
}
