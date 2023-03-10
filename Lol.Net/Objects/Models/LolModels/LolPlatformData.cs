namespace Lol.Net.Objects.Models.LolModels
{
    public record LolPlatformData(string id, string name, IEnumerable<string> locales, IEnumerable<LolPlatformDataStatus> maintenances, IEnumerable<LolPlatformDataStatus> incidents);

    public record LolPlatformDataStatus(int id, string maintenance_status, string incident_severity, IEnumerable<LolPlatformDataContent> titles, IEnumerable<LolPlatformDataUpdate> updates, string created_at, string archive_at, string updated_at, IEnumerable<string> platforms);

    public record LolPlatformDataContent(string locale, string content);

    public record LolPlatformDataUpdate(int id, string author, bool publish, IEnumerable<string> publish_locations, IEnumerable<LolPlatformDataContent> translations, string created_at, string updated_at);
}
