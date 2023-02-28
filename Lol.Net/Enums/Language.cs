namespace Lol.Net.Enums
{
    public class LanguageEnum
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public LanguageEnum(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Language
    {
        public static readonly LanguageEnum Czech_CzechRepublic = new("cs_CZ", "Czech (Czech Republic)");
        public static readonly LanguageEnum Greek_Greece = new("el_GR", "Greek (Greece)");
        public static readonly LanguageEnum Polish_Poland = new("pl_PL", "Polish (Poland)");
        public static readonly LanguageEnum Romanian_Romania = new("ro_RO", "Romanian (Romania)");
        public static readonly LanguageEnum Hungarian_Hungary = new("hu_HU", "Hungarian (Hungary)");
        public static readonly LanguageEnum English_UnitedKingdom = new("en_GB", "English (United Kingdom)");
        public static readonly LanguageEnum German_Germany = new("de_DE", "German (Germany)");
        public static readonly LanguageEnum Spanish_Spain = new("es_ES", "Spanish (Spain)");
        public static readonly LanguageEnum Italian_Italy = new("it_IT", "Italian (Italy)");
        public static readonly LanguageEnum French_France = new("fr_FR", "French (France)");
        public static readonly LanguageEnum Japanese_Japan = new("ja_JP", "Japanese (Japan)");
        public static readonly LanguageEnum Korean_Korea = new("ko_KR", "Korean (Korea)");
        public static readonly LanguageEnum Spanish_Mexico = new("es_MX", "Spanish (Mexico)");
        public static readonly LanguageEnum Spanish_Argentina = new("es_AR", "Spanish (Argentina)");
        public static readonly LanguageEnum Portuguese_Brazil = new("pt_BR", "Portuguese (Brazil)");
        public static readonly LanguageEnum English_UnitedStates = new("en_US", "English (United States)");
        public static readonly LanguageEnum English_Australia = new("en_AU", "English (Australia)");
        public static readonly LanguageEnum Russian_Russia = new("ru_RU", "Russian (Russia)");
        public static readonly LanguageEnum TurkishTurkey = new("tr_TR", "Turkish (Turkey)");
        public static readonly LanguageEnum Malay_Malaysia = new("ms_MY", "Malay (Malaysia)");
        public static readonly LanguageEnum English_RepublicOfThePhilippines = new("en_PH", "English (Republic of the Philippines)");
        public static readonly LanguageEnum English_Singapore = new("en_SG", "English (Singapore)");
        public static readonly LanguageEnum Thai_Thailand = new("th_TH", "Thai (Thailand)");
        public static readonly LanguageEnum Vietnamese_VietNam = new("vn_VN", "Vietnamese (Viet Nam)");
        public static readonly LanguageEnum Indonesian_Indonesia = new("id_ID", "Indonesian (Indonesia)");
        public static readonly LanguageEnum Chinese_Malaysia = new("zh_MY", "Chinese (Malaysia)");
        public static readonly LanguageEnum Chinese_China = new("zh_CN", "Chinese (China)");
        public static readonly LanguageEnum Chinese_Taiwan = new("zh_TW", "Chinese (Taiwan)");
    }
}
