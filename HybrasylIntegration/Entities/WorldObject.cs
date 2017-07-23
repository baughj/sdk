using System;
using System.Collections.Generic;
using System.Linq;
using C3;
using Hybrasyl.Castables;
using Hybrasyl.Items;
using Hybrasyl.Nations;

namespace Hybrasyl.Entities
{
    public class WorldObject : IQuadStorable
    {
        public Rectangle Rect => new Rectangle(X, Y, 1, 1);
        public bool HasMoved { get; set; }
        public byte X { get; set; }
        public byte Y { get; set; }
        public uint Id { get; set; }
        public string Name { get; set; }

        public WorldObject()
        {
            Name = string.Empty;
        }
    }

    public class VisibleObject : WorldObject
    {
        public Map Map { get; set; }
        public Direction Direction { get; set; }
        public ushort Sprite { get; set; }
        public string Portrait { get; set; }
        public string DisplayText { get; set; }

        public string DeathPileOwner { get; set; }
        public List<string> DeathPileAllowedLooters { get; set; }
        public DateTime? DeathPileTime { get; set; }

        public VisibleObject()
        {
            DisplayText = string.Empty;
            DeathPileAllowedLooters = new List<string>();
            DeathPileOwner = string.Empty;
            DeathPileTime = null;
        }
    }

    public class Door : VisibleObject
    {
        public bool Closed { get; set; }
        public bool IsLeftRight { get; set; }
        public bool UpdateCollision { get; set; }

        public Door(byte x, byte y, bool closed = false, bool isLeftRight = false, bool updateCollision = true)
        {
            X = x;
            Y = y;
            Closed = closed;
            IsLeftRight = isLeftRight;
            UpdateCollision = updateCollision;
        }
    }

    public class Creature : VisibleObject
    {
        public byte Level { get; set; }
        public uint Experience { get; set; }
        public byte Ability { get; set; }
        public uint AbilityExp { get; set; }
        public uint Hp { get; set; }
        public uint Mp { get; set; }
        public long BaseHp { get; set; }
        public long BaseMp { get; set; }
        public long BaseStr { get; set; }
        public long BaseInt { get; set; }
        public long BaseWis { get; set; }
        public long BaseCon { get; set; }
        public long BaseDex { get; set; }
        public long BonusHp { get; set; }
        public long BonusMp { get; set; }
        public long BonusStr { get; set; }
        public long BonusInt { get; set; }
        public long BonusWis { get; set; }
        public long BonusCon { get; set; }
        public long BonusDex { get; set; }
        public long BonusDmg { get; set; }
        public long BonusHit { get; set; }
        public long BonusAc { get; set; }
        public long BonusMr { get; set; }
        public long BonusRegen { get; set; }
        public Element OffensiveElement { get; set; }
        public Element DefensiveElement { get; set; }
        public ushort MapId { get; protected set; }
        public byte MapX { get; protected set; }
        public byte MapY { get; protected set; }
        public uint Gold { get; set; }
        public Inventory Inventory { get; protected set; }
        public Inventory Equipment { get; protected set; }

        public Creature()
        {
            Gold = 0;
            Inventory = new Inventory(59);
            Equipment = new Inventory(18);
        }
    }

    public class User : Creature
    {
        public bool IsSaving { get; set; }
        public string StorageKey => string.Concat(GetType().Name, ':', Name.ToLower());
        public Class Class { get; set; }
        public bool IsMaster { get; set; }
        public UserGroup Group { get; set; }
        public Sex Sex { get; set; }
        public bool Dead => !Status.HasFlag(PlayerCondition.Alive);
        public bool IsCasting => Status.HasFlag(PlayerCondition.Casting);
        public bool CanCast => !(Status.HasFlag(PlayerCondition.Asleep) || Status.HasFlag(PlayerCondition.Frozen) || Status.HasFlag(PlayerCondition.Paralyzed));
        public Mailbox Mailbox { get; set; }
        public bool UnreadMail => Mailbox?.HasUnreadMessages ?? false;
        public RestPosition RestPosition { get; set; }
        public SkinColor SkinColor { get; set; }
        internal bool Transparent { get; set; }
        public byte FaceShape { get; set; }
        public LanternSize LanternSize { get; set; }
        public NameDisplayStyle NameStyle { get; set; }
        public bool DisplayAsMonster { get; set; }
        public ushort MonsterSprite { get; set; }
        public byte HairStyle { get; set; }
        public byte HairColor { get; set; }
        public Location Location { get; set; }
        public LoginInfo Login { get; set; }
        public PasswordInfo Password { get; set; }
        public SkillBook SkillBook { get; private set; }
        public SpellBook SpellBook { get; private set; }
        public bool Grouping { get; set; }
        public UserStatus GroupStatus { get; set; }
        public byte[] PortraitData { get; set; }
        public string ProfileText { get; set; }
        public Castable PendingLearnableCastable { get; private set; }
        public Item PendingSendableParcel { get; private set; }
        public string PendingParcelRecipient { get; private set; }
        public string PendingBuyableItem { get; private set; }
        public int PendingBuyableQuantity { get; private set; }
        public byte PendingSellableSlot { get; private set; }
        public int PendingSellableQuantity { get; private set; }
        public uint PendingMerchantOffer { get; private set; }
        public GuildMembership Guild { get; set; }
        //private ConcurrentDictionary<ushort, IPlayerStatus> _currentStatuses;
        private Nation _nation;

        public Nation Nation
        {
            get { return _nation; }
            set
            {
                _nation = value;
                Citizenship = value.Name;
            }
        }

        private string Citizenship { get; set; }
        public string NationName => Nation != null ? Nation.Name : string.Empty;
        public Legend Legend;
        public DialogState DialogState { get; set; }
        private Dictionary<string, string> UserFlags { get; set; }
        private Dictionary<string, string> UserSessionFlags { get; set; }
        public Exchange ActiveExchange { get; set; }
        public PlayerCondition Status { get; set; }
        public bool IsAvailableForExchange => Status == PlayerCondition.Alive;
        public uint ExpToLevel { get; set; }
        public uint LevelPoints { get; set; }
        public byte CurrentMusicTrack { get; set; }
    }

    public class LoginInfo
    {
        public DateTime LastLogin { get; set; }
        public DateTime LastLogoff { get; set; }
        public DateTime LastLoginFailure { get; set; }
        public string LastLoginFrom { get; set; }
        public Int64 LoginFailureCount { get; set; }
        public DateTime CreatedTime { get; set; }
    }

    public class PasswordInfo
    {
        public string Hash { get; set; }
        public DateTime LastChanged { get; set; }
        public string LastChangedFrom { get; set; }
    }

    public class UserGroup
    {
        private delegate Dictionary<uint, uint> DistributionFunc(User source, uint full);
        private DistributionFunc ExperienceDistributionFunc { get; set; }
        // Group-related info
        public List<User> Members { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public Dictionary<Class, uint> ClassCount { get; set; }
        public User Founder { get; private set; }
        public uint MaxMembers = 0;

        
        public UserGroup(User founder)
        {
            Founder = founder;
            Members = new List<User>();
            ClassCount = new Dictionary<Class, uint>();
            foreach (var cl in Enum.GetValues(typeof(Class)).Cast<Class>())
            {
                ClassCount[cl] = 0;
            }

            CreatedOn = DateTime.Now;
        }
    }

    public class GuildMembership
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
    }
}
