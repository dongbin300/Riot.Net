namespace Lol.Net.Objects.Models.GameClients.Replays
{
    public record VideoRecordingStatus
    (
        string codec,
        decimal currentTime,
        decimal endTime,
        bool enforceFrameRate,
        int framesPerSecond,
        int height,
        bool lossless,
        string path,
        bool recording,
        decimal replaySpeed,
        decimal startTime,
        int width
    );
}
