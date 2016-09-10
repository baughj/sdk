// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.31
//    <NameSpace>Hybrasyl.Creatures</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><DataMemberNameArg>OnlyIfDifferent</DataMemberNameArg><DataMemberOnXmlIgnore>False</DataMemberOnXmlIgnore><CodeBaseTag>Net20</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>False</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>False</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>None</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><EnableRestriction>False</EnableRestriction><RestrictionMaxLenght>False</RestrictionMaxLenght><RestrictionRegEx>False</RestrictionRegEx><RestrictionRange>False</RestrictionRange><ValidateProperty>False</ValidateProperty><ClassNamePrefix></ClassNamePrefix><ClassLevel>Public</ClassLevel><PartialClass>True</PartialClass><ClassesInSeparateFiles>False</ClassesInSeparateFiles><ClassesInSeparateFilesDir></ClassesInSeparateFilesDir><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableAppInfoSettings>False</EnableAppInfoSettings><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><sspNullable>False</sspNullable><sspString>False</sspString><sspCollection>False</sspCollection><sspComplexType>False</sspComplexType><sspSimpleType>False</sspSimpleType><sspEnumType>False</sspEnumType><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings><AttributesToExlude></AttributesToExlude>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace Hybrasyl.Creatures
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Xml;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature", IsNullable = false)]
    public partial class Spawn
    {

        private CreatureScript _script;

        private IntentList _intents;

        private Respawn _respawn;

        private Damage _damage;

        private Defense _defense;

        private Stats _stats;

        private LootList _loot;

        private List<Castable> _castables;

        private string _base;

        public Spawn()
        {
            this._castables = new List<Castable>();
            this._loot = new LootList();
            this._stats = new Stats();
            this._defense = new Defense();
            this._damage = new Damage();
            this._respawn = new Respawn();
            this._intents = new IntentList();
            this._script = new CreatureScript();
        }

        public CreatureScript Script
        {
            get
            {
                return this._script;
            }
            set
            {
                this._script = value;
            }
        }

        public IntentList Intents
        {
            get
            {
                return this._intents;
            }
            set
            {
                this._intents = value;
            }
        }

        public Respawn Respawn
        {
            get
            {
                return this._respawn;
            }
            set
            {
                this._respawn = value;
            }
        }

        public Damage Damage
        {
            get
            {
                return this._damage;
            }
            set
            {
                this._damage = value;
            }
        }

        public Defense Defense
        {
            get
            {
                return this._defense;
            }
            set
            {
                this._defense = value;
            }
        }

        public Stats Stats
        {
            get
            {
                return this._stats;
            }
            set
            {
                this._stats = value;
            }
        }

        public LootList Loot
        {
            get
            {
                return this._loot;
            }
            set
            {
                this._loot = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<Castable> Castables
        {
            get
            {
                return this._castables;
            }
            set
            {
                this._castables = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Base
        {
            get
            {
                return this._base;
            }
            set
            {
                this._base = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class CreatureScript
    {

        private ScriptType _type;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ScriptType type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public enum ScriptType
    {

        /// <remarks/>
        Override,

        /// <remarks/>
        Supplement,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class Castable
    {

        private int _cooldown;

        private float _chance;

        private bool _always;

        private string _value;

        public Castable()
        {
            this._cooldown = 1;
            this._chance = ((float)(1F));
            this._always = false;
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public int Cooldown
        {
            get
            {
                return this._cooldown;
            }
            set
            {
                this._cooldown = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
        public float Chance
        {
            get
            {
                return this._chance;
            }
            set
            {
                this._chance = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Always
        {
            get
            {
                return this._always;
            }
            set
            {
                this._always = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class LootGold
    {

        private int _min;

        private int _max;

        private bool _unique;

        public LootGold()
        {
            this._min = 1;
            this._max = 1;
            this._unique = false;
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public int Min
        {
            get
            {
                return this._min;
            }
            set
            {
                this._min = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public int Max
        {
            get
            {
                return this._max;
            }
            set
            {
                this._max = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Unique
        {
            get
            {
                return this._unique;
            }
            set
            {
                this._unique = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class LootItem
    {

        private int _min;

        private int _max;

        private bool _unique;

        private bool _always;

        private string _value;

        public LootItem()
        {
            this._min = 1;
            this._max = 1;
            this._unique = false;
            this._always = false;
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public int Min
        {
            get
            {
                return this._min;
            }
            set
            {
                this._min = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public int Max
        {
            get
            {
                return this._max;
            }
            set
            {
                this._max = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Unique
        {
            get
            {
                return this._unique;
            }
            set
            {
                this._unique = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Always
        {
            get
            {
                return this._always;
            }
            set
            {
                this._always = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class LootTable
    {

        private List<LootItem> _item;

        private LootGold _gold;

        private int _rolls;

        private float _chance;

        private string _name;

        private bool _always;

        public LootTable()
        {
            this._gold = new LootGold();
            this._item = new List<LootItem>();
            this._rolls = 1;
            this._chance = ((float)(1F));
            this._name = "false";
            this._always = false;
        }

        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public List<LootItem> Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        public LootGold Gold
        {
            get
            {
                return this._gold;
            }
            set
            {
                this._gold = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public int Rolls
        {
            get
            {
                return this._rolls;
            }
            set
            {
                this._rolls = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
        public float Chance
        {
            get
            {
                return this._chance;
            }
            set
            {
                this._chance = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("false")]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Always
        {
            get
            {
                return this._always;
            }
            set
            {
                this._always = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class LootImport
    {

        private int _rolls;

        private float _chance;

        private bool _override;

        private bool _guaranteed;

        private string _value;

        public LootImport()
        {
            this._rolls = 1;
            this._chance = ((float)(1F));
            this._override = false;
            this._guaranteed = false;
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public int Rolls
        {
            get
            {
                return this._rolls;
            }
            set
            {
                this._rolls = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
        public float Chance
        {
            get
            {
                return this._chance;
            }
            set
            {
                this._chance = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Override
        {
            get
            {
                return this._override;
            }
            set
            {
                this._override = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Guaranteed
        {
            get
            {
                return this._guaranteed;
            }
            set
            {
                this._guaranteed = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class LootList
    {

        private List<LootImport> _import;

        private List<LootTable> _table;

        private uint _xp;

        private uint _gold;

        public LootList()
        {
            this._table = new List<LootTable>();
            this._import = new List<LootImport>();
            this._xp = ((uint)(0));
            this._gold = ((uint)(0));
        }

        [System.Xml.Serialization.XmlElementAttribute("Import")]
        public List<LootImport> Import
        {
            get
            {
                return this._import;
            }
            set
            {
                this._import = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Table")]
        public List<LootTable> Table
        {
            get
            {
                return this._table;
            }
            set
            {
                this._table = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint Xp
        {
            get
            {
                return this._xp;
            }
            set
            {
                this._xp = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint Gold
        {
            get
            {
                return this._gold;
            }
            set
            {
                this._gold = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class Stats
    {

        private uint _hp;

        private uint _mp;

        public Stats()
        {
            this._mp = ((uint)(0));
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Hp
        {
            get
            {
                return this._hp;
            }
            set
            {
                this._hp = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint Mp
        {
            get
            {
                return this._mp;
            }
            set
            {
                this._mp = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class Defense
    {

        private int _mr;

        private int _ac;

        private Element _element;

        private sbyte _regen;

        public Defense()
        {
            this._mr = 0;
            this._element = Element.None;
            this._regen = ((sbyte)(0));
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Mr
        {
            get
            {
                return this._mr;
            }
            set
            {
                this._mr = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Ac
        {
            get
            {
                return this._ac;
            }
            set
            {
                this._ac = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(Element.None)]
        public Element Element
        {
            get
            {
                return this._element;
            }
            set
            {
                this._element = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Regen
        {
            get
            {
                return this._regen;
            }
            set
            {
                this._regen = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    public enum Element
    {

        /// <remarks/>
        None,

        /// <remarks/>
        Fire,

        /// <remarks/>
        Water,

        /// <remarks/>
        Wind,

        /// <remarks/>
        Earth,

        /// <remarks/>
        Light,

        /// <remarks/>
        Dark,

        /// <remarks/>
        Wood,

        /// <remarks/>
        Metal,

        /// <remarks/>
        Undead,

        /// <remarks/>
        Random,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class DamageAmount
    {

        private int _min;

        private int _max;

        public DamageAmount()
        {
            this._min = 0;
            this._max = 1;
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int Min
        {
            get
            {
                return this._min;
            }
            set
            {
                this._min = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public int Max
        {
            get
            {
                return this._max;
            }
            set
            {
                this._max = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class Damage
    {

        private DamageAmount _small;

        private DamageAmount _large;

        private Element _element;

        private DamageType _type;

        private sbyte _dmg;

        private sbyte _hit;

        public Damage()
        {
            this._large = new DamageAmount();
            this._small = new DamageAmount();
            this._element = Element.None;
            this._type = DamageType.Physical;
            this._dmg = ((sbyte)(0));
            this._hit = ((sbyte)(0));
        }

        public DamageAmount Small
        {
            get
            {
                return this._small;
            }
            set
            {
                this._small = value;
            }
        }

        public DamageAmount Large
        {
            get
            {
                return this._large;
            }
            set
            {
                this._large = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(Element.None)]
        public Element Element
        {
            get
            {
                return this._element;
            }
            set
            {
                this._element = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(DamageType.Physical)]
        public DamageType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Dmg
        {
            get
            {
                return this._dmg;
            }
            set
            {
                this._dmg = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Hit
        {
            get
            {
                return this._hit;
            }
            set
            {
                this._hit = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    public enum DamageType
    {

        /// <remarks/>
        Direct,

        /// <remarks/>
        Physical,

        /// <remarks/>
        Magical,

        /// <remarks/>
        Elemental,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class Respawn
    {

        private int _interval;

        private int _min;

        private int _max;

        private float _percentage;

        public Respawn()
        {
            this._interval = 30;
            this._min = 1;
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(30)]
        public int Interval
        {
            get
            {
                return this._interval;
            }
            set
            {
                this._interval = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public int Min
        {
            get
            {
                return this._min;
            }
            set
            {
                this._min = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Max
        {
            get
            {
                return this._max;
            }
            set
            {
                this._max = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Percentage
        {
            get
            {
                return this._percentage;
            }
            set
            {
                this._percentage = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class Intent
    {

        private IntentType _intent;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IntentType intent
        {
            get
            {
                return this._intent;
            }
            set
            {
                this._intent = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    public enum IntentType
    {

        /// <remarks/>
        Hostile,

        /// <remarks/>
        Passive,

        /// <remarks/>
        Neutral,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    public partial class IntentList
    {

        private List<Intent> _npc;

        private List<Intent> _player;

        private List<Intent> _monster;

        public IntentList()
        {
            this._monster = new List<Intent>();
            this._player = new List<Intent>();
            this._npc = new List<Intent>();
        }

        [System.Xml.Serialization.XmlElementAttribute("Npc")]
        public List<Intent> Npc
        {
            get
            {
                return this._npc;
            }
            set
            {
                this._npc = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Player")]
        public List<Intent> Player
        {
            get
            {
                return this._player;
            }
            set
            {
                this._player = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Monster")]
        public List<Intent> Monster
        {
            get
            {
                return this._monster;
            }
            set
            {
                this._monster = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature", IsNullable = false)]
    public partial class SpawnGroup
    {

        private List<string> _maps;

        private List<Spawn> _spawns;

        public SpawnGroup()
        {
            this._spawns = new List<Spawn>();
            this._maps = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("Map", IsNullable = false)]
        public List<string> Maps
        {
            get
            {
                return this._maps;
            }
            set
            {
                this._maps = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<Spawn> Spawns
        {
            get
            {
                return this._spawns;
            }
            set
            {
                this._spawns = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.hybrasyl.com/XML/Creature", IsNullable = false)]
    public partial class Creature
    {

        private string _name;

        private string _description;

        private ushort _sprite;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Sprite
        {
            get
            {
                return this._sprite;
            }
            set
            {
                this._sprite = value;
            }
        }
    }
}
#pragma warning restore
