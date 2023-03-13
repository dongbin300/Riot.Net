namespace Tft.Net.Objects.Models.TftModels
{
    public record TftMatch(TftMatchMetadata metadata, TftMatchInfo info);

    public record TftMatchMetadata(string data_version, string match_id, IEnumerable<string> participants);

    public record TftMatchInfo(long game_datetime, decimal game_length, string game_variation, string game_version, IEnumerable<TftMatchParticipant> participants, int queue_id, int tft_set_number);

    public record TftMatchParticipant(TftMatchCompanion companion, int gold_left, int last_round, int level, int placement, int players_eliminated, string puuid, decimal time_eliminated, int total_damage_to_players, IEnumerable<TftMatchTrait> traits, IEnumerable<TftMatchUnit> units);

    public record TftMatchCompanion(int item_ID, int skin_ID, string content_ID, string species);

    public record TftMatchTrait(string name, int num_units, int style, int tier_current, int tier_total);

    public record TftMatchUnit(IEnumerable<int> items, string character_id, string chosen, string name, int rarity, int tier);
}
