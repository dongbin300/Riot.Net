namespace Lol.Net.Objects.Models.LolModels
{
    public record LolStatusPlatformData(string id, string name, IEnumerable<string> locales, IEnumerable<LolStatusPlatformDataStatus> maintenances, IEnumerable<LolStatusPlatformDataStatus> incidents);

    public record LolStatusPlatformDataStatus(int id, string maintenance_status, string incident_severity, IEnumerable<LolStatusPlatformDataContent> titles, IEnumerable<LolStatusPlatformDataUpdate> updates, string created_at, string archive_at, string updated_at, IEnumerable<string> platforms);

    public record LolStatusPlatformDataContent(string locale, string content);

    public record LolStatusPlatformDataUpdate(int id, string author, bool publish, IEnumerable<string> publish_locations, IEnumerable<LolStatusPlatformDataContent> translations, string created_at, string updated_at);
}
