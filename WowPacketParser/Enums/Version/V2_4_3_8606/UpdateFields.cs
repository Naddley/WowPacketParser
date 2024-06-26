﻿namespace WowPacketParser.Enums.Version.V2_4_3_8606
{
    // ReSharper disable InconsistentNaming
    // 2.4.3
    public enum ObjectField
    {
        OBJECT_FIELD_GUID = 0x0000, // Size: 2, Type: LONG, Flags: PUBLIC
        OBJECT_FIELD_TYPE = 0x0002, // Size: 1, Type: INT, Flags: PUBLIC
        OBJECT_FIELD_ENTRY = 0x0003, // Size: 1, Type: INT, Flags: PUBLIC
        OBJECT_FIELD_SCALE_X = 0x0004, // Size: 1, Type: FLOAT, Flags: PUBLIC
        OBJECT_FIELD_PADDING = 0x0005, // Size: 1, Type: INT, Flags: NONE
        OBJECT_END = 0x0006
    }

    public enum ItemField
    {
        ITEM_FIELD_OWNER = ObjectField.OBJECT_END + 0x0000, // Size: 2, Type: LONG, Flags: PUBLIC
        ITEM_FIELD_CONTAINED = ObjectField.OBJECT_END + 0x0002, // Size: 2, Type: LONG, Flags: PUBLIC
        ITEM_FIELD_CREATOR = ObjectField.OBJECT_END + 0x0004, // Size: 2, Type: LONG, Flags: PUBLIC
        ITEM_FIELD_GIFTCREATOR = ObjectField.OBJECT_END + 0x0006, // Size: 2, Type: LONG, Flags: PUBLIC
        ITEM_FIELD_STACK_COUNT = ObjectField.OBJECT_END + 0x0008, // Size: 1, Type: INT, Flags: OWNER_ONLY, UNK2
        ITEM_FIELD_DURATION = ObjectField.OBJECT_END + 0x0009, // Size: 1, Type: INT, Flags: OWNER_ONLY, UNK2
        ITEM_FIELD_SPELL_CHARGES = ObjectField.OBJECT_END + 0x000A, // Size: 5, Type: INT, Flags: OWNER_ONLY, UNK2
        ITEM_FIELD_FLAGS = ObjectField.OBJECT_END + 0x000F, // Size: 1, Type: INT, Flags: PUBLIC
        ITEM_FIELD_ENCHANTMENT_1_1 = ObjectField.OBJECT_END + 0x0010, // Size: 33, Type: INT, Flags: PUBLIC
        ITEM_FIELD_ENCHANTMENT_1_3 = ObjectField.OBJECT_END + 0x0012,
        ITEM_FIELD_ENCHANTMENT_2_1 = ObjectField.OBJECT_END + 0x0013,
        ITEM_FIELD_ENCHANTMENT_2_3 = ObjectField.OBJECT_END + 0x0015,
        ITEM_FIELD_ENCHANTMENT_3_1 = ObjectField.OBJECT_END + 0x0016,
        ITEM_FIELD_ENCHANTMENT_3_3 = ObjectField.OBJECT_END + 0x0018,
        ITEM_FIELD_ENCHANTMENT_4_1 = ObjectField.OBJECT_END + 0x0019,
        ITEM_FIELD_ENCHANTMENT_4_3 = ObjectField.OBJECT_END + 0x001B,
        ITEM_FIELD_ENCHANTMENT_5_1 = ObjectField.OBJECT_END + 0x001C,
        ITEM_FIELD_ENCHANTMENT_5_3 = ObjectField.OBJECT_END + 0x001E,
        ITEM_FIELD_ENCHANTMENT_6_1 = ObjectField.OBJECT_END + 0x001F,
        ITEM_FIELD_ENCHANTMENT_6_3 = ObjectField.OBJECT_END + 0x0021,
        ITEM_FIELD_ENCHANTMENT_7_1 = ObjectField.OBJECT_END + 0x0022,
        ITEM_FIELD_ENCHANTMENT_7_3 = ObjectField.OBJECT_END + 0x0024,
        ITEM_FIELD_ENCHANTMENT_8_1 = ObjectField.OBJECT_END + 0x0025,
        ITEM_FIELD_ENCHANTMENT_8_3 = ObjectField.OBJECT_END + 0x0027,
        ITEM_FIELD_ENCHANTMENT_9_1 = ObjectField.OBJECT_END + 0x0028,
        ITEM_FIELD_ENCHANTMENT_9_3 = ObjectField.OBJECT_END + 0x002A,
        ITEM_FIELD_ENCHANTMENT_10_1 = ObjectField.OBJECT_END + 0x002B,
        ITEM_FIELD_ENCHANTMENT_10_3 = ObjectField.OBJECT_END + 0x002D,
        ITEM_FIELD_ENCHANTMENT_11_1 = ObjectField.OBJECT_END + 0x002E,
        ITEM_FIELD_ENCHANTMENT_11_3 = ObjectField.OBJECT_END + 0x0030,
        ITEM_FIELD_PROPERTY_SEED = ObjectField.OBJECT_END + 0x0031, // Size: 1, Type: INT, Flags: PUBLIC
        ITEM_FIELD_RANDOM_PROPERTIES_ID = ObjectField.OBJECT_END + 0x0032, // Size: 1, Type: INT, Flags: PUBLIC
        ITEM_FIELD_ITEM_TEXT_ID = ObjectField.OBJECT_END + 0x0033, // Size: 1, Type: INT, Flags: OWNER_ONLY
        ITEM_FIELD_DURABILITY = ObjectField.OBJECT_END + 0x0034, // Size: 1, Type: INT, Flags: OWNER_ONLY, UNK2
        ITEM_FIELD_MAXDURABILITY = ObjectField.OBJECT_END + 0x0035, // Size: 1, Type: INT, Flags: OWNER_ONLY, UNK2
        ITEM_END = ObjectField.OBJECT_END + 0x0036
    }

    public enum ContainerField
    {
        CONTAINER_FIELD_NUM_SLOTS = ItemField.ITEM_END + 0x0000, // Size: 1, Type: INT, Flags: PUBLIC
        CONTAINER_ALIGN_PAD = ItemField.ITEM_END + 0x0001, // Size: 1, Type: BYTES, Flags: NONE
        CONTAINER_FIELD_SLOT_1 = ItemField.ITEM_END + 0x0002, // Size: 72, Type: LONG, Flags: PUBLIC
        CONTAINER_END = ItemField.ITEM_END + 0x004A
    }

    public enum UnitField
    {
        UNIT_FIELD_CHARM = ObjectField.OBJECT_END + 0x0000,
        UNIT_FIELD_SUMMON = ObjectField.OBJECT_END + 0x0002,
        UNIT_FIELD_CRITTER = ObjectField.OBJECT_END + 0x0004,
        UNIT_FIELD_CHARMEDBY = ObjectField.OBJECT_END + 0x0006,
        UNIT_FIELD_SUMMONEDBY = ObjectField.OBJECT_END + 0x0008,
        UNIT_FIELD_CREATEDBY = ObjectField.OBJECT_END + 0x000A,
        UNIT_FIELD_TARGET = ObjectField.OBJECT_END + 0x000C,
        UNIT_FIELD_CHANNEL_OBJECT = ObjectField.OBJECT_END + 0x000E,
        UNIT_FIELD_HEALTH = ObjectField.OBJECT_END + 0x0010,
        UNIT_FIELD_POWER1 = ObjectField.OBJECT_END + 0x0011,
        UNIT_FIELD_POWER2 = ObjectField.OBJECT_END + 0x0012,
        UNIT_FIELD_POWER3 = ObjectField.OBJECT_END + 0x0013,
        UNIT_FIELD_POWER4 = ObjectField.OBJECT_END + 0x0014,
        UNIT_FIELD_POWER5 = ObjectField.OBJECT_END + 0x0015,
        UNIT_FIELD_MAXHEALTH = ObjectField.OBJECT_END + 0x0016,
        UNIT_FIELD_MAXPOWER1 = ObjectField.OBJECT_END + 0x0017,
        UNIT_FIELD_MAXPOWER2 = ObjectField.OBJECT_END + 0x0018,
        UNIT_FIELD_MAXPOWER3 = ObjectField.OBJECT_END + 0x0019,
        UNIT_FIELD_MAXPOWER4 = ObjectField.OBJECT_END + 0x001A,
        UNIT_FIELD_MAXPOWER5 = ObjectField.OBJECT_END + 0x001B,
        UNIT_FIELD_LEVEL = ObjectField.OBJECT_END + 0x001C,
        UNIT_FIELD_FACTIONTEMPLATE = ObjectField.OBJECT_END + 0x001D,
        UNIT_FIELD_BYTES_0 = ObjectField.OBJECT_END + 0x001E,
        UNIT_VIRTUAL_ITEM_SLOT_ID = ObjectField.OBJECT_END + 0x001F,
        UNIT_VIRTUAL_ITEM_INFO = ObjectField.OBJECT_END + 0x0022,
        UNIT_FIELD_FLAGS = ObjectField.OBJECT_END + 0x0028,
        UNIT_FIELD_FLAGS_2 = ObjectField.OBJECT_END + 0x0029,
        UNIT_FIELD_AURA = ObjectField.OBJECT_END + 0x002A,
        UNIT_FIELD_AURAFLAGS = ObjectField.OBJECT_END + 0x0062,
        UNIT_FIELD_AURALEVELS = ObjectField.OBJECT_END + 0x0070,
        UNIT_FIELD_AURAAPPLICATIONS = ObjectField.OBJECT_END + 0x007E,
        UNIT_FIELD_AURASTATE = ObjectField.OBJECT_END + 0x008C,
        UNIT_FIELD_BASEATTACKTIME = ObjectField.OBJECT_END + 0x008D,
        UNIT_FIELD_RANGEDATTACKTIME = ObjectField.OBJECT_END + 0x008F,
        UNIT_FIELD_BOUNDINGRADIUS = ObjectField.OBJECT_END + 0x0090,
        UNIT_FIELD_COMBATREACH = ObjectField.OBJECT_END + 0x0091,
        UNIT_FIELD_DISPLAYID = ObjectField.OBJECT_END + 0x0092,
        UNIT_FIELD_NATIVEDISPLAYID = ObjectField.OBJECT_END + 0x0093,
        UNIT_FIELD_MOUNTDISPLAYID = ObjectField.OBJECT_END + 0x0094,
        UNIT_FIELD_MINDAMAGE = ObjectField.OBJECT_END + 0x0095,
        UNIT_FIELD_MAXDAMAGE = ObjectField.OBJECT_END + 0x0096,
        UNIT_FIELD_MINOFFHANDDAMAGE = ObjectField.OBJECT_END + 0x0097,
        UNIT_FIELD_MAXOFFHANDDAMAGE = ObjectField.OBJECT_END + 0x0098,
        UNIT_FIELD_BYTES_1 = ObjectField.OBJECT_END + 0x0099,
        UNIT_FIELD_PETNUMBER = ObjectField.OBJECT_END + 0x009A,
        UNIT_FIELD_PET_NAME_TIMESTAMP = ObjectField.OBJECT_END + 0x009B,
        UNIT_FIELD_PETEXPERIENCE = ObjectField.OBJECT_END + 0x009C,
        UNIT_FIELD_PETNEXTLEVELEXP = ObjectField.OBJECT_END + 0x009D,
        UNIT_DYNAMIC_FLAGS = ObjectField.OBJECT_END + 0x009E,
        UNIT_CHANNEL_SPELL = ObjectField.OBJECT_END + 0x009F,
        UNIT_MOD_CAST_SPEED = ObjectField.OBJECT_END + 0x00A0,
        UNIT_CREATED_BY_SPELL = ObjectField.OBJECT_END + 0x00A1,
        UNIT_NPC_FLAGS = ObjectField.OBJECT_END + 0x00A2,
        UNIT_NPC_EMOTESTATE = ObjectField.OBJECT_END + 0x00A3,
        UNIT_TRAINING_POINTS = ObjectField.OBJECT_END + 0x00A4,
        UNIT_FIELD_STAT0 = ObjectField.OBJECT_END + 0x00A5,
        UNIT_FIELD_STAT1 = ObjectField.OBJECT_END + 0x00A6,
        UNIT_FIELD_STAT2 = ObjectField.OBJECT_END + 0x00A7,
        UNIT_FIELD_STAT3 = ObjectField.OBJECT_END + 0x00A8,
        UNIT_FIELD_STAT4 = ObjectField.OBJECT_END + 0x00A9,
        UNIT_FIELD_POSSTAT0 = ObjectField.OBJECT_END + 0x00AA,
        UNIT_FIELD_POSSTAT1 = ObjectField.OBJECT_END + 0x00AB,
        UNIT_FIELD_POSSTAT2 = ObjectField.OBJECT_END + 0x00AC,
        UNIT_FIELD_POSSTAT3 = ObjectField.OBJECT_END + 0x00AD,
        UNIT_FIELD_POSSTAT4 = ObjectField.OBJECT_END + 0x00AE,
        UNIT_FIELD_NEGSTAT0 = ObjectField.OBJECT_END + 0x00AF,
        UNIT_FIELD_NEGSTAT1 = ObjectField.OBJECT_END + 0x00B0,
        UNIT_FIELD_NEGSTAT2 = ObjectField.OBJECT_END + 0x00B1,
        UNIT_FIELD_NEGSTAT3 = ObjectField.OBJECT_END + 0x00B2,
        UNIT_FIELD_NEGSTAT4 = ObjectField.OBJECT_END + 0x00B3,
        UNIT_FIELD_RESISTANCES = ObjectField.OBJECT_END + 0x00B4,
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE = ObjectField.OBJECT_END + 0x00BB,
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE = ObjectField.OBJECT_END + 0x00C2,
        UNIT_FIELD_BASE_MANA = ObjectField.OBJECT_END + 0x00C9,
        UNIT_FIELD_BASE_HEALTH = ObjectField.OBJECT_END + 0x00CA,
        UNIT_FIELD_BYTES_2 = ObjectField.OBJECT_END + 0x00CB,
        UNIT_FIELD_ATTACK_POWER = ObjectField.OBJECT_END + 0x00CC,
        UNIT_FIELD_ATTACK_POWER_MODS = ObjectField.OBJECT_END + 0x00CD,
        UNIT_FIELD_ATTACK_POWER_MULTIPLIER = ObjectField.OBJECT_END + 0x00CE,
        UNIT_FIELD_RANGED_ATTACK_POWER = ObjectField.OBJECT_END + 0x00CF,
        UNIT_FIELD_RANGED_ATTACK_POWER_MODS = ObjectField.OBJECT_END + 0x00D0,
        UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER = ObjectField.OBJECT_END + 0x00D1,
        UNIT_FIELD_MINRANGEDDAMAGE = ObjectField.OBJECT_END + 0x00D2,
        UNIT_FIELD_MAXRANGEDDAMAGE = ObjectField.OBJECT_END + 0x00D3,
        UNIT_FIELD_POWER_COST_MODIFIER = ObjectField.OBJECT_END + 0x00D4,
        UNIT_FIELD_POWER_COST_MULTIPLIER1 = ObjectField.OBJECT_END + 0x00DB,
        UNIT_FIELD_POWER_COST_MULTIPLIER2 = ObjectField.OBJECT_END + 0x00DC,
        UNIT_FIELD_POWER_COST_MULTIPLIER3 = ObjectField.OBJECT_END + 0x00DD,
        UNIT_FIELD_POWER_COST_MULTIPLIER4 = ObjectField.OBJECT_END + 0x00DE,
        UNIT_FIELD_POWER_COST_MULTIPLIER5 = ObjectField.OBJECT_END + 0x00DF,
        UNIT_FIELD_POWER_COST_MULTIPLIER6 = ObjectField.OBJECT_END + 0x00E0,
        UNIT_FIELD_POWER_COST_MULTIPLIER7 = ObjectField.OBJECT_END + 0x00E1,
        UNIT_FIELD_MAXHEALTHMODIFIER = ObjectField.OBJECT_END + 0x00E2,
        UNIT_FIELD_PADDING = ObjectField.OBJECT_END + 0x00E3,
        UNIT_END = ObjectField.OBJECT_END + 0x00E4
    }

    public enum PlayerField
    {
        PLAYER_DUEL_ARBITER = UnitField.UNIT_END + 0x0000,
        PLAYER_FLAGS = UnitField.UNIT_END + 0x0002,
        PLAYER_GUILDID = UnitField.UNIT_END + 0x0003,
        PLAYER_GUILDRANK = UnitField.UNIT_END + 0x0004,
        PLAYER_BYTES = UnitField.UNIT_END + 0x0005,
        PLAYER_BYTES_2 = UnitField.UNIT_END + 0x0006,
        PLAYER_BYTES_3 = UnitField.UNIT_END + 0x0007,
        PLAYER_DUEL_TEAM = UnitField.UNIT_END + 0x0008,
        PLAYER_GUILD_TIMESTAMP = UnitField.UNIT_END + 0x0009,
        PLAYER_QUEST_LOG_1_1 = UnitField.UNIT_END + 0x000A,
        PLAYER_QUEST_LOG_1_2 = UnitField.UNIT_END + 0x000B,
        PLAYER_QUEST_LOG_1_3 = UnitField.UNIT_END + 0x000C,
        PLAYER_QUEST_LOG_1_4 = UnitField.UNIT_END + 0x000D,
        PLAYER_QUEST_LOG_2_1 = UnitField.UNIT_END + 0x000E,
        PLAYER_QUEST_LOG_2_2 = UnitField.UNIT_END + 0x000F,
        PLAYER_QUEST_LOG_2_3 = UnitField.UNIT_END + 0x0010,
        PLAYER_QUEST_LOG_2_4 = UnitField.UNIT_END + 0x0011,
        PLAYER_QUEST_LOG_3_1 = UnitField.UNIT_END + 0x0012,
        PLAYER_QUEST_LOG_3_2 = UnitField.UNIT_END + 0x0013,
        PLAYER_QUEST_LOG_3_3 = UnitField.UNIT_END + 0x0014,
        PLAYER_QUEST_LOG_3_4 = UnitField.UNIT_END + 0x0015,
        PLAYER_QUEST_LOG_4_1 = UnitField.UNIT_END + 0x0016,
        PLAYER_QUEST_LOG_4_2 = UnitField.UNIT_END + 0x0017,
        PLAYER_QUEST_LOG_4_3 = UnitField.UNIT_END + 0x0018,
        PLAYER_QUEST_LOG_4_4 = UnitField.UNIT_END + 0x0019,
        PLAYER_QUEST_LOG_5_1 = UnitField.UNIT_END + 0x001A,
        PLAYER_QUEST_LOG_5_2 = UnitField.UNIT_END + 0x001B,
        PLAYER_QUEST_LOG_5_3 = UnitField.UNIT_END + 0x001C,
        PLAYER_QUEST_LOG_5_4 = UnitField.UNIT_END + 0x001D,
        PLAYER_QUEST_LOG_6_1 = UnitField.UNIT_END + 0x001E,
        PLAYER_QUEST_LOG_6_2 = UnitField.UNIT_END + 0x001F,
        PLAYER_QUEST_LOG_6_3 = UnitField.UNIT_END + 0x0020,
        PLAYER_QUEST_LOG_6_4 = UnitField.UNIT_END + 0x0021,
        PLAYER_QUEST_LOG_7_1 = UnitField.UNIT_END + 0x0022,
        PLAYER_QUEST_LOG_7_2 = UnitField.UNIT_END + 0x0023,
        PLAYER_QUEST_LOG_7_3 = UnitField.UNIT_END + 0x0024,
        PLAYER_QUEST_LOG_7_4 = UnitField.UNIT_END + 0x0025,
        PLAYER_QUEST_LOG_8_1 = UnitField.UNIT_END + 0x0026,
        PLAYER_QUEST_LOG_8_2 = UnitField.UNIT_END + 0x0027,
        PLAYER_QUEST_LOG_8_3 = UnitField.UNIT_END + 0x0028,
        PLAYER_QUEST_LOG_8_4 = UnitField.UNIT_END + 0x0029,
        PLAYER_QUEST_LOG_9_1 = UnitField.UNIT_END + 0x002A,
        PLAYER_QUEST_LOG_9_2 = UnitField.UNIT_END + 0x002B,
        PLAYER_QUEST_LOG_9_3 = UnitField.UNIT_END + 0x002C,
        PLAYER_QUEST_LOG_9_4 = UnitField.UNIT_END + 0x002D,
        PLAYER_QUEST_LOG_10_1 = UnitField.UNIT_END + 0x002E,
        PLAYER_QUEST_LOG_10_2 = UnitField.UNIT_END + 0x002F,
        PLAYER_QUEST_LOG_10_3 = UnitField.UNIT_END + 0x0030,
        PLAYER_QUEST_LOG_10_4 = UnitField.UNIT_END + 0x0031,
        PLAYER_QUEST_LOG_11_1 = UnitField.UNIT_END + 0x0032,
        PLAYER_QUEST_LOG_11_2 = UnitField.UNIT_END + 0x0033,
        PLAYER_QUEST_LOG_11_3 = UnitField.UNIT_END + 0x0034,
        PLAYER_QUEST_LOG_11_4 = UnitField.UNIT_END + 0x0035,
        PLAYER_QUEST_LOG_12_1 = UnitField.UNIT_END + 0x0036,
        PLAYER_QUEST_LOG_12_2 = UnitField.UNIT_END + 0x0037,
        PLAYER_QUEST_LOG_12_3 = UnitField.UNIT_END + 0x0038,
        PLAYER_QUEST_LOG_12_4 = UnitField.UNIT_END + 0x0039,
        PLAYER_QUEST_LOG_13_1 = UnitField.UNIT_END + 0x003A,
        PLAYER_QUEST_LOG_13_2 = UnitField.UNIT_END + 0x003B,
        PLAYER_QUEST_LOG_13_3 = UnitField.UNIT_END + 0x003C,
        PLAYER_QUEST_LOG_13_4 = UnitField.UNIT_END + 0x003D,
        PLAYER_QUEST_LOG_14_1 = UnitField.UNIT_END + 0x003E,
        PLAYER_QUEST_LOG_14_2 = UnitField.UNIT_END + 0x003F,
        PLAYER_QUEST_LOG_14_3 = UnitField.UNIT_END + 0x0040,
        PLAYER_QUEST_LOG_14_4 = UnitField.UNIT_END + 0x0041,
        PLAYER_QUEST_LOG_15_1 = UnitField.UNIT_END + 0x0042,
        PLAYER_QUEST_LOG_15_2 = UnitField.UNIT_END + 0x0043,
        PLAYER_QUEST_LOG_15_3 = UnitField.UNIT_END + 0x0044,
        PLAYER_QUEST_LOG_15_4 = UnitField.UNIT_END + 0x0045,
        PLAYER_QUEST_LOG_16_1 = UnitField.UNIT_END + 0x0046,
        PLAYER_QUEST_LOG_16_2 = UnitField.UNIT_END + 0x0047,
        PLAYER_QUEST_LOG_16_3 = UnitField.UNIT_END + 0x0048,
        PLAYER_QUEST_LOG_16_4 = UnitField.UNIT_END + 0x0049,
        PLAYER_QUEST_LOG_17_1 = UnitField.UNIT_END + 0x004A,
        PLAYER_QUEST_LOG_17_2 = UnitField.UNIT_END + 0x004B,
        PLAYER_QUEST_LOG_17_3 = UnitField.UNIT_END + 0x004C,
        PLAYER_QUEST_LOG_17_4 = UnitField.UNIT_END + 0x004D,
        PLAYER_QUEST_LOG_18_1 = UnitField.UNIT_END + 0x004E,
        PLAYER_QUEST_LOG_18_2 = UnitField.UNIT_END + 0x004F,
        PLAYER_QUEST_LOG_18_3 = UnitField.UNIT_END + 0x0050,
        PLAYER_QUEST_LOG_18_4 = UnitField.UNIT_END + 0x0051,
        PLAYER_QUEST_LOG_19_1 = UnitField.UNIT_END + 0x0052,
        PLAYER_QUEST_LOG_19_2 = UnitField.UNIT_END + 0x0053,
        PLAYER_QUEST_LOG_19_3 = UnitField.UNIT_END + 0x0054,
        PLAYER_QUEST_LOG_19_4 = UnitField.UNIT_END + 0x0055,
        PLAYER_QUEST_LOG_20_1 = UnitField.UNIT_END + 0x0056,
        PLAYER_QUEST_LOG_20_2 = UnitField.UNIT_END + 0x0057,
        PLAYER_QUEST_LOG_20_3 = UnitField.UNIT_END + 0x0058,
        PLAYER_QUEST_LOG_20_4 = UnitField.UNIT_END + 0x0059,
        PLAYER_QUEST_LOG_21_1 = UnitField.UNIT_END + 0x005A,
        PLAYER_QUEST_LOG_21_2 = UnitField.UNIT_END + 0x005B,
        PLAYER_QUEST_LOG_21_3 = UnitField.UNIT_END + 0x005C,
        PLAYER_QUEST_LOG_21_4 = UnitField.UNIT_END + 0x005D,
        PLAYER_QUEST_LOG_22_1 = UnitField.UNIT_END + 0x005E,
        PLAYER_QUEST_LOG_22_2 = UnitField.UNIT_END + 0x005F,
        PLAYER_QUEST_LOG_22_3 = UnitField.UNIT_END + 0x0060,
        PLAYER_QUEST_LOG_22_4 = UnitField.UNIT_END + 0x0061,
        PLAYER_QUEST_LOG_23_1 = UnitField.UNIT_END + 0x0062,
        PLAYER_QUEST_LOG_23_2 = UnitField.UNIT_END + 0x0063,
        PLAYER_QUEST_LOG_23_3 = UnitField.UNIT_END + 0x0064,
        PLAYER_QUEST_LOG_23_4 = UnitField.UNIT_END + 0x0065,
        PLAYER_QUEST_LOG_24_1 = UnitField.UNIT_END + 0x0066,
        PLAYER_QUEST_LOG_24_2 = UnitField.UNIT_END + 0x0067,
        PLAYER_QUEST_LOG_24_3 = UnitField.UNIT_END + 0x0068,
        PLAYER_QUEST_LOG_24_4 = UnitField.UNIT_END + 0x0069,
        PLAYER_QUEST_LOG_25_1 = UnitField.UNIT_END + 0x006A,
        PLAYER_QUEST_LOG_25_2 = UnitField.UNIT_END + 0x006B,
        PLAYER_QUEST_LOG_25_3 = UnitField.UNIT_END + 0x006C,
        PLAYER_QUEST_LOG_25_4 = UnitField.UNIT_END + 0x006D,
        PLAYER_VISIBLE_ITEM_1_CREATOR = UnitField.UNIT_END+ 0x006E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_1_0 = UnitField.UNIT_END+ 0x0070, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_1_PROPERTIES = UnitField.UNIT_END+ 0x007C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_1_PAD = UnitField.UNIT_END+ 0x007D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_2_CREATOR = UnitField.UNIT_END+ 0x007E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_2_0 = UnitField.UNIT_END+ 0x0080, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_2_PROPERTIES = UnitField.UNIT_END+ 0x008C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_2_PAD = UnitField.UNIT_END+ 0x008D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_3_CREATOR = UnitField.UNIT_END+ 0x008E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_3_0 = UnitField.UNIT_END+ 0x0090, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_3_PROPERTIES = UnitField.UNIT_END+ 0x009C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_3_PAD = UnitField.UNIT_END+ 0x009D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_4_CREATOR = UnitField.UNIT_END+ 0x009E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_4_0 = UnitField.UNIT_END+ 0x00A0, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_4_PROPERTIES = UnitField.UNIT_END+ 0x00AC, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_4_PAD = UnitField.UNIT_END + 0x00AD, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_5_CREATOR = UnitField.UNIT_END + 0x00AE, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_5_0 = UnitField.UNIT_END + 0x00B0, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_5_PROPERTIES = UnitField.UNIT_END + 0x00BC, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_5_PAD = UnitField.UNIT_END + 0x00BD, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_6_CREATOR = UnitField.UNIT_END + 0x00BE, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_6_0 = UnitField.UNIT_END + 0x00C0, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_6_PROPERTIES = UnitField.UNIT_END + 0x00CC, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_6_PAD = UnitField.UNIT_END + 0x00CD, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_7_CREATOR = UnitField.UNIT_END + 0x00CE, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_7_0 = UnitField.UNIT_END + 0x00D0, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_7_PROPERTIES = UnitField.UNIT_END + 0x00DC, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_7_PAD = UnitField.UNIT_END + 0x00DD, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_8_CREATOR = UnitField.UNIT_END + 0x00DE, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_8_0 = UnitField.UNIT_END + 0x00E0, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_8_PROPERTIES = UnitField.UNIT_END + 0x00EC, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_8_PAD = UnitField.UNIT_END + 0x00ED, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_9_CREATOR = UnitField.UNIT_END + 0x00EE, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_9_0 = UnitField.UNIT_END + 0x00F0, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_9_PROPERTIES = UnitField.UNIT_END + 0x00FC, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_9_PAD = UnitField.UNIT_END + 0x00FD, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_10_CREATOR = UnitField.UNIT_END + 0x00FE, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_10_0 = UnitField.UNIT_END + 0x0100, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_10_PROPERTIES = UnitField.UNIT_END + 0x010C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_10_PAD = UnitField.UNIT_END + 0x010D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_11_CREATOR = UnitField.UNIT_END + 0x010E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_11_0 = UnitField.UNIT_END + 0x0110, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_11_PROPERTIES = UnitField.UNIT_END + 0x011C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_11_PAD = UnitField.UNIT_END + 0x011D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_12_CREATOR = UnitField.UNIT_END + 0x011E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_12_0 = UnitField.UNIT_END + 0x0120, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_12_PROPERTIES = UnitField.UNIT_END + 0x012C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_12_PAD = UnitField.UNIT_END + 0x012D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_13_CREATOR = UnitField.UNIT_END + 0x012E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_13_0 = UnitField.UNIT_END + 0x0130, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_13_PROPERTIES = UnitField.UNIT_END + 0x013C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_13_PAD = UnitField.UNIT_END + 0x013D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_14_CREATOR = UnitField.UNIT_END + 0x013E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_14_0 = UnitField.UNIT_END + 0x0140, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_14_PROPERTIES = UnitField.UNIT_END + 0x014C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_14_PAD = UnitField.UNIT_END + 0x014D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_15_CREATOR = UnitField.UNIT_END + 0x014E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_15_0 = UnitField.UNIT_END + 0x0150, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_15_PROPERTIES = UnitField.UNIT_END + 0x015C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_15_PAD = UnitField.UNIT_END + 0x015D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_16_CREATOR = UnitField.UNIT_END + 0x015E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_16_0 = UnitField.UNIT_END + 0x0160, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_16_PROPERTIES = UnitField.UNIT_END + 0x016C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_16_PAD = UnitField.UNIT_END + 0x016D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_17_CREATOR = UnitField.UNIT_END + 0x016E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_17_0 = UnitField.UNIT_END + 0x0170, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_17_PROPERTIES = UnitField.UNIT_END + 0x017C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_17_PAD = UnitField.UNIT_END + 0x017D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_18_CREATOR = UnitField.UNIT_END + 0x017E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_18_0 = UnitField.UNIT_END + 0x0180, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_18_PROPERTIES = UnitField.UNIT_END + 0x018C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_18_PAD = UnitField.UNIT_END + 0x018D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_19_CREATOR = UnitField.UNIT_END + 0x018E, // Size: 2, Type: LONG, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_19_0 = UnitField.UNIT_END + 0x0190, // Size: 12, Type: INT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_19_PROPERTIES = UnitField.UNIT_END + 0x019C, // Size: 1, Type: TWO_SHORT, Flags: PUBLIC
        PLAYER_VISIBLE_ITEM_19_PAD = UnitField.UNIT_END + 0x019D, // Size: 1, Type: INT, Flags: PUBLIC
        PLAYER_CHOSEN_TITLE = UnitField.UNIT_END + 0x019E,
        PLAYER_FIELD_PAD_0 = UnitField.UNIT_END + 0x019F,
        PLAYER_FIELD_INV_SLOT_HEAD = UnitField.UNIT_END + 0x01A0,
        PLAYER_FIELD_PACK_SLOT_1 = UnitField.UNIT_END + 0x01CE, // Size: 32, Type: LONG, Flags: PRIVATE
        PLAYER_FIELD_BANK_SLOT_1 = UnitField.UNIT_END + 0x01EE, // Size: 56, Type: LONG, Flags: PRIVATE
        PLAYER_FIELD_BANKBAG_SLOT_1 = UnitField.UNIT_END + 0x0226,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_1 = UnitField.UNIT_END + 0x0234,
        PLAYER_FIELD_KEYRING_SLOT_1 = UnitField.UNIT_END + 0x024C,
        PLAYER_FIELD_VANITYPET_SLOT_1 = UnitField.UNIT_END + 0x028C, // Size: 36, Type: LONG, Flags: PRIVATE
        PLAYER_FARSIGHT = UnitField.UNIT_END + 0x02B0,
        PLAYER_FIELD_KNOWN_TITLES = UnitField.UNIT_END + 0x02B2,
        PLAYER_FIELD_KNOWN_TITLES1 = UnitField.UNIT_END + 0x02B3,
        PLAYER_XP = UnitField.UNIT_END + 0x02B4,
        PLAYER_NEXT_LEVEL_XP = UnitField.UNIT_END + 0x02B5,
        PLAYER_SKILL_INFO_1_1 = UnitField.UNIT_END + 0x02B6,
        PLAYER_CHARACTER_POINTS1 = UnitField.UNIT_END + 0x0436,
        PLAYER_CHARACTER_POINTS2 = UnitField.UNIT_END + 0x0437,
        PLAYER_TRACK_CREATURES = UnitField.UNIT_END + 0x0438,
        PLAYER_TRACK_RESOURCES = UnitField.UNIT_END + 0x0439,
        PLAYER_BLOCK_PERCENTAGE = UnitField.UNIT_END + 0x043A,
        PLAYER_DODGE_PERCENTAGE = UnitField.UNIT_END + 0x043B,
        PLAYER_PARRY_PERCENTAGE = UnitField.UNIT_END + 0x043C,
        PLAYER_EXPERTISE = UnitField.UNIT_END + 0x043D,
        PLAYER_OFFHAND_EXPERTISE = UnitField.UNIT_END + 0x043E,
        PLAYER_CRIT_PERCENTAGE = UnitField.UNIT_END + 0x043F,
        PLAYER_RANGED_CRIT_PERCENTAGE = UnitField.UNIT_END + 0x0440,
        PLAYER_OFFHAND_CRIT_PERCENTAGE = UnitField.UNIT_END + 0x0441,
        PLAYER_SPELL_CRIT_PERCENTAGE1 = UnitField.UNIT_END + 0x0442,
        PLAYER_SPELL_CRIT_PERCENTAGE2 = UnitField.UNIT_END + 0x0443,
        PLAYER_SPELL_CRIT_PERCENTAGE3 = UnitField.UNIT_END + 0x0444,
        PLAYER_SPELL_CRIT_PERCENTAGE4 = UnitField.UNIT_END + 0x0445,
        PLAYER_SPELL_CRIT_PERCENTAGE5 = UnitField.UNIT_END + 0x0446,
        PLAYER_SPELL_CRIT_PERCENTAGE6 = UnitField.UNIT_END + 0x0447,
        PLAYER_SPELL_CRIT_PERCENTAGE7 = UnitField.UNIT_END + 0x0448,
        PLAYER_SHIELD_BLOCK = UnitField.UNIT_END + 0x0449,
        PLAYER_EXPLORED_ZONES_1 = UnitField.UNIT_END + 0x044A,
        PLAYER_REST_STATE_EXPERIENCE = UnitField.UNIT_END + 0x04CA,
        PLAYER_FIELD_COINAGE = UnitField.UNIT_END + 0x04CB,
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS = UnitField.UNIT_END + 0x04CC,
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG = UnitField.UNIT_END + 0x04D3,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT1 = UnitField.UNIT_END + 0x04DA,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT2 = UnitField.UNIT_END + 0x04DB,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT3 = UnitField.UNIT_END + 0x04DC,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT4 = UnitField.UNIT_END + 0x04DD,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT5 = UnitField.UNIT_END + 0x04DE,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT6 = UnitField.UNIT_END + 0x04DF,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT7 = UnitField.UNIT_END + 0x04E0,
        PLAYER_FIELD_MOD_HEALING_DONE_POS = UnitField.UNIT_END + 0x04E1,
        PLAYER_FIELD_MOD_TARGET_RESISTANCE = UnitField.UNIT_END + 0x04E2,
        PLAYER_FIELD_MOD_TARGET_PHYSICAL_RESISTANCE = UnitField.UNIT_END + 0x04E3,
        PLAYER_FIELD_BYTES = UnitField.UNIT_END + 0x04E4,
        PLAYER_AMMO_ID = UnitField.UNIT_END + 0x04E5,
        PLAYER_SELF_RES_SPELL = UnitField.UNIT_END + 0x04E6,
        PLAYER_FIELD_PVP_MEDALS = UnitField.UNIT_END + 0x04E7,
        PLAYER_FIELD_BUYBACK_PRICE_1 = UnitField.UNIT_END + 0x04E8,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_1 = UnitField.UNIT_END + 0x04F4,
        PLAYER_FIELD_KILLS = UnitField.UNIT_END + 0x0500,
        PLAYER_FIELD_TODAY_CONTRIBUTION = UnitField.UNIT_END + 0x0501,
        PLAYER_FIELD_YESTERDAY_CONTRIBUTION = UnitField.UNIT_END + 0x0502,
        PLAYER_FIELD_LIFETIME_HONORABLE_KILLS = UnitField.UNIT_END + 0x0503,
        PLAYER_FIELD_BYTES2 = UnitField.UNIT_END + 0x0504,
        PLAYER_FIELD_WATCHED_FACTION_INDEX = UnitField.UNIT_END + 0x0505,
        PLAYER_FIELD_COMBAT_RATING_1 = UnitField.UNIT_END + 0x0506,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_1 = UnitField.UNIT_END + 0x051E,
        PLAYER_FIELD_HONOR_CURRENCY = UnitField.UNIT_END + 0x0530,
        PLAYER_FIELD_ARENA_CURRENCY = UnitField.UNIT_END + 0x0531,
        PLAYER_FIELD_MOD_MANA_REGEN = UnitField.UNIT_END + 0x0532, // Size: 1, Type: FLOAT, Flags: PRIVATE
        PLAYER_FIELD_MOD_MANA_REGEN_INTERRUPT = UnitField.UNIT_END + 0x0533, // Size: 1, Type: FLOAT, Flags: PRIVATE
        PLAYER_FIELD_MAX_LEVEL = UnitField.UNIT_END + 0x0534,
        PLAYER_FIELD_DAILY_QUESTS_1 = UnitField.UNIT_END + 0x0535,
        PLAYER_END = UnitField.UNIT_END + 0x054E
    }

    public enum GameObjectField
    {
        GAMEOBJECT_FIELD_CREATED_BY = ObjectField.OBJECT_END + 0x0000, // Size: 2, Type: LONG, Flags: PUBLIC
        GAMEOBJECT_DISPLAYID = ObjectField.OBJECT_END + 0x0002, // Size: 1, Type: INT, Flags: PUBLIC
        GAMEOBJECT_FLAGS = ObjectField.OBJECT_END + 0x0003, // Size: 1, Type: INT, Flags: PUBLIC
        GAMEOBJECT_ROTATION = ObjectField.OBJECT_END + 0x0004, // Size: 4, Type: FLOAT, Flags: PUBLIC
        GAMEOBJECT_STATE = ObjectField.OBJECT_END + 0x0008, // Size: 1, Type: INT, Flags: PUBLIC
        GAMEOBJECT_POS_X = ObjectField.OBJECT_END + 0x0009, // Size: 1, Type: FLOAT, Flags: PUBLIC
        GAMEOBJECT_POS_Y = ObjectField.OBJECT_END + 0x000A, // Size: 1, Type: FLOAT, Flags: PUBLIC
        GAMEOBJECT_POS_Z = ObjectField.OBJECT_END + 0x000B, // Size: 1, Type: FLOAT, Flags: PUBLIC
        GAMEOBJECT_FACING = ObjectField.OBJECT_END + 0x000C, // Size: 1, Type: FLOAT, Flags: PUBLIC
        GAMEOBJECT_DYNAMIC = ObjectField.OBJECT_END + 0x000D, // Size: 1, Type: INT, Flags: DYNAMIC
        GAMEOBJECT_FACTION = ObjectField.OBJECT_END + 0x000E, // Size: 1, Type: INT, Flags: PUBLIC
        GAMEOBJECT_TYPE_ID = ObjectField.OBJECT_END + 0x000F, // Size: 1, Type: INT, Flags: PUBLIC
        GAMEOBJECT_LEVEL = ObjectField.OBJECT_END + 0x0010, // Size: 1, Type: INT, Flags: PUBLIC
        GAMEOBJECT_ARTKIT = ObjectField.OBJECT_END + 0x0011, // Size: 1, Type: INT, Flags: PUBLIC
        GAMEOBJECT_ANIMPROGRESS = ObjectField.OBJECT_END + 0x0012, // Size: 1, Type: INT, Flags: PUBLIC
        GAMEOBJECT_PADDING = ObjectField.OBJECT_END + 0x0013, // Size: 1, Type: INT, Flags: PUBLIC
        GAMEOBJECT_END = ObjectField.OBJECT_END + 0x0014
    }

    public enum DynamicObjectField
    {
        DYNAMICOBJECT_CASTER = ObjectField.OBJECT_END + 0x0000, // Size: 2, Type: LONG, Flags: PUBLIC
        DYNAMICOBJECT_BYTES = ObjectField.OBJECT_END + 0x0002, // Size: 1, Type: BYTES, Flags: PUBLIC
        DYNAMICOBJECT_SPELLID = ObjectField.OBJECT_END + 0x0003, // Size: 1, Type: INT, Flags: PUBLIC
        DYNAMICOBJECT_RADIUS = ObjectField.OBJECT_END + 0x0004, // Size: 1, Type: FLOAT, Flags: PUBLIC
        DYNAMICOBJECT_POS_X = ObjectField.OBJECT_END + 0x0005, // Size: 1, Type: FLOAT, Flags: PUBLIC
        DYNAMICOBJECT_POS_Y = ObjectField.OBJECT_END + 0x0006, // Size: 1, Type: FLOAT, Flags: PUBLIC
        DYNAMICOBJECT_POS_Z = ObjectField.OBJECT_END + 0x0007, // Size: 1, Type: FLOAT, Flags: PUBLIC
        DYNAMICOBJECT_FACING = ObjectField.OBJECT_END + 0x0008, // Size: 1, Type: FLOAT, Flags: PUBLIC
        DYNAMICOBJECT_CASTTIME = ObjectField.OBJECT_END + 0x0009, // Size: 1, Type: INT, Flags: PUBLIC
        DYNAMICOBJECT_END = ObjectField.OBJECT_END + 0x000A
    }

    public enum CorpseField
    {
        CORPSE_FIELD_OWNER = ObjectField.OBJECT_END + 0x0000, // Size: 2, Type: LONG, Flags: PUBLIC
        CORPSE_FIELD_PARTY = ObjectField.OBJECT_END + 0x0002, // Size: 2, Type: LONG, Flags: PUBLIC
        CORPSE_FIELD_FACING = ObjectField.OBJECT_END + 0x0004, // Size: 1, Type: FLOAT, Flags: PUBLIC
        CORPSE_FIELD_POS_X = ObjectField.OBJECT_END + 0x0005, // Size: 1, Type: FLOAT, Flags: PUBLIC
        CORPSE_FIELD_POS_Y = ObjectField.OBJECT_END + 0x0006, // Size: 1, Type: FLOAT, Flags: PUBLIC
        CORPSE_FIELD_POS_Z = ObjectField.OBJECT_END + 0x0007, // Size: 1, Type: FLOAT, Flags: PUBLIC
        CORPSE_FIELD_DISPLAY_ID = ObjectField.OBJECT_END + 0x0008, // Size: 1, Type: INT, Flags: PUBLIC
        CORPSE_FIELD_ITEM = ObjectField.OBJECT_END + 0x0009, // Size: 19, Type: INT, Flags: PUBLIC
        CORPSE_FIELD_BYTES_1 = ObjectField.OBJECT_END + 0x001C, // Size: 1, Type: BYTES, Flags: PUBLIC
        CORPSE_FIELD_BYTES_2 = ObjectField.OBJECT_END + 0x001D, // Size: 1, Type: BYTES, Flags: PUBLIC
        CORPSE_FIELD_GUILD = ObjectField.OBJECT_END + 0x001E, // Size: 1, Type: INT, Flags: PUBLIC
        CORPSE_FIELD_FLAGS = ObjectField.OBJECT_END + 0x001F, // Size: 1, Type: INT, Flags: PUBLIC
        CORPSE_FIELD_DYNAMIC_FLAGS = ObjectField.OBJECT_END + 0x0020, // Size: 1, Type: INT, Flags: DYNAMIC
        CORPSE_FIELD_PAD = ObjectField.OBJECT_END + 0x0021, // Size: 1, Type: INT, Flags: NONE
        CORPSE_END = ObjectField.OBJECT_END + 0x0022
    }
}
