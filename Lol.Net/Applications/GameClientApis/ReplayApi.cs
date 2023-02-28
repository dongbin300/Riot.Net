namespace Lol.Net.Applications.GameClientApis
{
    /// <summary>
    /// TODO
    /// 
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

        public async Task GetGame()
        {

        }

        public async Task GetPlayback()
        {

        }

        public async Task PostPlayback()
        {

        }

        public async Task GetRender()
        {

        }

        public async Task PostRender()
        {

        }

        public async Task GetRecording()
        {

        }

        public async Task PostRecording()
        {

        }

        public async Task GetSequence()
        {

        }

        public async Task PostSequence()
        {

        }
    }
}
