namespace Lor.Net.Enums
{
    public class SetBundleTypeEnum
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public SetBundleTypeEnum(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class SetBundleType
    {
        public static readonly SetBundleTypeEnum Set1_Full = new("set1", "Set1 Full");
        public static readonly SetBundleTypeEnum Set2_Full = new("set2", "Set2 Full");
        public static readonly SetBundleTypeEnum Set3_Full = new("set3", "Set3 Full");
        public static readonly SetBundleTypeEnum Set4_Full = new("set4", "Set4 Full");
        public static readonly SetBundleTypeEnum Set5_Full = new("set5", "Set5 Full");
        public static readonly SetBundleTypeEnum Set6_Full = new("set6", "Set6 Full");
        public static readonly SetBundleTypeEnum Set6Cde_Full = new("set6cde", "Set6CDE Full");
        public static readonly SetBundleTypeEnum Set1_Lite = new("set1-lite", "Set1 Lite");
        public static readonly SetBundleTypeEnum Set2_Lite = new("set2-lite", "Set2 Lite");
        public static readonly SetBundleTypeEnum Set3_Lite = new("set3-lite", "Set3 Lite");
        public static readonly SetBundleTypeEnum Set4_Lite = new("set4-lite", "Set4 Lite");
        public static readonly SetBundleTypeEnum Set5_Lite = new("set5-lite", "Set5 Lite");
        public static readonly SetBundleTypeEnum Set6_Lite = new("set6-lite", "Set6 Lite");
        public static readonly SetBundleTypeEnum Set6Cde_Lite = new("set6cde-lite", "Set6CDE Lite");
    }
}
