// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.31
//    <NameSpace>Hybrasyl</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><DataMemberNameArg>OnlyIfDifferent</DataMemberNameArg><DataMemberOnXmlIgnore>False</DataMemberOnXmlIgnore><CodeBaseTag>Net20</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>False</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>False</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>True</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>None</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><EnableRestriction>False</EnableRestriction><RestrictionMaxLenght>False</RestrictionMaxLenght><RestrictionRegEx>False</RestrictionRegEx><RestrictionRange>False</RestrictionRange><ValidateProperty>False</ValidateProperty><ClassNamePrefix></ClassNamePrefix><ClassLevel>Public</ClassLevel><PartialClass>True</PartialClass><ClassesInSeparateFiles>False</ClassesInSeparateFiles><ClassesInSeparateFilesDir></ClassesInSeparateFilesDir><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableAppInfoSettings>False</EnableAppInfoSettings><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><sspNullable>False</sspNullable><sspString>False</sspString><sspCollection>False</sspCollection><sspComplexType>False</sspComplexType><sspSimpleType>False</sspSimpleType><sspEnumType>False</sspEnumType><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings><AttributesToExlude></AttributesToExlude>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace Hybrasyl.Maps
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("map", Namespace = "http://www.hybrasyl.com/XML/Maps", IsNullable = false)]
    public partial class Map
    {

        private string _name;

        private string _description;

        private MapFlags _flags;

        private List<Warp> _warps;

        private List<Reactor> _reactors;

        private List<Npc> _npcs;

        private Signposts _signposts;

        private ushort _id;

        private byte _music;

        private byte _x;

        private byte _y;

        public Map()
        {
            this._signposts = new Signposts();
            this._npcs = new List<Npc>();
            this._reactors = new List<Reactor>();
            this._warps = new List<Warp>();
            this._music = ((byte)(0));
        }

        [System.Xml.Serialization.XmlElementAttribute("name")]
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

        [System.Xml.Serialization.XmlElementAttribute("description")]
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

        [System.Xml.Serialization.XmlElementAttribute("flags")]
        public MapFlags Flags
        {
            get
            {
                return this._flags;
            }
            set
            {
                this._flags = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("warp", IsNullable = false, ElementName = "warps")]
        public List<Warp> Warps
        {
            get
            {
                return this._warps;
            }
            set
            {
                this._warps = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("reactor", IsNullable = false, ElementName = "reactors")]
        public List<Reactor> Reactors
        {
            get
            {
                return this._reactors;
            }
            set
            {
                this._reactors = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("npc", IsNullable = false, ElementName = "npcs")]
        public List<Npc> Npcs
        {
            get
            {
                return this._npcs;
            }
            set
            {
                this._npcs = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("signposts")]
        public Signposts Signposts
        {
            get
            {
                return this._signposts;
            }
            set
            {
                this._signposts = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "id")]
        public ushort Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "music")]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte Music
        {
            get
            {
                return this._music;
            }
            set
            {
                this._music = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "x")]
        public byte X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "y")]
        public byte Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
    }

    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [System.Xml.Serialization.XmlRootAttribute("MapFlags")]
    public enum MapFlags
    {

        /// <remarks/>
        snow = 1,

        /// <remarks/>
        rain = 2,

        /// <remarks/>
        dark = 4,

        /// <remarks/>
        nomap = 8,

        /// <remarks/>
        winter = 16,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("Warp")]
    public partial class Warp
    {

        private string _description;

        private object _item;

        private WarpRestrictions _restrictions;

        private byte _x;

        private byte _y;

        public Warp()
        {
            this._restrictions = new WarpRestrictions();
        }

        [System.Xml.Serialization.XmlElementAttribute("description")]
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

        [System.Xml.Serialization.XmlElementAttribute("maptarget", typeof(WarpMaptarget))]
        [System.Xml.Serialization.XmlElementAttribute("worldmaptarget", typeof(string))]
        public object Item
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

        [System.Xml.Serialization.XmlElementAttribute("restrictions")]
        public WarpRestrictions Restrictions
        {
            get
            {
                return this._restrictions;
            }
            set
            {
                this._restrictions = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "x")]
        public byte X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "y")]
        public byte Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("WarpMaptarget")]
    public partial class WarpMaptarget
    {

        private byte _x;

        private byte _y;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "x")]
        public byte X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "y")]
        public byte Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("worldmap", Namespace = "http://www.hybrasyl.com/XML/Maps", IsNullable = false)]
    public partial class WorldMap
    {

        private string _name;

        private string _description;

        private WorldMapPoints _points;

        private string _clientmap;

        public WorldMap()
        {
            this._points = new WorldMapPoints();
        }

        [System.Xml.Serialization.XmlElementAttribute("name")]
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

        [System.Xml.Serialization.XmlElementAttribute("description")]
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

        [System.Xml.Serialization.XmlElementAttribute("points")]
        public WorldMapPoints Points
        {
            get
            {
                return this._points;
            }
            set
            {
                this._points = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "clientmap")]
        public string Clientmap
        {
            get
            {
                return this._clientmap;
            }
            set
            {
                this._clientmap = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("WorldMapPoints")]
    public partial class WorldMapPoints
    {

        private List<WorldMapPoint> _point;

        private WarpRestrictions _restrictions;

        public WorldMapPoints()
        {
            this._restrictions = new WarpRestrictions();
            this._point = new List<WorldMapPoint>();
        }

        [System.Xml.Serialization.XmlElementAttribute("point", ElementName = "point")]
        public List<WorldMapPoint> Point
        {
            get
            {
                return this._point;
            }
            set
            {
                this._point = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("restrictions")]
        public WarpRestrictions Restrictions
        {
            get
            {
                return this._restrictions;
            }
            set
            {
                this._restrictions = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("WorldMapPoint")]
    public partial class WorldMapPoint
    {

        private string _description;

        private string _name;

        private WorldMapPointTarget _target;

        private WarpRestrictions _restrictions;

        private ushort _x;

        private ushort _y;

        public WorldMapPoint()
        {
            this._restrictions = new WarpRestrictions();
            this._target = new WorldMapPointTarget();
        }

        [System.Xml.Serialization.XmlElementAttribute("description")]
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

        [System.Xml.Serialization.XmlElementAttribute("name")]
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

        [System.Xml.Serialization.XmlElementAttribute("target")]
        public WorldMapPointTarget Target
        {
            get
            {
                return this._target;
            }
            set
            {
                this._target = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("restrictions")]
        public WarpRestrictions Restrictions
        {
            get
            {
                return this._restrictions;
            }
            set
            {
                this._restrictions = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "x")]
        public ushort X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "y")]
        public ushort Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("WorldMapPointTarget")]
    public partial class WorldMapPointTarget
    {

        private byte _x;

        private byte _y;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "x")]
        public byte X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "y")]
        public byte Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [System.Xml.Serialization.XmlRootAttribute("WarpRestrictions")]
    public partial class WarpRestrictions
    {

        private WarpRestrictionsLevel _level;

        private WarpRestrictionsAB _ab;

        private object _noMobUse;

        public WarpRestrictions()
        {
            this._ab = new WarpRestrictionsAB();
            this._level = new WarpRestrictionsLevel();
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName = "level")]
        public WarpRestrictionsLevel Level
        {
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName = "ab")]
        public WarpRestrictionsAB Ab
        {
            get
            {
                return this._ab;
            }
            set
            {
                this._ab = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName = "noMobUse")]
        public object NoMobUse
        {
            get
            {
                return this._noMobUse;
            }
            set
            {
                this._noMobUse = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [System.Xml.Serialization.XmlRootAttribute("WarpRestrictionsLevel")]
    public partial class WarpRestrictionsLevel
    {

        private byte _min;

        private byte _max;

        public WarpRestrictionsLevel()
        {
            this._min = ((byte)(0));
            this._max = ((byte)(255));
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "min")]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte Min
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

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "max")]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "255")]
        public byte Max
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [System.Xml.Serialization.XmlRootAttribute("WarpRestrictionsAB")]
    public partial class WarpRestrictionsAB
    {

        private byte _min;

        private byte _max;

        public WarpRestrictionsAB()
        {
            this._min = ((byte)(0));
            this._max = ((byte)(255));
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "min")]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte Min
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

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "max")]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "255")]
        public byte Max
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("Npc")]
    public partial class Npc
    {

        private string _name;

        private string _displayname;

        private NpcAppearance _appearance;

        private NpcJobList _jobs;

        private List<object> _inventory;

        private byte _x;

        private byte _y;

        public Npc()
        {
            this._inventory = new List<object>();
            this._appearance = new NpcAppearance();
        }

        [System.Xml.Serialization.XmlElementAttribute("name")]
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

        [System.Xml.Serialization.XmlElementAttribute("displayname")]
        public string Displayname
        {
            get
            {
                return this._displayname;
            }
            set
            {
                this._displayname = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("appearance")]
        public NpcAppearance Appearance
        {
            get
            {
                return this._appearance;
            }
            set
            {
                this._appearance = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("jobs")]
        public NpcJobList Jobs
        {
            get
            {
                return this._jobs;
            }
            set
            {
                this._jobs = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("gold", typeof(byte), IsNullable = false, ElementName = "inventory")]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", typeof(NpcItem), IsNullable = false)]
        public List<object> Inventory
        {
            get
            {
                return this._inventory;
            }
            set
            {
                this._inventory = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "x")]
        public byte X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "y")]
        public byte Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("NpcAppearance")]
    public partial class NpcAppearance
    {

        private ushort _sprite;

        private string _portrait;

        private byte _direction;

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "sprite")]
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

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "portrait")]
        public string Portrait
        {
            get
            {
                return this._portrait;
            }
            set
            {
                this._portrait = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "direction")]
        public byte Direction
        {
            get
            {
                return this._direction;
            }
            set
            {
                this._direction = value;
            }
        }
    }

    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [System.Xml.Serialization.XmlRootAttribute("NpcJobList")]
    public enum NpcJobList
    {

        /// <remarks/>
        vend = 1,

        /// <remarks/>
        bank = 2,

        /// <remarks/>
        train = 4,

        /// <remarks/>
        repair = 8,

        /// <remarks/>
        post = 16,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("NpcItem")]
    public partial class NpcItem
    {

        private uint _quantity;

        private uint _refresh;

        private string _value;

        public NpcItem()
        {
            this._quantity = ((uint)(0));
            this._refresh = ((uint)(0));
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "quantity")]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "refresh")]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint Refresh
        {
            get
            {
                return this._refresh;
            }
            set
            {
                this._refresh = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("Signposts")]
    public partial class Signposts
    {

        private List<object> _items;

        public Signposts()
        {
            this._items = new List<object>();
        }

        [System.Xml.Serialization.XmlElementAttribute("messageboard", typeof(Messageboard))]
        [System.Xml.Serialization.XmlElementAttribute("signpost", typeof(Signpost))]
        public List<object> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("Messageboard")]
    public partial class Messageboard
    {

        private string _name;

        private string _description;

        private string _script;

        private byte _x;

        private byte _y;

        [System.Xml.Serialization.XmlElementAttribute("name")]
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

        [System.Xml.Serialization.XmlElementAttribute("description")]
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

        [System.Xml.Serialization.XmlElementAttribute("script")]
        public string Script
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

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "x")]
        public byte X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "y")]
        public byte Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("Signpost")]
    public partial class Signpost
    {

        private string _message;

        private string _script;

        private byte _x;

        private byte _y;

        [System.Xml.Serialization.XmlElementAttribute("message")]
        public string Message
        {
            get
            {
                return this._message;
            }
            set
            {
                this._message = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("script")]
        public string Script
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

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "x")]
        public byte X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "y")]
        public byte Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [System.Xml.Serialization.XmlRootAttribute("Reactor")]
    public partial class Reactor
    {

        private string _description;

        private string _script;

        private byte _x;

        private byte _y;

        private bool _blocking;

        public Reactor()
        {
            this._blocking = false;
        }

        [System.Xml.Serialization.XmlElementAttribute("description")]
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

        [System.Xml.Serialization.XmlElementAttribute("script")]
        public string Script
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

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "x")]
        public byte X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "y")]
        public byte Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "blocking")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Blocking
        {
            get
            {
                return this._blocking;
            }
            set
            {
                this._blocking = value;
            }
        }
    }
}
#pragma warning restore
