// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.1
//    <NameSpace>Hybrasyl</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><DataMemberNameArg>OnlyIfDifferent</DataMemberNameArg><DataMemberOnXmlIgnore>False</DataMemberOnXmlIgnore><CodeBaseTag>Net40</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>False</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>False</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>True</PascalCase><AutomaticProperties>True</AutomaticProperties><PropNameSpecified>None</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><EnableRestriction>True</EnableRestriction><RestrictionMaxLenght>True</RestrictionMaxLenght><RestrictionRegEx>True</RestrictionRegEx><RestrictionRange>True</RestrictionRange><ValidateProperty>False</ValidateProperty><ClassNamePrefix></ClassNamePrefix><ClassLevel>Public</ClassLevel><PartialClass>True</PartialClass><ClassesInSeparateFiles>False</ClassesInSeparateFiles><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableAppInfoSettings>False</EnableAppInfoSettings><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><sspNullable>False</sspNullable><sspString>False</sspString><sspCollection>False</sspCollection><sspComplexType>False</sspComplexType><sspSimpleType>False</sspSimpleType><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings><AttributesToExlude></AttributesToExlude>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace Hybrasyl
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Xml;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Config")]
    [System.Xml.Serialization.XmlRootAttribute("hybrasylconfig", Namespace = "http://www.hybrasyl.com/XML/Config", IsNullable = false)]
    public partial class HybrasylConfig
    {

        [System.Xml.Serialization.XmlElementAttribute("datastore")]
        public DataStore Datastore { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("network")]
        public Network Network { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("access")]
        public Access Access { get; set; }
        [System.Xml.Serialization.XmlArrayItemAttribute("board", IsNullable = false, ElementName = "boards")]
        public List<Board> Boards { get; set; }

        public HybrasylConfig()
        {
            this.Boards = new List<Board>();
            this.Access = new Access();
            this.Network = new Network();
            this.Datastore = new DataStore();
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Config")]
    [System.Xml.Serialization.XmlRootAttribute("DataStore")]
    public partial class DataStore
    {

        [System.Xml.Serialization.XmlElementAttribute(DataType = "token", ElementName = "username")]
        public string Username { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token", ElementName = "password")]
        public string Password { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token", AttributeName = "type")]
        [System.ComponentModel.DefaultValueAttribute("redis")]
        public string Type { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token", AttributeName = "host")]
        [System.ComponentModel.DefaultValueAttribute("localhost")]
        public string Host { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "port")]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "6379")]
        public ushort Port { get; set; }

        public DataStore()
        {
            this.Type = "redis";
            this.Host = "localhost";
            this.Port = ((ushort)(6379));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Config")]
    [System.Xml.Serialization.XmlRootAttribute("BoardAccessList")]
    public partial class BoardAccessList
    {

        [System.Xml.Serialization.XmlElementAttribute("read")]
        public string Read { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("write")]
        public string Write { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("moderate")]
        public string Moderate { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Config")]
    [System.Xml.Serialization.XmlRootAttribute("Board")]
    public partial class Board
    {

        [System.Xml.Serialization.XmlElementAttribute("accesslist")]
        public BoardAccessList Accesslist { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token", AttributeName = "name")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "displayname")]
        public string Displayname { get; set; }

        public Board()
        {
            this.Accesslist = new BoardAccessList();
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Config")]
    [System.Xml.Serialization.XmlRootAttribute("Access")]
    public partial class Access
    {

        [System.Xml.Serialization.XmlElementAttribute("privileged")]
        public string Privileged { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Config")]
    [System.Xml.Serialization.XmlRootAttribute("NetworkInfo")]
    public partial class NetworkInfo
    {

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "bindaddress")]
        [System.ComponentModel.DefaultValueAttribute("127.0.0.1")]
        public string Bindaddress { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "port")]
        public ushort Port { get; set; }

        public NetworkInfo()
        {
            this.Bindaddress = "127.0.0.1";
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Config")]
    [System.Xml.Serialization.XmlRootAttribute("Network")]
    public partial class Network
    {

        [System.Xml.Serialization.XmlElementAttribute("lobby")]
        public NetworkInfo Lobby { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("login")]
        public NetworkInfo Login { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("world")]
        public NetworkInfo World { get; set; }

        public Network()
        {
            this.World = new NetworkInfo();
            this.Login = new NetworkInfo();
            this.Lobby = new NetworkInfo();
        }
    }
}
#pragma warning restore

