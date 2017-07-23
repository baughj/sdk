﻿using System;

namespace Hybrasyl.Entities
{
    #region Colors and display enumerations
    public enum LanternSize : byte
    {
        None = 0x00,
        Small = 0x01,
        Large = 0x02
    }

    public enum RestPosition : byte
    {
        // Seriously, you try naming these
        Standing = 0x00,
        RestPosition1 = 0x01,
        RestPosition2 = 0x02,
        MaximumChill = 0x03
    }

    public enum NameDisplayStyle : byte
    {
        GreyHover = 0x00,
        RedAlwaysOn = 0x01,
        GreenHover = 0x02,
        GreyAlwaysOn = 0x03
    }

    public enum LegendIcon
    {
        Community = 0,
        Warrior = 1,
        Rogue = 2,
        Wizard = 3,
        Priest = 4,
        Monk = 5,
        Heart = 6,
        Victory = 7
    }

    public enum LegendColor
    {
        White = 32,
        LightOrange = 50,
        LightYellow = 64,
        Yellow = 68,
        LightGreen = 75,
        Blue = 88,
        LightPink = 96,
        DarkPurple = 100,
        Pink = 105,
        Darkgreen = 125,
        Green = 128,
        Orange = 152,
        Brown = 160,
        Red = 248
    }

    public enum TextColor : int
    {
        Red = 62,
        Yellow = 63,
        DarkBlue = 66,
        DarkGrey = 67,
        MediumGrey = 68,
        LightGrey = 69,
        DarkPurple = 70,
        BrightGreen = 71,
        DarkGreen = 72,
        Orange = 73,
        DarkOrange = 74,
        White = 75,
        Blue = 76,
        WhisperBlue = 76,
        Pink = 77
    }

    public enum SkinColor : int
    {
        Flesh = 0,
        White = 1,
        Cocoa = 2,
        Green = 3,
        Yellow = 4,
        Tan = 5,
        Grey = 6,
        LightBlue = 7,
        Orange = 8,
        Purple = 9
    }
    public enum StatusBarColor : byte
    {
        Off = 0,
        Blue = 1,
        Green = 2,
        Orange = 3,
        Red = 4,
        White = 5
    }

    #endregion

    #region Opcode enumerations
    public static class ExchangeActions
    {
        public const byte Initiate = 0x00;
        public const byte QuantityPrompt = 0x01;
        public const byte ItemUpdate = 0x02;
        public const byte GoldUpdate = 0x03;
        public const byte Cancel = 0x04;
        public const byte Confirm = 0x05;
    }

    //this is a wip
    public static class OpCodes
    {
        public const byte CryptoKey = 0x00;
        public const byte LoginMessage = 0x02;
        public const byte Redirect = 0x03;
        public const byte Location = 0x04;
        public const byte UserId = 0x05;
        public const byte AddWorldObject = 0x07;
        public const byte Attributes = 0x08;
        public const byte SystemMessage = 0x0A;
        public const byte UserMove = 0x0B;
        public const byte CreatureMove = 0x0C;
        public const byte CastLine = 0x0D;
        public const byte RemoveWorldObject = 0x0E;
        public const byte AddItem = 0x0F;
        public const byte RemoveItem = 0x10;
        public const byte CreatureDirection = 0x11;
        public const byte HealthBar = 0x13;
        public const byte MapInfo = 0x15;
        public const byte AddSpell = 0x17;
        public const byte RemoveSpell = 0x18;
        public const byte PlaySound = 0x19;
        public const byte PlayerAnimation = 0x1A;
        public const byte MapChangeCompled = 0x1F;
        public const byte Refresh = 0x22;
        public const byte SpellAnimation = 0x29;
        public const byte NpcReply = 0x2F;
        public const byte Pursuit = 0x30;
        public const byte Board = 0x31;
        public const byte UserMoveResponse = 0x32;
        public const byte DisplayUser = 0x33;
        public const byte Profile = 0x34;
        public const byte UserList = 0x36;
        public const byte AddEquipment = 0x37;
        public const byte RemoveEquipment = 0x38;
        public const byte SelfProfile = 0x39;
        public const byte StatusBar = 0x3A;
        public const byte PingA = 0x3B;
        public const byte MapData = 0x3C;
        public const byte UseSkill = 0x3E;
        public const byte Cooldown = 0x3F;
        public const byte Exchange = 0x42;
        public const byte ClickObject = 0x43;
        public const byte CancelCast = 0x48;
        public const byte ServerSelect = 0x57;
        public const byte MapLoadComplete = 0x58;
        public const byte Notification = 0x60;
        public const byte Website = 0x66;
        public const byte MapChangePending = 0x67;
        public const byte PingB = 0x68;
        public const byte MetaData = 0x6F;

    }
    #endregion

    #region Messaging types
    public enum PrivateMessageType : int
    {
        Whisper = 0,
        ServerMessage = 1,
        GlobalMessage = 3,
        ClearMessage = 5,
        PopupWithScroll = 8,
        PopupOkCancel = 11,
        UpperRight = 12
    }

    public enum PublicMessageType : int
    {
        Say = 0,
        Shout = 1,
        Spell = 2
    }

    #endregion

