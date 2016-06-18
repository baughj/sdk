/*
 * This file is part of Project Hybrasyl.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the Affero General Public License as published by
 * the Free Software Foundation, version 3.
 *
 * This program is distributed in the hope that it will be useful, but
 * without ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
 * or FITNESS FOR A PARTICULAR PURPOSE. See the Affero General Public License
 * for more details.
 *
 * You should have received a copy of the Affero General Public License along
 * with this program. If not, see <http://www.gnu.org/licenses/>.
 *
 * (C) 2016 Project Hybrasyl (info@hybrasyl.com)
 *
 */

#pragma warning disable

namespace Hybrasyl.XSD
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("map", Namespace = "http://www.hybrasyl.com/XML/Maps", IsNullable = false)]
    public partial class Map
    {
        private List<Warp> _warps;

        private List<Reactor> _reactors;

        private List<Npc> _npcs;

        private List<Spawn> _spawns;

        private Signposts _signposts;

        [XmlElementAttribute("name")]
        public string Name { get; set; }

        [XmlElementAttribute("description")]
        public string Description { get; set; }

        [XmlElementAttribute("flags")]
        public MapFlags Flags { get; set; }

        [XmlIgnore]
        public bool FlagsSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "id")]
        public ushort Id { get; set; }

        [XmlAttributeAttribute(AttributeName = "music")]
        [DefaultValueAttribute(typeof(byte), "0")]
        public byte Music { get; set; }

        [XmlAttributeAttribute(AttributeName = "x")]
        public byte X { get; set; }

        [XmlAttributeAttribute(AttributeName = "y")]
        public byte Y { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool DescriptionSpecified { get; set; }

        [XmlIgnore()]
        public bool WarpsSpecified { get; set; }

        [XmlIgnore()]
        public bool ReactorsSpecified { get; set; }

        [XmlIgnore()]
        public bool NpcsSpecified { get; set; }

        [XmlIgnore()]
        public bool SpawnsSpecified { get; set; }

        [XmlIgnore()]
        public bool SignpostsSpecified { get; set; }

        [XmlIgnore()]
        public bool IdSpecified { get; set; }

        [XmlIgnore()]
        public bool MusicSpecified { get; set; }

        [XmlIgnore()]
        public bool XSpecified { get; set; }

        [XmlIgnore()]
        public bool YSpecified { get; set; }

        public Map()
        {
            Music = ((byte)(0));
        }

        [XmlArray("warps")]
        [XmlArrayItemAttribute("warp", IsNullable = false, ElementName = "warp")]
        public List<Warp> Warps
        {
            get
            {
                if ((_warps == null))
                {
                    _warps = new List<Warp>();
                }
                return _warps;
            }
            set
            {
                _warps = value;
            }
        }

        [XmlArrayItemAttribute("reactor", IsNullable = false, ElementName = "reactors")]
        public List<Reactor> Reactors
        {
            get
            {
                if ((_reactors == null))
                {
                    _reactors = new List<Reactor>();
                }
                return _reactors;
            }
            set
            {
                _reactors = value;
            }
        }

        [XmlArray("npcs")]
        [XmlArrayItemAttribute("npc", IsNullable = false, ElementName = "npc")]
        public List<Npc> Npcs
        {
            get
            {
                if ((_npcs == null))
                {
                    _npcs = new List<Npc>();
                }
                return _npcs;
            }
            set
            {
                _npcs = value;
            }
        }

        [XmlArrayItemAttribute("spawn", IsNullable = false, ElementName = "spawns")]
        public List<Spawn> Spawns
        {
            get
            {
                if ((_spawns == null))
                {
                    _spawns = new List<Spawn>();
                }
                return _spawns;
            }
            set
            {
                _spawns = value;
            }
        }

        [XmlElementAttribute("signposts")]
        public Signposts Signposts
        {
            get
            {
                if ((_signposts == null))
                {
                    _signposts = new Signposts();
                }
                return _signposts;
            }
            set
            {
                _signposts = value;
            }
        }
    }

    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("MapFlags")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("Warp")]
    public partial class Warp
    {
        private WarpRestrictions _restrictions;

        [XmlElementAttribute("description")]
        public string Description { get; set; }

        [XmlElementAttribute("maptarget", typeof(WarpMaptarget))]
        public WarpMaptarget MapTarget { get; set; }

        [XmlElementAttribute("worldmaptarget", typeof(WorldMapPointTarget))]
        public object WorldMapTarget { get; set; }

        [XmlAttributeAttribute(AttributeName = "x")]
        public byte X { get; set; }

        [XmlAttributeAttribute(AttributeName = "y")]
        public byte Y { get; set; }

        [XmlIgnore()]
        public bool DescriptionSpecified { get; set; }

        [XmlIgnore()]
        public bool ItemSpecified { get; set; }

        [XmlIgnore()]
        public bool RestrictionsSpecified { get; set; }

        [XmlIgnore()]
        public bool XSpecified { get; set; }

        [XmlIgnore()]
        public bool YSpecified { get; set; }

        [XmlElementAttribute("restrictions")]
        public WarpRestrictions Restrictions
        {
            get
            {
                if ((_restrictions == null))
                {
                    _restrictions = new WarpRestrictions();
                }
                return _restrictions;
            }
            set
            {
                _restrictions = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("WarpMaptarget")]
    public partial class WarpMaptarget
    {
        [XmlAttributeAttribute(AttributeName = "x")]
        public byte X { get; set; }

        [XmlAttributeAttribute(AttributeName = "y")]
        public byte Y { get; set; }

        [XmlTextAttribute]
        public string Value { get; set; }

        [XmlIgnore()]
        public bool XSpecified { get; set; }

        [XmlIgnore()]
        public bool YSpecified { get; set; }

        [XmlIgnore()]
        public bool ValueSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("worldmap", Namespace = "http://www.hybrasyl.com/XML/Maps", IsNullable = false)]
    public partial class WorldMap
    {
        private WorldMapPoints _points;

        [XmlElementAttribute("name")]
        public string Name { get; set; }

        [XmlElementAttribute("description")]
        public string Description { get; set; }

        [XmlAttributeAttribute(AttributeName = "clientmap")]
        public string Clientmap { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool DescriptionSpecified { get; set; }

        [XmlIgnore()]
        public bool PointsSpecified { get; set; }

        [XmlIgnore()]
        public bool ClientmapSpecified { get; set; }

        [XmlElementAttribute("points")]
        public WorldMapPoints Points
        {
            get
            {
                if ((_points == null))
                {
                    _points = new WorldMapPoints();
                }
                return _points;
            }
            set
            {
                _points = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("WorldMapPoints")]
    public partial class WorldMapPoints
    {
        private List<WorldMapPoint> _point;

        private WarpRestrictions _restrictions;

        [XmlIgnore()]
        public bool PointSpecified { get; set; }

        [XmlIgnore()]
        public bool RestrictionsSpecified { get; set; }

        [XmlElementAttribute("point", ElementName = "point")]
        public List<WorldMapPoint> Point
        {
            get
            {
                if ((_point == null))
                {
                    _point = new List<WorldMapPoint>();
                }
                return _point;
            }
            set
            {
                _point = value;
            }
        }

        [XmlElementAttribute("restrictions")]
        public WarpRestrictions Restrictions
        {
            get
            {
                if ((_restrictions == null))
                {
                    _restrictions = new WarpRestrictions();
                }
                return _restrictions;
            }
            set
            {
                _restrictions = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("WorldMapPoint")]
    public partial class WorldMapPoint
    {
        private WorldMapPointTarget _target;

        private WarpRestrictions _restrictions;

        [XmlElementAttribute("description")]
        public string Description { get; set; }

        [XmlElementAttribute("name")]
        public string Name { get; set; }

        [XmlAttributeAttribute(AttributeName = "x")]
        public ushort X { get; set; }

        [XmlAttributeAttribute(AttributeName = "y")]
        public ushort Y { get; set; }

        [XmlIgnore()]
        public bool DescriptionSpecified { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool TargetSpecified { get; set; }

        [XmlIgnore()]
        public bool RestrictionsSpecified { get; set; }

        [XmlIgnore()]
        public bool XSpecified { get; set; }

        [XmlIgnore()]
        public bool YSpecified { get; set; }

        [XmlElementAttribute("target")]
        public WorldMapPointTarget Target
        {
            get
            {
                if ((_target == null))
                {
                    _target = new WorldMapPointTarget();
                }
                return _target;
            }
            set
            {
                _target = value;
            }
        }

        [XmlElementAttribute("restrictions")]
        public WarpRestrictions Restrictions
        {
            get
            {
                if ((_restrictions == null))
                {
                    _restrictions = new WarpRestrictions();
                }
                return _restrictions;
            }
            set
            {
                _restrictions = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("WorldMapPointTarget")]
    public partial class WorldMapPointTarget
    {
        [XmlAttributeAttribute(AttributeName = "x")]
        public byte X { get; set; }

        [XmlAttributeAttribute(AttributeName = "y")]
        public byte Y { get; set; }

        [XmlTextAttribute]
        public string Value { get; set; }

        [XmlIgnore()]
        public bool XSpecified { get; set; }

        [XmlIgnore()]
        public bool YSpecified { get; set; }

        [XmlIgnore()]
        public bool ValueSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("WarpRestrictions")]
    public partial class WarpRestrictions
    {
        private WarpRestrictionsLevel _level;

        private WarpRestrictionsAB _ab;

        [XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName = "noMobUse")]
        public object NoMobUse { get; set; }

        [XmlIgnore()]
        public bool LevelSpecified { get; set; }

        [XmlIgnore()]
        public bool AbSpecified { get; set; }

        [XmlIgnore()]
        public bool NoMobUseSpecified { get; set; }

        [XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName = "level")]
        public WarpRestrictionsLevel Level
        {
            get
            {
                if ((_level == null))
                {
                    _level = new WarpRestrictionsLevel();
                }
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        [XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName = "ab")]
        public WarpRestrictionsAB Ab
        {
            get
            {
                if ((_ab == null))
                {
                    _ab = new WarpRestrictionsAB();
                }
                return _ab;
            }
            set
            {
                _ab = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("WarpRestrictionsLevel")]
    public partial class WarpRestrictionsLevel
    {
        [XmlAttributeAttribute(AttributeName = "min")]
        [DefaultValueAttribute(typeof(byte), "0")]
        public byte Min { get; set; }

        [XmlAttributeAttribute(AttributeName = "max")]
        [DefaultValueAttribute(typeof(byte), "255")]
        public byte Max { get; set; }

        [XmlIgnore()]
        public bool MinSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }

        public WarpRestrictionsLevel()
        {
            Min = ((byte)(0));
            Max = ((byte)(255));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("WarpRestrictionsAB")]
    public partial class WarpRestrictionsAB
    {
        [XmlAttributeAttribute(AttributeName = "min")]
        [DefaultValueAttribute(typeof(byte), "0")]
        public byte Min { get; set; }

        [XmlAttributeAttribute(AttributeName = "max")]
        [DefaultValueAttribute(typeof(byte), "255")]
        public byte Max { get; set; }

        [XmlIgnore()]
        public bool MinSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }

        public WarpRestrictionsAB()
        {
            Min = ((byte)(0));
            Max = ((byte)(255));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("Npc")]
    public partial class Npc
    {
        private NpcAppearance _appearance;

        private List<object> _inventory;

        [XmlElementAttribute("name")]
        public string Name { get; set; }

        [XmlElementAttribute("displayname")]
        public string Displayname { get; set; }

        [XmlElementAttribute("jobs")]
        public NpcJobList Jobs { get; set; }

        [XmlIgnore]
        public bool JobsSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "x")]
        public byte X { get; set; }

        [XmlAttributeAttribute(AttributeName = "y")]
        public byte Y { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool DisplaynameSpecified { get; set; }

        [XmlIgnore()]
        public bool AppearanceSpecified { get; set; }

        [XmlIgnore()]
        public bool InventorySpecified { get; set; }

        [XmlIgnore()]
        public bool XSpecified { get; set; }

        [XmlIgnore()]
        public bool YSpecified { get; set; }

        [XmlElementAttribute("appearance")]
        public NpcAppearance Appearance
        {
            get
            {
                if ((_appearance == null))
                {
                    _appearance = new NpcAppearance();
                }
                return _appearance;
            }
            set
            {
                _appearance = value;
            }
        }

        [XmlArrayItemAttribute("gold", typeof(byte), IsNullable = false, ElementName = "inventory")]
        [XmlArrayItemAttribute("item", typeof(NpcItem), IsNullable = false)]
        public List<object> Inventory
        {
            get
            {
                if ((_inventory == null))
                {
                    _inventory = new List<object>();
                }
                return _inventory;
            }
            set
            {
                _inventory = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("NpcAppearance")]
    public partial class NpcAppearance
    {
        [XmlAttributeAttribute(AttributeName = "sprite")]
        public ushort Sprite { get; set; }

        [XmlAttributeAttribute(AttributeName = "portrait")]
        public string Portrait { get; set; }

        [XmlAttributeAttribute(AttributeName = "direction")]
        public byte Direction { get; set; }

        [XmlIgnore()]
        public bool SpriteSpecified { get; set; }

        [XmlIgnore()]
        public bool PortraitSpecified { get; set; }

        [XmlIgnore()]
        public bool DirectionSpecified { get; set; }
    }

    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("NpcJobList")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("NpcItem")]
    public partial class NpcItem
    {
        [XmlAttributeAttribute(AttributeName = "quantity")]
        [DefaultValueAttribute(typeof(uint), "0")]
        public uint Quantity { get; set; }

        [XmlAttributeAttribute(AttributeName = "refresh")]
        [DefaultValueAttribute(typeof(uint), "0")]
        public uint Refresh { get; set; }

        [XmlTextAttribute]
        public string Value { get; set; }

        [XmlIgnore()]
        public bool QuantitySpecified { get; set; }

        [XmlIgnore()]
        public bool RefreshSpecified { get; set; }

        [XmlIgnore()]
        public bool ValueSpecified { get; set; }

        public NpcItem()
        {
            Quantity = ((uint)(0));
            Refresh = ((uint)(0));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("Signposts")]
    public partial class Signposts
    {
        private List<object> _items;

        [XmlIgnore()]
        public bool ItemsSpecified { get; set; }

        [XmlElementAttribute("messageboard", typeof(Messageboard))]
        [XmlElementAttribute("signpost", typeof(Signpost))]
        public List<object> Items
        {
            get
            {
                if ((_items == null))
                {
                    _items = new List<object>();
                }
                return _items;
            }
            set
            {
                _items = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("Messageboard")]
    public partial class Messageboard
    {
        [XmlElementAttribute("name")]
        public string Name { get; set; }

        [XmlElementAttribute("description")]
        public string Description { get; set; }

        [XmlElementAttribute("script")]
        public string Script { get; set; }

        [XmlAttributeAttribute(AttributeName = "x")]
        public byte X { get; set; }

        [XmlAttributeAttribute(AttributeName = "y")]
        public byte Y { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool DescriptionSpecified { get; set; }

        [XmlIgnore()]
        public bool ScriptSpecified { get; set; }

        [XmlIgnore()]
        public bool XSpecified { get; set; }

        [XmlIgnore()]
        public bool YSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("Signpost")]
    public partial class Signpost
    {
        [XmlElementAttribute("message")]
        public string Message { get; set; }

        [XmlElementAttribute("script")]
        public string Script { get; set; }

        [XmlAttributeAttribute(AttributeName = "x")]
        public byte X { get; set; }

        [XmlAttributeAttribute(AttributeName = "y")]
        public byte Y { get; set; }

        [XmlIgnore()]
        public bool MessageSpecified { get; set; }

        [XmlIgnore()]
        public bool ScriptSpecified { get; set; }

        [XmlIgnore()]
        public bool XSpecified { get; set; }

        [XmlIgnore()]
        public bool YSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("Spawn")]
    public partial class Spawn
    {
        private SpawnModifiers _spawnModifiers;

        [XmlElementAttribute("name")]
        public string Name { get; set; }

        [XmlElementAttribute("description")]
        public string Description { get; set; }

        [DefaultValueAttribute("random")]
        [XmlElementAttribute("strategy")]
        public string Strategy { get; set; }

        [XmlAttributeAttribute(DataType = "nonNegativeInteger", AttributeName = "interval")]
        public string Interval { get; set; }

        [XmlAttributeAttribute(DataType = "nonNegativeInteger", AttributeName = "checkInterval")]
        public string CheckInterval { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool DescriptionSpecified { get; set; }

        [XmlIgnore()]
        public bool StrategySpecified { get; set; }

        [XmlIgnore()]
        public bool SpawnModifiersSpecified { get; set; }

        [XmlIgnore()]
        public bool IntervalSpecified { get; set; }

        [XmlIgnore()]
        public bool CheckIntervalSpecified { get; set; }

        public Spawn()
        {
            Strategy = "random";
        }

        [XmlElementAttribute("spawnModifiers")]
        public SpawnModifiers SpawnModifiers
        {
            get
            {
                if ((_spawnModifiers == null))
                {
                    _spawnModifiers = new SpawnModifiers();
                }
                return _spawnModifiers;
            }
            set
            {
                _spawnModifiers = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("SpawnModifiers")]
    public partial class SpawnModifiers
    {
        private SpawnModifiersQuantity _quantity;

        private List<SpawnModifiersZone> _zone;

        [XmlElementAttribute("speed")]
        public float Speed { get; set; }

        [XmlIgnore]
        public bool SpeedSpecified { get; set; }

        [XmlElementAttribute("passive")]
        public object Passive { get; set; }

        [XmlIgnore()]
        public bool PassiveSpecified { get; set; }

        [XmlIgnore()]
        public bool QuantitySpecified { get; set; }

        [XmlIgnore()]
        public bool ZoneSpecified { get; set; }

        [XmlElementAttribute("quantity")]
        public SpawnModifiersQuantity Quantity
        {
            get
            {
                if ((_quantity == null))
                {
                    _quantity = new SpawnModifiersQuantity();
                }
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

        [XmlElementAttribute("zone", ElementName = "zone")]
        public List<SpawnModifiersZone> Zone
        {
            get
            {
                if ((_zone == null))
                {
                    _zone = new List<SpawnModifiersZone>();
                }
                return _zone;
            }
            set
            {
                _zone = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("SpawnModifiersQuantity")]
    public partial class SpawnModifiersQuantity
    {
        [XmlAttributeAttribute(DataType = "nonNegativeInteger", AttributeName = "min")]
        public string Min { get; set; }

        [XmlAttributeAttribute(DataType = "nonNegativeInteger", AttributeName = "max")]
        public string Max { get; set; }

        [XmlAttributeAttribute(AttributeName = "percentage")]
        public float Percentage { get; set; }

        [XmlIgnore]
        public bool PercentageSpecified { get; set; }

        [XmlIgnore()]
        public bool MinSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("SpawnModifiersZone")]
    public partial class SpawnModifiersZone
    {
        [XmlAttributeAttribute(AttributeName = "start")]
        public string Start { get; set; }

        [XmlAttributeAttribute(AttributeName = "end")]
        public string End { get; set; }

        [XmlIgnore()]
        public bool StartSpecified { get; set; }

        [XmlIgnore()]
        public bool EndSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Maps")]
    [XmlRootAttribute("Reactor")]
    public partial class Reactor
    {
        [XmlElementAttribute("description")]
        public string Description { get; set; }

        [XmlElementAttribute("script")]
        public string Script { get; set; }

        [XmlAttributeAttribute(AttributeName = "x")]
        public byte X { get; set; }

        [XmlAttributeAttribute(AttributeName = "y")]
        public byte Y { get; set; }

        [XmlAttributeAttribute(AttributeName = "blocking")]
        [DefaultValueAttribute(false)]
        public bool Blocking { get; set; }

        [XmlIgnore()]
        public bool DescriptionSpecified { get; set; }

        [XmlIgnore()]
        public bool ScriptSpecified { get; set; }

        [XmlIgnore()]
        public bool XSpecified { get; set; }

        [XmlIgnore()]
        public bool YSpecified { get; set; }

        [XmlIgnore()]
        public bool BlockingSpecified { get; set; }

        public Reactor()
        {
            Blocking = false;
        }
    }
}

#pragma warning restore