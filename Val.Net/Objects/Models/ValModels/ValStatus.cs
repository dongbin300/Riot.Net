namespace Val.Net.Objects.Models.ValModels
{
    public record ValStatusPlatformData(string id, string name, IEnumerable<string> locales, IEnumerable<ValStatus> maintenances, IEnumerable<ValStatus> incidents);

    public record ValStatus(int id, string maintenance_status, string incident_severity, IEnumerable<ValStatusContent> titles, IEnumerable<ValStatusUpdate> updates, string created_at, string archive_at, string updated_at, IEnumerable<string> platforms);

    public record ValStatusContent(string locale, string content);

    public record ValStatusUpdate(int id, string author, bool publish, IEnumerable<string> publish_locations, IEnumerable<ValStatusContent> translations, string created_at, string updated_at);
}
