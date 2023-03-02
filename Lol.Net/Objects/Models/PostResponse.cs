namespace Lol.Net.Objects.Models
{
    public record PostResponse<T>(string errorCode, int httpStatus, string message, T? data);
}
