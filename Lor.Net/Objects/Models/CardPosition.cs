namespace Lor.Net.Objects.Models
{
    public record CardPosition(string PlayerName, string OpponentName, string GameState, CardPosition_Screen Screen, IEnumerable<CardPosition_Rectangle> Rectangles);

    public record CardPosition_Screen(int ScreenWidth, int ScreenHeight);

    public record CardPosition_Rectangle(int CardID, string CardCode, int TopLeftX, int TopLeftY, int Width, int Height, bool LocalPlayer);
}
