namespace Tft.Net.Objects.Models.TftModels
{
    public record TftStatusPlatformData(string id, string name, IEnumerable<string> locales, IEnumerable<TftStatus> maintenances, IEnumerable<TftStatus> incidents);

    public record TftStatus(int id, string maintenance_status, string incident_severity, IEnumerable<TftStatusContent> titles, IEnumerable<TftStatusUpdate> updates, string created_at, string archive_at, string updated_at, IEnumerable<string> platforms);

    public record TftStatusContent(string locale, string content);

    public record TftStatusUpdate(int id, string author, bool publish, IEnumerable<string> publish_locations, IEnumerable<TftStatusContent> translations, string created_at, string updated_at);
}