    public enum UserStatus : byte
    {
        Awake = 0,
        DoNotDisturb = 1,
        DayDreaming = 2,
        NeedGroup = 3,
        Grouped = 4,
        LoneHunter = 5,
        GroupHunter = 6,
        NeedHelp = 7
    }

    #region Slots, element types, item types

    public enum Element : int
    {
        None = 0x00,
        Fire = 0x01,
        Water = 0x02,
        Wind = 0x03,
        Earth = 0x04,
        Light = 0x05,
        Dark = 0x06,
        Wood = 0x07,
        Metal = 0x08,
        Undead = 0x09,
        Random = 0x10
    }

    public enum ItemSlots : int
    {
        None = 0,
        Weapon = 1,
        Armor = 2,
        Shield = 3,
        Helmet = 4,
        Earring = 5,
        Necklace = 6,
        LHand = 7,
        RHand = 8,
        LArm = 9,
        RArm = 10,
        Waist = 11,
        Leg = 12,
        Foot = 13,
        // The rest are all "vanity" slots
        FirstAcc = 14,
        Trousers = 15,
        Coat = 16,
        SecondAcc = 17,
        ThirdAcc = 18
    }

    public enum ServerItemSlots
    {
         Weapon = 0,
         Armor = 1,
         Shield = 2,
         Helmet = 3,
         Earring = 4,
         Necklace = 5,
         LHand = 6,
         RHand = 7,
         LArm = 8,
         RArm = 9,
         Waist = 10,
         Leg = 11,
         Foot = 12,
         FirstAcc = 13,
         Trousers = 14,
         Coat = 15,
         SecondAcc = 16,
         ThirdAcc = 17,
        // These are special edge cases; the slots don't actually exist
         Gauntlet = 19,
         Ring = 20,
    }

    public enum ClientItemSlots : byte
    {
         None = 0,
         Weapon = 1,
         Armor = 2,
         Shield = 3,
         Helmet = 4,
         Earring = 5,
         Necklace = 6,
         LHand = 7,
         RHand = 8,
         LArm = 9,
         RArm = 10,
         Waist = 11,
         Leg = 12,
         Foot = 13,
         FirstAcc = 14,
         Trousers = 15,
         Coat = 16,
         SecondAcc = 17,
         ThirdAcc = 18,
        // These are special edge cases; the slots don't actually exist
         Gauntlet = 19,
         Ring = 20,

    }

    public enum ItemObjectType
    {
        CanUse,
        CannotUse,
        Equipment
    }

    public enum WeaponObjectType
    {
        None,
        Basic,
        TwoHanded,
        Dagger,
        Staff,
        Claw
    }

    #endregion

    [Flags]
    public enum PlayerCondition : int
    {
        Alive = 0x01,
        Frozen = 0x02,
        Asleep = 0x04,
        Paralyzed = 0x08,
        Blinded = 0x10,
        InExchange = 0x20,
        InDialog = 0x40,
        InComa = 0x80,
        Casting = 0x100,
        Pvp = 0x200,
        AliveExchange = (Alive | InExchange)
    }

    [Flags]
    public enum StatUpdateFlags : byte
    {
        UnreadMail = 0x01,
        Unknown = 0x02,
        Secondary = 0x04,
        Experience = 0x08,
        Current = 0x10,
        Primary = 0x20,
        GameMasterA = 0x40,
        GameMasterB = 0x80,
        Swimming = (GameMasterA | GameMasterB),
        Stats = (Primary | Current | Secondary),
        Full = (Primary | Current | Experience | Secondary | GameMasterA | GameMasterB)
    }

    public enum Direction : int
    {
        North = 0x00,
        East = 0x01,
        South = 0x02,
        West = 0x03
    }

    public enum Class : int
    {
        Peasant = 0x00,
        Warrior = 0x01,
        Rogue = 0x02,
        Wizard = 0x03,
        Priest = 0x04,
        Monk = 0x05
    }

    public enum Sex : int
    {
        Neutral = 0x00,
        Male = 0x01,
        Female = 0x02
    }


    public enum DamageType
    {
        Direct,
        Physical,
        Magical,
        Elemental
    }

    public enum SpellUseType : byte
    {
        Unusable = 0,
        Prompt = 1,
        ChooseTarget = 2,
        FourDigit = 3,
        ThreeDigit = 4,
        NoTarget = 5,
        TwoDigit = 6,
        OneDigit = 7,
    }

    public enum ControlOpcodes : int
    {
        CleanupUser = 0,
        SaveUser = 1,
        ChaosRising = 2,
        ShutdownServer = 3,
        RegenUser = 4,
        LogoffUser = 5,
        MailNotifyUser = 6,
        StatusTick = 7,
        MonolithSpawn = 8,
    }

    public enum ServerTypes : int
    {
        Lobby = 0,
        Login = 1,
        World = 2,
    }

    public enum EncryptMethod
    {
        None,
        Normal,
        MD5Key
    }

    public enum PacketSeekOrigin
    {
        Begin,
        Current,
        End
    }

    public enum DialogTypes
    {
        FUNCTION_DIALOG = -1,
        SIMPLE_DIALOG = 0,
        OPTIONS_DIALOG = 2,
        INPUT_DIALOG = 4,
    }
}
