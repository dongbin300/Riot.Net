namespace Lol.Net.Objects.Models
{
    public record Response<T>(string type, string format, string version, T data);
}
