using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [Hotfix]
    [DBTableName("prestige_level_info")]
    public sealed record PrestigeLevelInfoHotfix440: IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("Name")]
        public string Name;

        [DBFieldName("HonorLevel")]
        public int? HonorLevel;

        [DBFieldName("BadgeTextureFileDataID")]
        public int? BadgeTextureFileDataID;

        [DBFieldName("Flags")]
        public byte? Flags;

        [DBFieldName("AwardedAchievementID")]
        public int? AwardedAchievementID;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [Hotfix]
    [DBTableName("prestige_level_info_locale")]
    public sealed record PrestigeLevelInfoLocaleHotfix440: IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("locale", true)]
        public string Locale = ClientLocale.PacketLocaleString;

        [DBFieldName("Name_lang")]
        public string NameLang;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
