// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.31
//    <NameSpace>Hybrasyl</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><DataMemberNameArg>OnlyIfDifferent</DataMemberNameArg><DataMemberOnXmlIgnore>False</DataMemberOnXmlIgnore><CodeBaseTag>Net20</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>False</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>False</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>None</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><EnableRestriction>False</EnableRestriction><RestrictionMaxLenght>False</RestrictionMaxLenght><RestrictionRegEx>False</RestrictionRegEx><RestrictionRange>False</RestrictionRange><ValidateProperty>False</ValidateProperty><ClassNamePrefix></ClassNamePrefix><ClassLevel>Public</ClassLevel><PartialClass>True</PartialClass><ClassesInSeparateFiles>False</ClassesInSeparateFiles><ClassesInSeparateFilesDir></ClassesInSeparateFilesDir><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableAppInfoSettings>False</EnableAppInfoSettings><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><sspNullable>False</sspNullable><sspString>False</sspString><sspCollection>False</sspCollection><sspComplexType>False</sspComplexType><sspSimpleType>False</sspSimpleType><sspEnumType>False</sspEnumType><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings><AttributesToExlude></AttributesToExlude>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace Hybrasyl.Config
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    [System.Xml.Serialization.XmlRootAttribute("hybrasylconfig", Namespace="http://www.hybrasyl.com/XML/Config", IsNullable=false)]
    public partial class HybrasylConfig
    {
        
        private LogConfig _logging;
        
        private DataStore _datastore;
        
        private Network _network;
        
        private Access _access;
        
        private List<GlobalBoard> _boards;
        
        private Time _time;
        
        private Handlers _handlers;
        
        public HybrasylConfig()
        {
            this._handlers = new Handlers();
            this._time = new Time();
            this._boards = new List<GlobalBoard>();
            this._access = new Access();
            this._network = new Network();
            this._datastore = new DataStore();
            this._logging = new LogConfig();
        }
        
        public LogConfig logging
        {
            get
            {
                return this._logging;
            }
            set
            {
                this._logging = value;
            }
        }
        
        public DataStore datastore
        {
            get
            {
                return this._datastore;
            }
            set
            {
                this._datastore = value;
            }
        }
        
        public Network network
        {
            get
            {
                return this._network;
            }
            set
            {
                this._network = value;
            }
        }
        
        public Access access
        {
            get
            {
                return this._access;
            }
            set
            {
                this._access = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("board", IsNullable=false)]
        public List<GlobalBoard> boards
        {
            get
            {
                return this._boards;
            }
            set
            {
                this._boards = value;
            }
        }
        
        public Time time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }
        
        public Handlers handlers
        {
            get
            {
                return this._handlers;
            }
            set
            {
                this._handlers = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class LogConfig
    {
        
        private string _type;
        
        private string _target;
        
        private LogLevel _level;
        
        public LogConfig()
        {
            this._type = "file";
            this._target = "hybrasyl.log";
            this._level = LogLevel.info;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("file")]
        public string type
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
        [System.ComponentModel.DefaultValueAttribute("hybrasyl.log")]
        public string target
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(LogLevel.info)]
        public LogLevel level
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public enum LogLevel
    {
        
        /// <remarks/>
        all,
        
        /// <remarks/>
        debug,
        
        /// <remarks/>
        info,
        
        /// <remarks/>
        warn,
        
        /// <remarks/>
        error,
        
        /// <remarks/>
        fatal,
        
        /// <remarks/>
        off,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class DeathLegendMark
    {
        
        private string _prefix;
        
        private bool _increment;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string prefix
        {
            get
            {
                return this._prefix;
            }
            set
            {
                this._prefix = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool increment
        {
            get
            {
                return this._increment;
            }
            set
            {
                this._increment = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class DeathPenalty
    {
        
        private uint _xp;
        
        private uint _hp;
        
        public DeathPenalty()
        {
            this._xp = ((uint)(5));
            this._hp = ((uint)(5));
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "5")]
        public uint xp
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
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "5")]
        public uint hp
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class DeathComa
    {
        
        private string _timeout;
        
        public DeathComa()
        {
            this._timeout = "30";
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("30")]
        public string timeout
        {
            get
            {
                return this._timeout;
            }
            set
            {
                this._timeout = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class DeathMap
    {
        
        private sbyte _x;
        
        private sbyte _y;
        
        private string _value;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte x
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte y
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class Death
    {
        
        private DeathMap _map;
        
        private DeathComa _coma;
        
        private DeathPenalty _penalty;
        
        private DeathLegendMark _legendmark;
        
        private bool _active;
        
        private bool _perishable;
        
        private bool _groupnotify;
        
        public Death()
        {
            this._legendmark = new DeathLegendMark();
            this._penalty = new DeathPenalty();
            this._coma = new DeathComa();
            this._map = new DeathMap();
            this._active = true;
            this._perishable = true;
            this._groupnotify = true;
        }
        
        public DeathMap map
        {
            get
            {
                return this._map;
            }
            set
            {
                this._map = value;
            }
        }
        
        public DeathComa coma
        {
            get
            {
                return this._coma;
            }
            set
            {
                this._coma = value;
            }
        }
        
        public DeathPenalty penalty
        {
            get
            {
                return this._penalty;
            }
            set
            {
                this._penalty = value;
            }
        }
        
        public DeathLegendMark legendmark
        {
            get
            {
                return this._legendmark;
            }
            set
            {
                this._legendmark = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool active
        {
            get
            {
                return this._active;
            }
            set
            {
                this._active = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool perishable
        {
            get
            {
                return this._perishable;
            }
            set
            {
                this._perishable = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool groupnotify
        {
            get
            {
                return this._groupnotify;
            }
            set
            {
                this._groupnotify = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class Handlers
    {
        
        private Death _death;
        
        public Handlers()
        {
            this._death = new Death();
        }
        
        public Death death
        {
            get
            {
                return this._death;
            }
            set
            {
                this._death = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class HybrasylAge
    {
        
        private string _name;
        
        private System.DateTime _startdate;
        
        private System.DateTime _enddate;
        
        private int _startyear;
        
        public string name
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
        
        public System.DateTime startdate
        {
            get
            {
                return this._startdate;
            }
            set
            {
                this._startdate = value;
            }
        }
        
        public System.DateTime enddate
        {
            get
            {
                return this._enddate;
            }
            set
            {
                this._enddate = value;
            }
        }
        
        public int startyear
        {
            get
            {
                return this._startyear;
            }
            set
            {
                this._startyear = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class Time
    {
        
        private List<HybrasylAge> _ages;
        
        public Time()
        {
            this._ages = new List<HybrasylAge>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("age", IsNullable=false)]
        public List<HybrasylAge> ages
        {
            get
            {
                return this._ages;
            }
            set
            {
                this._ages = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class GlobalBoardAccessList
    {
        
        private string[] _items;
        
        private ItemsChoiceType[] _itemsElementName;
        
        [System.Xml.Serialization.XmlElementAttribute("moderate", DataType="token")]
        [System.Xml.Serialization.XmlElementAttribute("read", DataType="token")]
        [System.Xml.Serialization.XmlElementAttribute("write", DataType="token")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
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
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this._itemsElementName;
            }
            set
            {
                this._itemsElementName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        
        /// <remarks/>
        moderate,
        
        /// <remarks/>
        read,
        
        /// <remarks/>
        write,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class GlobalBoard
    {
        
        private GlobalBoardAccessList _accesslist;
        
        private string _name;
        
        private string _displayname;
        
        public GlobalBoard()
        {
            this._accesslist = new GlobalBoardAccessList();
        }
        
        public GlobalBoardAccessList accesslist
        {
            get
            {
                return this._accesslist;
            }
            set
            {
                this._accesslist = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string name
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
        public string displayname
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class Access
    {
        
        private string _privileged;
        
        public string privileged
        {
            get
            {
                return this._privileged;
            }
            set
            {
                this._privileged = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class NetworkInfo
    {
        
        private string _bindaddress;
        
        private ushort _port;
        
        public NetworkInfo()
        {
            this._bindaddress = "127.0.0.1";
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("127.0.0.1")]
        public string bindaddress
        {
            get
            {
                return this._bindaddress;
            }
            set
            {
                this._bindaddress = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort port
        {
            get
            {
                return this._port;
            }
            set
            {
                this._port = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class Network
    {
        
        private NetworkInfo _lobby;
        
        private NetworkInfo _login;
        
        private NetworkInfo _world;
        
        public Network()
        {
            this._world = new NetworkInfo();
            this._login = new NetworkInfo();
            this._lobby = new NetworkInfo();
        }
        
        public NetworkInfo lobby
        {
            get
            {
                return this._lobby;
            }
            set
            {
                this._lobby = value;
            }
        }
        
        public NetworkInfo login
        {
            get
            {
                return this._login;
            }
            set
            {
                this._login = value;
            }
        }
        
        public NetworkInfo world
        {
            get
            {
                return this._world;
            }
            set
            {
                this._world = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Config")]
    public partial class DataStore
    {
        
        private string _username;
        
        private string _password;
        
        private string _type;
        
        private string _host;
        
        private ushort _port;
        
        public DataStore()
        {
            this._type = "redis";
            this._host = "localhost";
            this._port = ((ushort)(6379));
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string username
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        [System.ComponentModel.DefaultValueAttribute("redis")]
        public string type
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        [System.ComponentModel.DefaultValueAttribute("localhost")]
        public string host
        {
            get
            {
                return this._host;
            }
            set
            {
                this._host = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "6379")]
        public ushort port
        {
            get
            {
                return this._port;
            }
            set
            {
                this._port = value;
            }
        }
    }
}
#pragma warning restore
