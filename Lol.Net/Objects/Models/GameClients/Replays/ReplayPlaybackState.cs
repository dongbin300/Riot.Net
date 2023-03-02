namespace Lol.Net.Objects.Models.GameClients.Replays
{
    public record ReplayPlaybackState(decimal length, bool paused, bool seeking, decimal speed, decimal time);
}
