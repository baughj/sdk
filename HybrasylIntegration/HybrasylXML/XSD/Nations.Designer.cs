// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.31
//    <NameSpace>Hybrasyl</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><DataMemberNameArg>OnlyIfDifferent</DataMemberNameArg><DataMemberOnXmlIgnore>False</DataMemberOnXmlIgnore><CodeBaseTag>Net20</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>False</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>False</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>True</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>None</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><EnableRestriction>False</EnableRestriction><RestrictionMaxLenght>False</RestrictionMaxLenght><RestrictionRegEx>False</RestrictionRegEx><RestrictionRange>False</RestrictionRange><ValidateProperty>False</ValidateProperty><ClassNamePrefix></ClassNamePrefix><ClassLevel>Public</ClassLevel><PartialClass>True</PartialClass><ClassesInSeparateFiles>False</ClassesInSeparateFiles><ClassesInSeparateFilesDir></ClassesInSeparateFilesDir><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableAppInfoSettings>False</EnableAppInfoSettings><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><sspNullable>False</sspNullable><sspString>False</sspString><sspCollection>False</sspCollection><sspComplexType>False</sspComplexType><sspSimpleType>False</sspSimpleType><sspEnumType>False</sspEnumType><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings><AttributesToExlude></AttributesToExlude>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace Hybrasyl.Nations
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Nations", TypeName = "nation")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.hybrasyl.com/XML/Nations", IsNullable = false, ElementName = "nation")]
    public partial class Nation
    {

        private string _name;

        private string _description;

        private object _default;

        private List<SpawnPoint> _spawnpoints;

        private byte _flag;

        public Nation()
        {
            this._spawnpoints = new List<SpawnPoint>();
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

        [System.Xml.Serialization.XmlElementAttribute("default")]
        public object Default
        {
            get
            {
                return this._default;
            }
            set
            {
                this._default = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("spawnpoint", IsNullable = false, ElementName = "spawnpoints")]
        public List<SpawnPoint> Spawnpoints
        {
            get
            {
                return this._spawnpoints;
            }
            set
            {
                this._spawnpoints = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "flag")]
        public byte Flag
        {
            get
            {
                return this._flag;
            }
            set
            {
                this._flag = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Nations")]
    [System.Xml.Serialization.XmlRootAttribute("SpawnPoint")]
    public partial class SpawnPoint
    {

        private string _mapname;

        private byte _x;

        private byte _y;

        private string _value;

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "mapname")]
        public string Mapname
        {
            get
            {
                return this._mapname;
            }
            set
            {
                this._mapname = value;
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
}
#pragma warning restore
