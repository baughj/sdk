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

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class VariantAttribute : Attribute { }
    public class VariantOverride : Attribute { }
    public class VariantTraverse : Attribute { }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("item", Namespace = "http://www.hybrasyl.com/XML/Items", IsNullable = false)]
    public partial class ItemType
    {
        private ItemProperties _properties;

        [XmlElementAttribute("name")]
        public string Name { get; set; }

        [XmlElementAttribute("comment")]
        public string Comment { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool CommentSpecified { get; set; }

        [XmlIgnore()]
        public bool PropertiesSpecified { get; set; }

        [XmlElementAttribute("properties")]
        [VariantTraverse]
        public ItemProperties Properties
        {
            get
            {
                if ((_properties == null))
                {
                    _properties = new ItemProperties();
                }
                return _properties;
            }
            set
            {
                _properties = value;
            }
        }

        public ItemType Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Position = 0;
            object obj = bf.Deserialize(ms);
            ms.Close();
            return (ItemType) obj;
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemProperties")]
    public partial class ItemProperties
    {
        private ItemPropertiesAppearance _appearance;

        private List<CastModifiersLines> _castmodifiers;

        private ItemPropertiesStackable _stackable;

        private ItemPropertiesPhysical _physical;

        private ItemPropertiesEquipment _equipment;

        private ItemPropertiesStateffects _stateffects;

        private ItemPropertiesVariants _variants;

        private ItemPropertiesVendor _vendor;

        private ItemPropertiesDamage _damage;

        private ItemPropertiesUse _use;

        private ItemPropertiesRestrictions _restrictions;

        [XmlElementAttribute("flags")]
        [VariantOverride]
        public ItemFlags Flags { get; set; }

        [XmlIgnore]
        public bool FlagsSpecified { get; set; }

        [XmlIgnore()]
        public bool AppearanceSpecified { get; set; }

        [XmlIgnore()]
        public bool CastmodifiersSpecified { get; set; }

        [XmlIgnore()]
        public bool StackableSpecified { get; set; }

        [XmlIgnore()]
        public bool PhysicalSpecified { get; set; }

        [XmlIgnore()]
        public bool EquipmentSpecified { get; set; }

        [XmlIgnore()]
        public bool StateffectsSpecified { get; set; }

        [XmlIgnore()]
        public bool VariantsSpecified { get; set; }

        [XmlIgnore()]
        public bool VendorSpecified { get; set; }

        [XmlIgnore()]
        public bool DamageSpecified { get; set; }

        [XmlIgnore()]
        public bool UseSpecified { get; set; }

        [XmlIgnore()]
        public bool RestrictionsSpecified { get; set; }

        [XmlElementAttribute("appearance")]
        [VariantTraverse]
        public ItemPropertiesAppearance Appearance
        {
            get
            {
                if ((_appearance == null))
                {
                    _appearance = new ItemPropertiesAppearance();
                }
                return _appearance;
            }
            set
            {
                _appearance = value;
            }
        }

        [XmlArrayItemAttribute("lines", IsNullable = false, ElementName = "castmodifiers")]
        public List<CastModifiersLines> Castmodifiers
        {
            get
            {
                if ((_castmodifiers == null))
                {
                    _castmodifiers = new List<CastModifiersLines>();
                }
                return _castmodifiers;
            }
            set
            {
                _castmodifiers = value;
            }
        }

        [XmlElementAttribute("stackable")]
        [VariantTraverse]
        public ItemPropertiesStackable Stackable
        {
            get
            {
                if ((_stackable == null))
                {
                    _stackable = new ItemPropertiesStackable();
                }
                return _stackable;
            }
            set
            {
                _stackable = value;
            }
        }

        [XmlElementAttribute("physical")]
        [VariantTraverse]
        public ItemPropertiesPhysical Physical
        {
            get
            {
                if ((_physical == null))
                {
                    _physical = new ItemPropertiesPhysical();
                }
                return _physical;
            }
            set
            {
                _physical = value;
            }
        }

        [XmlElementAttribute("equipment")]
        [VariantTraverse]
        public ItemPropertiesEquipment Equipment
        {
            get
            {
                if ((_equipment == null))
                {
                    _equipment = new ItemPropertiesEquipment();
                }
                return _equipment;
            }
            set
            {
                _equipment = value;
            }
        }

        [XmlElementAttribute("stateffects")]
        [VariantTraverse]
        public ItemPropertiesStateffects Stateffects
        {
            get
            {
                if ((_stateffects == null))
                {
                    _stateffects = new ItemPropertiesStateffects();
                }
                return _stateffects;
            }
            set
            {
                _stateffects = value;
            }
        }

        [XmlElementAttribute("variants")]
        [VariantTraverse]
        public ItemPropertiesVariants Variants
        {
            get
            {
                if ((_variants == null))
                {
                    _variants = new ItemPropertiesVariants();
                }
                return _variants;
            }
            set
            {
                _variants = value;
            }
        }

        [XmlElementAttribute("vendor")]
        [VariantTraverse]
        public ItemPropertiesVendor Vendor
        {
            get
            {
                if ((_vendor == null))
                {
                    _vendor = new ItemPropertiesVendor();
                }
                return _vendor;
            }
            set
            {
                _vendor = value;
            }
        }

        [XmlElementAttribute("damage")]
        public ItemPropertiesDamage Damage
        {
            get
            {
                if ((_damage == null))
                {
                    _damage = new ItemPropertiesDamage();
                }
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }

        [XmlElementAttribute("use")]
        public ItemPropertiesUse Use
        {
            get
            {
                if ((_use == null))
                {
                    _use = new ItemPropertiesUse();
                }
                return _use;
            }
            set
            {
                _use = value;
            }
        }

        [XmlElementAttribute("restrictions")]
        public ItemPropertiesRestrictions Restrictions
        {
            get
            {
                if ((_restrictions == null))
                {
                    _restrictions = new ItemPropertiesRestrictions();
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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesAppearance")]
    public partial class ItemPropertiesAppearance
    {
        [XmlAttributeAttribute(AttributeName = "sprite")]
        [VariantOverride]
        public ushort Sprite { get; set; }

        [XmlAttributeAttribute(AttributeName = "equipsprite")]
        [VariantOverride]
        public ushort Equipsprite { get; set; }

        [XmlIgnore]
        public bool EquipspriteSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "displaysprite")]
        [VariantOverride]
        public ushort Displaysprite { get; set; }

        [XmlIgnore]
        public bool DisplayspriteSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "bodystyle")]
        [DefaultValueAttribute(ItemBodystyle.transparent)]
        [VariantOverride]
        public ItemBodystyle Bodystyle { get; set; }

        [XmlAttributeAttribute(AttributeName = "color")]
        [DefaultValueAttribute(ItemColor.none)]
        [VariantOverride]
        public ItemColor Color { get; set; }

        [XmlIgnore()]
        public bool SpriteSpecified { get; set; }

        [XmlIgnore()]
        public bool BodystyleSpecified { get; set; }

        [XmlIgnore()]
        public bool ColorSpecified { get; set; }

        public ItemPropertiesAppearance()
        {
            Bodystyle = ItemBodystyle.transparent;
            Color = ItemColor.none;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("ItemBodystyle")]
    public enum ItemBodystyle
    {
        /// <remarks/>
        male,

        /// <remarks/>
        transparent,

        /// <remarks/>
        maleblack,

        /// <remarks/>
        malered,

        /// <remarks/>
        female,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("ItemColor")]
    public enum ItemColor
    {
        /// <remarks/>
        none,

        /// <remarks/>
        black,

        /// <remarks/>
        red,

        /// <remarks/>
        orange,

        /// <remarks/>
        yellow,

        /// <remarks/>
        teal,

        /// <remarks/>
        blue,

        /// <remarks/>
        purple,

        /// <remarks/>
        darkgreen,

        /// <remarks/>
        green,

        /// <remarks/>
        lightorange,

        /// <remarks/>
        brown,

        /// <remarks/>
        grey,

        /// <remarks/>
        darkblue,

        /// <remarks/>
        flesh,

        white
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("CastModifiersLines")]
    public partial class CastModifiersLines
    {
        [XmlAttributeAttribute(AttributeName = "offset")]
        public sbyte Offset { get; set; }

        [XmlIgnore]
        public bool OffsetSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "number")]
        public sbyte Number { get; set; }

        [XmlIgnore]
        public bool NumberSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "modifier")]
        public sbyte Modifier { get; set; }

        [XmlIgnore]
        public bool ModifierSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "global")]
        [DefaultValueAttribute(false)]
        public bool Global { get; set; }

        [XmlAttributeAttribute(DataType = "token", AttributeName = "spellgroup")]
        public string Spellgroup { get; set; }

        [XmlAttributeAttribute(AttributeName = "min")]
        public sbyte Min { get; set; }

        [XmlIgnore]
        public bool MinSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "max")]
        public sbyte Max { get; set; }

        [XmlIgnore]
        public bool MaxSpecified { get; set; }

        [XmlIgnore()]
        public bool GlobalSpecified { get; set; }

        [XmlIgnore()]
        public bool SpellgroupSpecified { get; set; }

        public CastModifiersLines()
        {
            Global = false;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesStackable")]
    public partial class ItemPropertiesStackable
    {
        [XmlAttributeAttribute(AttributeName = "max")]
        public byte Max { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesPhysical")]
    public partial class ItemPropertiesPhysical
    {
        [XmlAttributeAttribute(AttributeName = "value")]
        [DefaultValueAttribute(typeof(uint), "0")]
        [VariantAttribute]
        public uint Value { get; set; }

        [XmlAttributeAttribute(AttributeName = "weight")]
        [DefaultValueAttribute(1)]
        [VariantAttribute]
        public int Weight { get; set; }

        [XmlAttributeAttribute(AttributeName = "durability")]
        [DefaultValueAttribute(typeof(uint), "1")]
        [VariantAttribute]
        public uint Durability { get; set; }

        [XmlAttributeAttribute(AttributeName = "perishable")]
        [DefaultValueAttribute(false)]
        [VariantOverride]
        public bool Perishable { get; set; }

        [XmlAttributeAttribute(AttributeName = "vendorable")]
        [DefaultValueAttribute(true)]
        [VariantOverride]
        public bool Vendorable { get; set; }

        [XmlAttributeAttribute(AttributeName = "bound")]
        [DefaultValueAttribute(false)]
        [VariantOverride]
        public bool Bound { get; set; }

        [XmlIgnore()]
        public bool ValueSpecified { get; set; }

        [XmlIgnore()]
        public bool WeightSpecified { get; set; }

        [XmlIgnore()]
        public bool DurabilitySpecified { get; set; }

        [XmlIgnore()]
        public bool PerishableSpecified { get; set; }

        [XmlIgnore()]
        public bool VendorableSpecified { get; set; }

        [XmlIgnore()]
        public bool BoundSpecified { get; set; }

        public ItemPropertiesPhysical()
        {
            Value = ((uint)(0));
            Weight = 1;
            Durability = ((uint)(1));
            Perishable = false;
            Vendorable = true;
            Bound = false;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesEquipment")]
    public partial class ItemPropertiesEquipment
    {
        [XmlAttributeAttribute(AttributeName = "slot")]
        public EquipmentSlot Slot { get; set; }

        [XmlAttributeAttribute(AttributeName = "unique")]
        [DefaultValueAttribute(false)]
        public bool Unique { get; set; }

        [XmlAttributeAttribute(AttributeName = "weapontype")]
        public WeaponType Weapontype { get; set; }

        [XmlIgnore]
        public bool WeapontypeSpecified { get; set; }

        [XmlIgnore()]
        public bool SlotSpecified { get; set; }

        [XmlIgnore()]
        public bool UniqueSpecified { get; set; }

        public ItemPropertiesEquipment()
        {
            Unique = false;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("EquipmentSlot")]
    public enum EquipmentSlot
    {
        /// <remarks/>
        none,

        /// <remarks/>
        weapon,

        /// <remarks/>
        armor,

        /// <remarks/>
        shield,

        /// <remarks/>
        helmet,

        /// <remarks/>
        earring,

        /// <remarks/>
        necklace,

        /// <remarks/>
        lefthand,

        /// <remarks/>
        righthand,

        /// <remarks/>
        leftarm,

        /// <remarks/>
        rightarm,

        /// <remarks/>
        waist,

        /// <remarks/>
        leg,

        /// <remarks/>
        foot,

        /// <remarks/>
        firstacc,

        /// <remarks/>
        trousers,

        /// <remarks/>
        coat,

        /// <remarks/>
        secondacc,

        /// <remarks/>
        thirdacc,

        /// <remarks/>
        gauntlet,

        /// <remarks/>
        ring,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("WeaponType")]
    public enum WeaponType
    {
        /// <remarks/>
        onehand,

        /// <remarks/>
        twohand,

        /// <remarks/>
        dagger,

        /// <remarks/>
        staff,

        /// <remarks/>
        claw,

        none
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesStateffects")]
    public partial class ItemPropertiesStateffects
    {
        [VariantTraverse]
        private ItemPropertiesStateffectsBase _base;

        [VariantTraverse]
        private ItemPropertiesStateffectsCombat _combat;

        [VariantTraverse]
        private ItemPropertiesStateffectsElement _element;

        [XmlIgnore()]
        public bool BaseSpecified { get; set; }

        [XmlIgnore()]
        public bool CombatSpecified { get; set; }

        [XmlIgnore()]
        public bool ElementSpecified { get; set; }

        [XmlElementAttribute("base")]
        public ItemPropertiesStateffectsBase Base
        {
            get
            {
                if ((_base == null))
                {
                    _base = new ItemPropertiesStateffectsBase();
                }
                return _base;
            }
            set
            {
                _base = value;
            }
        }

        [XmlElementAttribute("combat")]
        public ItemPropertiesStateffectsCombat Combat
        {
            get
            {
                if ((_combat == null))
                {
                    _combat = new ItemPropertiesStateffectsCombat();
                }
                return _combat;
            }
            set
            {
                _combat = value;
            }
        }

        [XmlElementAttribute("element")]
        public ItemPropertiesStateffectsElement Element
        {
            get
            {
                if ((_element == null))
                {
                    _element = new ItemPropertiesStateffectsElement();
                }
                return _element;
            }
            set
            {
                _element = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesStateffectsBase")]
    public partial class ItemPropertiesStateffectsBase
    {
        [XmlAttributeAttribute(AttributeName = "str")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        [VariantAttribute]
        public sbyte Str { get; set; }

        [XmlAttributeAttribute(AttributeName = "int")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        [VariantAttribute]
        public sbyte Int { get; set; }

        [XmlAttributeAttribute(AttributeName = "wis")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        [VariantAttribute]
        public sbyte Wis { get; set; }

        [XmlAttributeAttribute(AttributeName = "con")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        [VariantAttribute]
        public sbyte Con { get; set; }

        [XmlAttributeAttribute(AttributeName = "dex")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        [VariantAttribute]
        public sbyte Dex { get; set; }

        [XmlAttributeAttribute(AttributeName = "hp")]
        [DefaultValueAttribute(0)]
        [VariantAttribute]
        public int Hp { get; set; }

        [XmlAttributeAttribute(AttributeName = "mp")]
        [DefaultValueAttribute(0)]
        [VariantAttribute]
        public int Mp { get; set; }

        [XmlIgnore()]
        public bool StrSpecified { get; set; }

        [XmlIgnore()]
        public bool IntSpecified { get; set; }

        [XmlIgnore()]
        public bool WisSpecified { get; set; }

        [XmlIgnore()]
        public bool ConSpecified { get; set; }

        [XmlIgnore()]
        public bool DexSpecified { get; set; }

        [XmlIgnore()]
        public bool HpSpecified { get; set; }

        [XmlIgnore()]
        public bool MpSpecified { get; set; }

        public ItemPropertiesStateffectsBase()
        {
            Str = ((sbyte)(0));
            Int = ((sbyte)(0));
            Wis = ((sbyte)(0));
            Con = ((sbyte)(0));
            Dex = ((sbyte)(0));
            Hp = 0;
            Mp = 0;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesStateffectsCombat")]
    public partial class ItemPropertiesStateffectsCombat
    {
        [XmlAttributeAttribute(AttributeName = "hit")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        [VariantAttribute]
        public sbyte Hit { get; set; }

        [XmlAttributeAttribute(AttributeName = "dmg")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        [VariantAttribute]
        public sbyte Dmg { get; set; }

        [XmlAttributeAttribute(AttributeName = "ac")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        [VariantAttribute]
        public sbyte Ac { get; set; }

        [XmlAttributeAttribute(AttributeName = "regen")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        [VariantAttribute]
        public sbyte Regen { get; set; }

        [XmlAttributeAttribute(AttributeName = "mr")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        [VariantAttribute]
        public sbyte Mr { get; set; }

        [XmlIgnore()]
        public bool HitSpecified { get; set; }

        [XmlIgnore()]
        public bool DmgSpecified { get; set; }

        [XmlIgnore()]
        public bool AcSpecified { get; set; }

        [XmlIgnore()]
        public bool RegenSpecified { get; set; }

        [XmlIgnore()]
        public bool MrSpecified { get; set; }

        public ItemPropertiesStateffectsCombat()
        {
            Hit = ((sbyte)(0));
            Dmg = ((sbyte)(0));
            Ac = ((sbyte)(0));
            Regen = ((sbyte)(0));
            Mr = ((sbyte)(0));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesStateffectsElement")]
    public partial class ItemPropertiesStateffectsElement
    {
        [XmlAttributeAttribute(AttributeName = "offense")]
        [DefaultValueAttribute(Element.none)]
        [VariantOverride]
        public Element Offense { get; set; }

        [XmlAttributeAttribute(AttributeName = "defense")]
        [DefaultValueAttribute(Element.none)]
        [VariantOverride]
        public Element Defense { get; set; }

        [XmlIgnore()]
        public bool OffenseSpecified { get; set; }

        [XmlIgnore()]
        public bool DefenseSpecified { get; set; }

        public ItemPropertiesStateffectsElement()
        {
            Offense = Element.none;
            Defense = Element.none;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("Element")]
    public enum Element
    {
        /// <remarks/>
        none,

        /// <remarks/>
        fire,

        /// <remarks/>
        water,

        /// <remarks/>
        wind,

        /// <remarks/>
        earth,

        /// <remarks/>
        light,

        /// <remarks/>
        dark,

        /// <remarks/>
        wood,

        /// <remarks/>
        metal,

        /// <remarks/>
        undead,

        /// <remarks/>
        random,
    }

    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("ItemFlags")]
    public enum ItemFlags
    {
        /// <remarks/>
        bound = 1,

        /// <remarks/>
        depositable = 2,

        /// <remarks/>
        enchantable = 4,

        /// <remarks/>
        consecratable = 8,

        /// <remarks/>
        tailorable = 16,

        /// <remarks/>
        smithable = 32,

        /// <remarks/>
        exchangeable = 64,

        /// <remarks/>
        vendorable = 128,

        /// <remarks/>
        perishable = 256,

        /// <remarks/>
        unique = 512,

        [XmlEnumAttribute("unique-equipped")]
        uniqueequipped = 1024,

        /// <remarks/>
        master = 2048,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesVariants")]
    public partial class ItemPropertiesVariants
    {
        [XmlElementAttribute("name", ElementName = "name")]
        public List<string> Name { get; set; }

        [XmlElementAttribute("group", ElementName = "group")]
        public List<string> Group { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool GroupSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesVendor")]
    public partial class ItemPropertiesVendor
    {
        [XmlElementAttribute("description")]
        public string Description { get; set; }

        [XmlAttributeAttribute(AttributeName = "shoptab")]
        public sbyte Shoptab { get; set; }

        [XmlIgnore()]
        public bool DescriptionSpecified { get; set; }

        [XmlIgnore()]
        public bool ShoptabSpecified { get; set; }

        public ItemPropertiesVendor()
        {
            Description = "item";
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesDamage")]
    public partial class ItemPropertiesDamage
    {
        [VariantTraverse]
        private ItemPropertiesDamageSmall _small;

        [VariantTraverse]
        private ItemPropertiesDamageLarge _large;

        [XmlIgnore()]
        public bool SmallSpecified { get; set; }

        [XmlIgnore()]
        public bool LargeSpecified { get; set; }

        [XmlElementAttribute("small")]
        public ItemPropertiesDamageSmall Small
        {
            get
            {
                if ((_small == null))
                {
                    _small = new ItemPropertiesDamageSmall();
                }
                return _small;
            }
            set
            {
                _small = value;
            }
        }

        [XmlElementAttribute("large")]
        public ItemPropertiesDamageLarge Large
        {
            get
            {
                if ((_large == null))
                {
                    _large = new ItemPropertiesDamageLarge();
                }
                return _large;
            }
            set
            {
                _large = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesDamageSmall")]
    public partial class ItemPropertiesDamageSmall
    {
        [XmlAttributeAttribute(AttributeName = "min")]
        [DefaultValueAttribute(typeof(ushort), "0")]
        [VariantAttribute]
        public ushort Min { get; set; }

        [XmlAttributeAttribute(AttributeName = "max")]
        [DefaultValueAttribute(typeof(ushort), "0")]
        [VariantAttribute]
        public ushort Max { get; set; }

        [XmlIgnore()]
        public bool MinSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }

        public ItemPropertiesDamageSmall()
        {
            Min = ((ushort)(0));
            Max = ((ushort)(0));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesDamageLarge")]
    public partial class ItemPropertiesDamageLarge
    {
        [XmlAttributeAttribute(AttributeName = "min")]
        [DefaultValueAttribute(typeof(ushort), "0")]
        [VariantAttribute]
        public ushort Min { get; set; }

        [XmlAttributeAttribute(AttributeName = "max")]
        [DefaultValueAttribute(typeof(ushort), "0")]
        [VariantAttribute]
        public ushort Max { get; set; }

        [XmlIgnore()]
        public bool MinSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }

        public ItemPropertiesDamageLarge()
        {
            Min = ((ushort)(0));
            Max = ((ushort)(0));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesUse")]
    public partial class ItemPropertiesUse
    {
        private ItemPropertiesUseTeleport _teleport;

        private ItemPropertiesUsePlayerEffect _playerEffect;

        private ItemPropertiesUseEffect _effect;

        private ItemPropertiesUseSound _sound;

        [XmlElementAttribute("script")]
        public string Script { get; set; }

        [XmlAttributeAttribute(AttributeName = "consumed")]
        [DefaultValueAttribute(true)]
        public bool Consumed { get; set; }

        [XmlIgnore()]
        public bool ScriptSpecified { get; set; }

        [XmlIgnore()]
        public bool TeleportSpecified { get; set; }

        [XmlIgnore()]
        public bool PlayerEffectSpecified { get; set; }

        [XmlIgnore()]
        public bool EffectSpecified { get; set; }

        [XmlIgnore()]
        public bool SoundSpecified { get; set; }

        [XmlIgnore()]
        public bool ConsumedSpecified { get; set; }

        public ItemPropertiesUse()
        {
            Consumed = true;
        }

        [XmlElementAttribute("teleport")]
        public ItemPropertiesUseTeleport Teleport
        {
            get
            {
                if ((_teleport == null))
                {
                    _teleport = new ItemPropertiesUseTeleport();
                }
                return _teleport;
            }
            set
            {
                _teleport = value;
            }
        }

        [XmlElementAttribute("playereffect")]
        public ItemPropertiesUsePlayerEffect PlayerEffect
        {
            get
            {
                if ((_playerEffect == null))
                {
                    _playerEffect = new ItemPropertiesUsePlayerEffect();
                }
                return _playerEffect;
            }
            set
            {
                _playerEffect = value;
            }
        }

        [XmlElementAttribute("effect")]
        public ItemPropertiesUseEffect Effect
        {
            get
            {
                if ((_effect == null))
                {
                    _effect = new ItemPropertiesUseEffect();
                }
                return _effect;
            }
            set
            {
                _effect = value;
            }
        }

        [XmlElementAttribute("sound")]
        public ItemPropertiesUseSound Sound
        {
            get
            {
                if ((_sound == null))
                {
                    _sound = new ItemPropertiesUseSound();
                }
                return _sound;
            }
            set
            {
                _sound = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesUseTeleport")]
    public partial class ItemPropertiesUseTeleport
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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesUsePlayerEffect")]
    public partial class ItemPropertiesUsePlayerEffect
    {
        [XmlAttributeAttribute(AttributeName = "gold")]
        [DefaultValueAttribute(0)]
        public int Gold { get; set; }

        [XmlAttributeAttribute(AttributeName = "hp")]
        [DefaultValueAttribute(0)]
        public int Hp { get; set; }

        [XmlAttributeAttribute(AttributeName = "mp")]
        [DefaultValueAttribute(0)]
        public int Mp { get; set; }

        [XmlAttributeAttribute(AttributeName = "xp")]
        [DefaultValueAttribute(0)]
        public int Xp { get; set; }

        [XmlIgnore()]
        public bool GoldSpecified { get; set; }

        [XmlIgnore()]
        public bool HpSpecified { get; set; }

        [XmlIgnore()]
        public bool MpSpecified { get; set; }

        [XmlIgnore()]
        public bool XpSpecified { get; set; }

        public ItemPropertiesUsePlayerEffect()
        {
            Gold = 0;
            Hp = 0;
            Mp = 0;
            Xp = 0;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesUseEffect")]
    public partial class ItemPropertiesUseEffect
    {
        [XmlAttributeAttribute(AttributeName = "id")]
        public ushort Id { get; set; }

        [XmlAttributeAttribute(AttributeName = "speed")]
        [DefaultValueAttribute(typeof(sbyte), "100")]
        public sbyte Speed { get; set; }

        [XmlIgnore()]
        public bool IdSpecified { get; set; }

        [XmlIgnore()]
        public bool SpeedSpecified { get; set; }

        public ItemPropertiesUseEffect()
        {
            Speed = ((sbyte)(100));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesUseSound")]
    public partial class ItemPropertiesUseSound
    {
        [XmlAttributeAttribute(AttributeName = "id")]
        public sbyte Id { get; set; }

        [XmlIgnore()]
        public bool IdSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesRestrictions")]
    public partial class ItemPropertiesRestrictions
    {
        [VariantOverride]
        private ItemPropertiesRestrictionsLevel _level;

        [VariantOverride]
        private ItemPropertiesRestrictionsAB _ab;

        [XmlElementAttribute("class")]
        [VariantOverride]
        public Class Class { get; set; }

        [XmlIgnore]
        public bool ClassSpecified { get; set; }

        [DefaultValueAttribute(Gender.neutral)]
        [XmlElementAttribute("gender")]
        [VariantOverride]
        public Gender Gender { get; set; }

        [XmlIgnore()]
        public bool LevelSpecified { get; set; }

        [XmlIgnore()]
        public bool AbSpecified { get; set; }

        [XmlIgnore()]
        public bool GenderSpecified { get; set; }

        public ItemPropertiesRestrictions()
        {
            Gender = Gender.neutral;
        }

        [XmlElementAttribute("level")]
        public ItemPropertiesRestrictionsLevel Level
        {
            get
            {
                if ((_level == null))
                {
                    _level = new ItemPropertiesRestrictionsLevel();
                }
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        [XmlElementAttribute("ab")]
        public ItemPropertiesRestrictionsAB Ab
        {
            get
            {
                if ((_ab == null))
                {
                    _ab = new ItemPropertiesRestrictionsAB();
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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesRestrictionsLevel")]
    public partial class ItemPropertiesRestrictionsLevel
    {
        [XmlAttributeAttribute(AttributeName = "min")]
        [DefaultValueAttribute(typeof(byte), "0")]
        [VariantAttribute]
        public byte Min { get; set; }

        [XmlAttributeAttribute(AttributeName = "max")]
        [DefaultValueAttribute(typeof(byte), "255")]
        [VariantAttribute]
        public byte Max { get; set; }

        [XmlIgnore()]
        public bool MinSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }

        public ItemPropertiesRestrictionsLevel()
        {
            Min = ((byte)(0));
            Max = ((byte)(255));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("ItemPropertiesRestrictionsAB")]
    public partial class ItemPropertiesRestrictionsAB
    {
        [XmlAttributeAttribute(AttributeName = "min")]
        [DefaultValueAttribute(typeof(byte), "0")]
        [VariantAttribute]
        public byte Min { get; set; }

        [XmlAttributeAttribute(AttributeName = "max")]
        [DefaultValueAttribute(typeof(byte), "255")]
        [VariantAttribute]
        public byte Max { get; set; }

        [XmlIgnore()]
        public bool MinSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }

        public ItemPropertiesRestrictionsAB()
        {
            Min = ((byte)(0));
            Max = ((byte)(255));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("Class")]
    public enum Class
    {
        /// <remarks/>
        peasant,

        /// <remarks/>
        warrior,

        /// <remarks/>
        rogue,

        /// <remarks/>
        wizard,

        /// <remarks/>
        priest,

        /// <remarks/>
        monk,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("Gender")]
    public enum Gender
    {
        /// <remarks/>
        neutral,

        /// <remarks/>
        male,

        /// <remarks/>
        female,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("variantgroup", Namespace = "http://www.hybrasyl.com/XML/Items", IsNullable = false)]
    public partial class VariantGroupType
    {
        private List<VariantType> _variant;

        [XmlElementAttribute("name")]
        public string Name { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool VariantSpecified { get; set; }

        [XmlElementAttribute("variant", ElementName = "variant")]
        public List<VariantType> Variant
        {
            get
            {
                if ((_variant == null))
                {
                    _variant = new List<VariantType>();
                }
                return _variant;
            }
            set
            {
                _variant = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("variant", Namespace = "http://www.hybrasyl.com/XML/Items", IsNullable = false)]
    public partial class VariantType
    {
        private VariantProperties _properties;

        [XmlElementAttribute("name")]
        public string Name { get; set; }

        [XmlElementAttribute("modifier")]
        public string Modifier { get; set; }

        [XmlElementAttribute("comment")]
        public string Comment { get; set; }

        [XmlIgnore()]
        public bool NameSpecified { get; set; }

        [XmlIgnore()]
        public bool ModifierSpecified { get; set; }

        [XmlIgnore()]
        public bool CommentSpecified { get; set; }

        [XmlIgnore()]
        public bool PropertiesSpecified { get; set; }

        [XmlElementAttribute("properties")]
        public VariantProperties Properties
        {
            get
            {
                if ((_properties == null))
                {
                    _properties = new VariantProperties();
                }
                return _properties;
            }
            set
            {
                _properties = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantProperties")]
    public partial class VariantProperties
    {
        private VariantPropertiesAppearance _appearance;

        private VariantPropertiesDamage _damage;

        private VariantPropertiesPhysical _physical;

        private VariantPropertiesRestrictions _restrictions;

        private VariantPropertiesStackable _stackable;

        private VariantPropertiesStateffects _stateffects;

        [XmlElementAttribute("flags")]
        public ItemFlags Flags { get; set; }

        [XmlIgnore]
        public bool FlagsSpecified { get; set; }

        [XmlElementAttribute("script")]
        [VariantAttribute]
        public string Script { get; set; }

        [XmlIgnore()]
        public bool AppearanceSpecified { get; set; }

        [XmlIgnore()]
        public bool DamageSpecified { get; set; }

        [XmlIgnore()]
        public bool PhysicalSpecified { get; set; }

        [XmlIgnore()]
        public bool RestrictionsSpecified { get; set; }

        [XmlIgnore()]
        public bool ScriptSpecified { get; set; }

        [XmlIgnore()]
        public bool StackableSpecified { get; set; }

        [XmlIgnore()]
        public bool StateffectsSpecified { get; set; }

        [XmlElementAttribute("appearance")]
        public VariantPropertiesAppearance Appearance
        {
            get
            {
                if ((_appearance == null))
                {
                    _appearance = new VariantPropertiesAppearance();
                }
                return _appearance;
            }
            set
            {
                _appearance = value;
            }
        }

        [XmlElementAttribute("damage")]
        public VariantPropertiesDamage Damage
        {
            get
            {
                if ((_damage == null))
                {
                    _damage = new VariantPropertiesDamage();
                }
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }

        [XmlElementAttribute("physical")]
        public VariantPropertiesPhysical Physical
        {
            get
            {
                if ((_physical == null))
                {
                    _physical = new VariantPropertiesPhysical();
                }
                return _physical;
            }
            set
            {
                _physical = value;
            }
        }

        [XmlElementAttribute("restrictions")]
        public VariantPropertiesRestrictions Restrictions
        {
            get
            {
                if ((_restrictions == null))
                {
                    _restrictions = new VariantPropertiesRestrictions();
                }
                return _restrictions;
            }
            set
            {
                _restrictions = value;
            }
        }

        [XmlElementAttribute("stackable")]
        public VariantPropertiesStackable Stackable
        {
            get
            {
                if ((_stackable == null))
                {
                    _stackable = new VariantPropertiesStackable();
                }
                return _stackable;
            }
            set
            {
                _stackable = value;
            }
        }

        [XmlElementAttribute("stateffects")]
        public VariantPropertiesStateffects Stateffects
        {
            get
            {
                if ((_stateffects == null))
                {
                    _stateffects = new VariantPropertiesStateffects();
                }
                return _stateffects;
            }
            set
            {
                _stateffects = value;
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesAppearance")]
    public partial class VariantPropertiesAppearance
    {
        [XmlAttributeAttribute(AttributeName = "bodystyle")]
        public ItemBodystyle Bodystyle { get; set; }

        [XmlIgnore]
        public bool BodystyleSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "color")]
        public ItemColor Color { get; set; }

        [XmlIgnore]
        public bool ColorSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesDamage")]
    public partial class VariantPropertiesDamage
    {
        private VariantPropertiesDamageSmall _small;

        private VariantPropertiesDamageLarge _large;

        [XmlIgnore()]
        public bool SmallSpecified { get; set; }

        [XmlIgnore()]
        public bool LargeSpecified { get; set; }

        [XmlElementAttribute("small")]
        public VariantPropertiesDamageSmall Small
        {
            get
            {
                if ((_small == null))
                {
                    _small = new VariantPropertiesDamageSmall();
                }
                return _small;
            }
            set
            {
                _small = value;
            }
        }

        [XmlElementAttribute("large")]
        public VariantPropertiesDamageLarge Large
        {
            get
            {
                if ((_large == null))
                {
                    _large = new VariantPropertiesDamageLarge();
                }
                return _large;
            }
            set
            {
                _large = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesDamageSmall")]
    public partial class VariantPropertiesDamageSmall
    {
        [XmlAttributeAttribute(AttributeName = "min")]
        [DefaultValueAttribute(0)]
        public ushort Min { get; set; }

        [XmlAttributeAttribute(AttributeName = "max")]
        [DefaultValueAttribute(0)]
        public ushort Max { get; set; }

        [XmlIgnore()]
        public bool MinSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }

        public VariantPropertiesDamageSmall()
        {
            Min = 0;
            Max = 0;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesDamageLarge")]
    public partial class VariantPropertiesDamageLarge
    {
        [XmlAttributeAttribute(AttributeName = "min")]
        [DefaultValueAttribute(0)]
        public ushort Min { get; set; }

        [XmlAttributeAttribute(AttributeName = "max")]
        [DefaultValueAttribute(0)]
        public ushort Max { get; set; }

        [XmlIgnore()]
        public bool MinSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }

        public VariantPropertiesDamageLarge()
        {
            Min = 0;
            Max = 0;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesPhysical")]
    public partial class VariantPropertiesPhysical
    {
        [XmlAttributeAttribute(AttributeName = "value")]
        [DefaultValueAttribute(0)]
        public uint Value { get; set; }

        [XmlAttributeAttribute(AttributeName = "weight")]
        [DefaultValueAttribute(1)]
        public int Weight { get; set; }

        [XmlAttributeAttribute(AttributeName = "durability")]
        [DefaultValueAttribute(1)]
        public uint Durability { get; set; }

        [XmlAttributeAttribute(AttributeName = "perishable")]
        [DefaultValueAttribute(false)]
        public bool Perishable { get; set; }

        [XmlAttributeAttribute(AttributeName = "vendorable")]
        [DefaultValueAttribute(true)]
        public bool Vendorable { get; set; }

        [XmlAttributeAttribute(AttributeName = "bound")]
        [DefaultValueAttribute(false)]
        public bool Bound { get; set; }

        [XmlIgnore()]
        public bool ValueSpecified { get; set; }

        [XmlIgnore()]
        public bool WeightSpecified { get; set; }

        [XmlIgnore()]
        public bool DurabilitySpecified { get; set; }

        [XmlIgnore()]
        public bool PerishableSpecified { get; set; }

        [XmlIgnore()]
        public bool VendorableSpecified { get; set; }

        [XmlIgnore()]
        public bool BoundSpecified { get; set; }

        public VariantPropertiesPhysical()
        {
            Value = 0;
            Weight = 1;
            Durability = 1;
            Perishable = false;
            Vendorable = true;
            Bound = false;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesRestrictions")]
    public partial class VariantPropertiesRestrictions
    {
        private VariantPropertiesRestrictionsLevel _level;

        private VariantPropertiesRestrictionsAB _ab;

        [XmlElementAttribute("class")]
        public Class Class { get; set; }

        [XmlIgnore]
        public bool ClassSpecified { get; set; }

        [DefaultValueAttribute(Gender.neutral)]
        [XmlElementAttribute("gender")]
        public Gender Gender { get; set; }

        [XmlIgnore()]
        public bool LevelSpecified { get; set; }

        [XmlIgnore()]
        public bool AbSpecified { get; set; }

        [XmlIgnore()]
        public bool GenderSpecified { get; set; }

        public VariantPropertiesRestrictions()
        {
            Gender = Gender.neutral;
        }

        [XmlElementAttribute("level")]
        public VariantPropertiesRestrictionsLevel Level
        {
            get
            {
                if ((_level == null))
                {
                    _level = new VariantPropertiesRestrictionsLevel();
                }
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        [XmlElementAttribute("ab")]
        public VariantPropertiesRestrictionsAB Ab
        {
            get
            {
                if ((_ab == null))
                {
                    _ab = new VariantPropertiesRestrictionsAB();
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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesRestrictionsLevel")]
    public partial class VariantPropertiesRestrictionsLevel
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

        public VariantPropertiesRestrictionsLevel()
        {
            Min = (byte)0;
            Max = (byte)255;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesRestrictionsAB")]
    public partial class VariantPropertiesRestrictionsAB
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

        public VariantPropertiesRestrictionsAB()
        {
            Min = (byte)0;
            Max = (byte)255;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesStackable")]
    public partial class VariantPropertiesStackable
    {
        [XmlAttributeAttribute(AttributeName = "max")]
        public byte Max { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesStateffects")]
    public partial class VariantPropertiesStateffects
    {
        private VariantPropertiesStateffectsBase _base;

        private VariantPropertiesStateffectsCombat _combat;

        private VariantPropertiesStateffectsElement _element;

        [XmlIgnore()]
        public bool BaseSpecified { get; set; }

        [XmlIgnore()]
        public bool CombatSpecified { get; set; }

        [XmlIgnore()]
        public bool ElementSpecified { get; set; }

        [XmlElementAttribute("base")]
        public VariantPropertiesStateffectsBase Base
        {
            get
            {
                if ((_base == null))
                {
                    _base = new VariantPropertiesStateffectsBase();
                }
                return _base;
            }
            set
            {
                _base = value;
            }
        }

        [XmlElementAttribute("combat")]
        public VariantPropertiesStateffectsCombat Combat
        {
            get
            {
                if ((_combat == null))
                {
                    _combat = new VariantPropertiesStateffectsCombat();
                }
                return _combat;
            }
            set
            {
                _combat = value;
            }
        }

        [XmlElementAttribute("element")]
        public VariantPropertiesStateffectsElement Element
        {
            get
            {
                if ((_element == null))
                {
                    _element = new VariantPropertiesStateffectsElement();
                }
                return _element;
            }
            set
            {
                _element = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesStateffectsBase")]
    public partial class VariantPropertiesStateffectsBase
    {
        [XmlAttributeAttribute(AttributeName = "str")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Str { get; set; }

        [XmlAttributeAttribute(AttributeName = "int")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Int { get; set; }

        [XmlAttributeAttribute(AttributeName = "wis")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Wis { get; set; }

        [XmlAttributeAttribute(AttributeName = "con")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Con { get; set; }

        [XmlAttributeAttribute(AttributeName = "dex")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Dex { get; set; }

        [XmlAttributeAttribute(AttributeName = "hp")]
        [DefaultValueAttribute(0)]
        public int Hp { get; set; }

        [XmlAttributeAttribute(AttributeName = "mp")]
        [DefaultValueAttribute(0)]
        public int Mp { get; set; }

        [XmlIgnore()]
        public bool StrSpecified { get; set; }

        [XmlIgnore()]
        public bool IntSpecified { get; set; }

        [XmlIgnore()]
        public bool WisSpecified { get; set; }

        [XmlIgnore()]
        public bool ConSpecified { get; set; }

        [XmlIgnore()]
        public bool DexSpecified { get; set; }

        [XmlIgnore()]
        public bool HpSpecified { get; set; }

        [XmlIgnore()]
        public bool MpSpecified { get; set; }

        public VariantPropertiesStateffectsBase()
        {
            Str = (sbyte)0;
            Int = (sbyte)0;
            Wis = (sbyte)0;
            Con = (sbyte)0;
            Dex = (sbyte)0;
            Hp = 0;
            Mp = 0;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesStateffectsCombat")]
    public partial class VariantPropertiesStateffectsCombat
    {
        [XmlAttributeAttribute(AttributeName = "hit")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Hit { get; set; }

        [XmlAttributeAttribute(AttributeName = "dmg")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Dmg { get; set; }

        [XmlAttributeAttribute(AttributeName = "ac")]
        [DefaultValueAttribute(typeof(int), "0")]
        public int Ac { get; set; }

        [XmlAttributeAttribute(AttributeName = "regen")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Regen { get; set; }

        [XmlAttributeAttribute(AttributeName = "mr")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Mr { get; set; }

        [XmlIgnore()]
        public bool HitSpecified { get; set; }

        [XmlIgnore()]
        public bool DmgSpecified { get; set; }

        [XmlIgnore()]
        public bool AcSpecified { get; set; }

        [XmlIgnore()]
        public bool RegenSpecified { get; set; }

        [XmlIgnore()]
        public bool MrSpecified { get; set; }

        public VariantPropertiesStateffectsCombat()
        {
            Hit = ((sbyte)(0));
            Dmg = ((sbyte)(0));
            Ac = ((sbyte)(0));
            Regen = ((sbyte)(0));
            Mr = ((sbyte)(0));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Items")]
    [XmlRootAttribute("VariantPropertiesStateffectsElement")]
    public partial class VariantPropertiesStateffectsElement
    {
        [XmlAttributeAttribute(AttributeName = "offense")]
        [DefaultValueAttribute(Element.none)]
        public Element Offense { get; set; }

        [XmlAttributeAttribute(AttributeName = "defense")]
        [DefaultValueAttribute(Element.none)]
        public Element Defense { get; set; }

        [XmlIgnore()]
        public bool OffenseSpecified { get; set; }

        [XmlIgnore()]
        public bool DefenseSpecified { get; set; }

        public VariantPropertiesStateffectsElement()
        {
            Offense = Element.none;
            Defense = Element.none;
        }
    }
}

#pragma warning restore