using Newtonsoft.Json;

namespace Val.Net.Objects.Models.ValModels
{
    public record ValContent(string version, IEnumerable<ValContentItem> characters, IEnumerable<ValContentItem> maps, IEnumerable<ValContentItem> chromas, IEnumerable<ValContentItem> skins, IEnumerable<ValContentItem> skinLevels, IEnumerable<ValContentItem> equips, IEnumerable<ValContentItem> gameModes, IEnumerable<ValContentItem> sprays, IEnumerable<ValContentItem> sprayLevels, IEnumerable<ValContentItem> charms, IEnumerable<ValContentItem> charmLevels, IEnumerable<ValContentItem> playerCards, IEnumerable<ValContentItem> playerTitles, IEnumerable<ValContentAct> acts);

    public record ValContentItem(string name, ValContentLocalizedNames localizedNames, string id, string assetName, string assetPath);

    public record ValContentLocalizedNames(
        [JsonProperty("ar-AE")] string arAE,
        [JsonProperty("de-DE")] string deDE,
        [JsonProperty("en-GB")] string enGB,
        [JsonProperty("en-US")] string enUS,
        [JsonProperty("es-ES")] string esES,
        [JsonProperty("es-MX")] string esMX,
        [JsonProperty("fr-FR")] string frFR,
        [JsonProperty("id-ID")] string idID,
        [JsonProperty("it-IT")] string itIT,
        [JsonProperty("ja-JP")] string jaJP,
        [JsonProperty("ko-KR")] string koKR,
        [JsonProperty("pl-PL")] string plPL,
        [JsonProperty("pt-BR")] string ptBR,
        [JsonProperty("ru-RU")] string ruRU,
        [JsonProperty("th-TH")] string thTH,
        [JsonProperty("tr-TR")] string trTR,
        [JsonProperty("vi-VN")] string viVN,
        [JsonProperty("zh-CN")] string zhCN,
        [JsonProperty("zh-TW")] string zhTW);

    public record ValContentAct(string name, ValContentLocalizedNames localizedNames, string id, bool isActive);
}
