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
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("castable", Namespace = "http://www.hybrasyl.com/XML/Actions", IsNullable = false)]
    public partial class Castable
    {
        private List<Element> _element;

        private List<Class> _class;

        [XmlElementAttribute("castcost", typeof(CastCost))]
        public CastCost CastCost { get; set; }

        [XmlElementAttribute("categories", typeof(Categories))]
        public Categories Categories { get; set; }

        [XmlElementAttribute("description", typeof(string))]
        public string Description { get; set; }

        [XmlElementAttribute("effects", typeof(Effects))]
        public Effects Effects { get; set; }

        [XmlElementAttribute("intents", typeof(Intents))]
        public Intents Intents { get; set; }

        [XmlElementAttribute("maxlevel", typeof(MaxLevel))]
        public MaxLevel MaxLevel { get; set; }

        [XmlElementAttribute("name", typeof(string))]
        public string Name { get; set; }

        [XmlElementAttribute("requirements", typeof(Requirements))]
        public Requirements Requirements { get; set; }

        [XmlElementAttribute("restrictions", typeof(Restrictions))]
        public Restrictions Restrictions { get; set; }

        [XmlAttributeAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttributeAttribute(AttributeName = "icon")]
        public sbyte Icon { get; set; }

        [XmlAttributeAttribute(AttributeName = "book")]
        public Book Book { get; set; }

        [XmlAttributeAttribute(AttributeName = "lines")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Lines { get; set; }

        [XmlAttributeAttribute(AttributeName = "cooldown")]
        [DefaultValueAttribute(0)]
        public int Cooldown { get; set; }

        [XmlAttributeAttribute(AttributeName = "isassail")]
        [DefaultValueAttribute("false")]
        public string Isassail { get; set; }

        [XmlIgnore()]
        public bool TypeSpecified { get; set; }

        [XmlIgnore()]
        public bool IconSpecified { get; set; }

        [XmlIgnore()]
        public bool BookSpecified { get; set; }

        [XmlIgnore()]
        public bool ElementSpecified { get; set; }

        [XmlIgnore()]
        public bool LinesSpecified { get; set; }

        [XmlIgnore()]
        public bool ClassSpecified { get; set; }

        [XmlIgnore()]
        public bool CooldownSpecified { get; set; }

        [XmlIgnore()]
        public bool IsassailSpecified { get; set; }

        public Castable()
        {
            Lines = ((sbyte)(0));
            Cooldown = 0;
            Isassail = "false";
        }

        [XmlAttributeAttribute(AttributeName = "element")]
        public List<Element> Element
        {
            get
            {
                if ((_element == null))
                {
                    _element = new List<Element>();
                }
                return _element;
            }
            set
            {
                _element = value;
            }
        }

        [XmlAttributeAttribute(AttributeName = "class")]
        public List<Class> Class
        {
            get
            {
                if ((_class == null))
                {
                    _class = new List<Class>();
                }
                return _class;
            }
            set
            {
                _class = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("CastCost")]
    public partial class CastCost
    {
        [XmlElementAttribute("gold", typeof(uint))]
        public uint Gold { get; set; }

        [XmlElementAttribute("items", typeof(ItemsSpecification))]
        public ItemsSpecification Items { get; set; }

        [XmlElementAttribute("stat", typeof(CastCostStat))]
        public CastCostStat Stat { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("ItemsSpecification")]
    public partial class ItemsSpecification
    {
        private List<ItemSpecification> _item;

        [XmlIgnore()]
        public bool ItemSpecified { get; set; }

        [XmlElementAttribute("item", ElementName = "item")]
        public List<ItemSpecification> Item
        {
            get
            {
                if ((_item == null))
                {
                    _item = new List<ItemSpecification>();
                }
                return _item;
            }
            set
            {
                _item = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("ItemSpecification")]
    public partial class ItemSpecification
    {
        [XmlAttributeAttribute(AttributeName = "quantity")]
        [DefaultValueAttribute(typeof(byte), "1")]
        public byte Quantity { get; set; }

        [XmlTextAttribute]
        public string Value { get; set; }

        [XmlIgnore()]
        public bool QuantitySpecified { get; set; }

        [XmlIgnore()]
        public bool ValueSpecified { get; set; }

        public ItemSpecification()
        {
            Quantity = ((byte)(1));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Restrictions")]
    public partial class Restrictions
    {
        [XmlIgnore()]
        public bool ItemsSpecified { get; set; }

        [XmlElementAttribute("equiptype", typeof(EquipmentSlot))]
        public EquipmentSlot EquipType { get; set; }

        [XmlElementAttribute("weapontype", typeof(WeaponType))]
        public WeaponType WeaponType { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Statuses")]
    public partial class Statuses
    {
        [XmlIgnore()]
        public bool ItemsSpecified { get; set; }

        [XmlElementAttribute("add", typeof(AddStatus))]
        public AddStatus Add { get; set; }

        [XmlElementAttribute("remove", typeof(string))]
        public string Remove { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("AddStatus")]
    public partial class AddStatus
    {
        [XmlAttributeAttribute(AttributeName = "modifier")]
        public float Modifier { get; set; }

        [XmlIgnore]
        public bool ModifierSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "damagetype")]
        public DamageType Damagetype { get; set; }

        [XmlIgnore]
        public bool DamagetypeSpecified { get; set; }

        [XmlAttributeAttribute(DataType = "token", AttributeName = "target")]
        public string Target { get; set; }

        [XmlTextAttribute]
        public StatusEffectsList Value { get; set; }

        [XmlIgnore()]
        public bool TargetSpecified { get; set; }

        [XmlIgnore()]
        public bool ValueSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("DamageType")]
    public enum DamageType
    {
        /// <remarks/>
        direct,

        /// <remarks/>
        physical,

        /// <remarks/>
        magical,

        /// <remarks/>
        elemental,
    }

    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/HybrasylCommon")]
    [XmlRootAttribute("StatusEffectsList")]
    public enum StatusEffectsList
    {
        /// <remarks/>
        freeze = 1,

        /// <remarks/>
        sleep = 2,

        /// <remarks/>
        paralyze = 4,

        /// <remarks/>
        blind = 8,

        /// <remarks/>
        skull = 16,

        /// <remarks/>
        poison = 32,

        /// <remarks/>
        mist = 64,

        /// <remarks/>
        regen = 128,

        /// <remarks/>
        sight = 256,

        /// <remarks/>
        invisible = 512,

        /// <remarks/>
        mute = 1024,

        /// <remarks/>
        reflectphysical = 2048,

        /// <remarks/>
        reflectmagical = 4096,

        /// <remarks/>
        invulnerable = 8192,

        /// <remarks/>
        charm = 16384,

        /// <remarks/>
        increasedamage = 32768,

        /// <remarks/>
        reducedamage = 65536,

        /// <remarks/>
        prohibitusage = 131072,

        /// <remarks/>
        absorbspell = 262144,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("StatEffects")]
    public partial class StatEffects
    {
        private List<StatEffect> _stateffect;

        [XmlIgnore()]
        public bool StateffectSpecified { get; set; }

        [XmlElementAttribute("stateffect", ElementName = "stateffect")]
        public List<StatEffect> Stateffect
        {
            get
            {
                if ((_stateffect == null))
                {
                    _stateffect = new List<StatEffect>();
                }
                return _stateffect;
            }
            set
            {
                _stateffect = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("StatEffect")]
    public partial class StatEffect
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

        [XmlAttributeAttribute(AttributeName = "hit")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Hit { get; set; }

        [XmlAttributeAttribute(AttributeName = "dmg")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Dmg { get; set; }

        [XmlAttributeAttribute(AttributeName = "ac")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Ac { get; set; }

        [XmlAttributeAttribute(AttributeName = "regen")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Regen { get; set; }

        [XmlAttributeAttribute(AttributeName = "mr")]
        [DefaultValueAttribute(typeof(sbyte), "0")]
        public sbyte Mr { get; set; }

        [XmlAttributeAttribute(AttributeName = "duration")]
        [DefaultValueAttribute(typeof(uint), "0")]
        public uint Duration { get; set; }

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

        [XmlIgnore()]
        public bool DurationSpecified { get; set; }

        public StatEffect()
        {
            Str = ((sbyte)(0));
            Int = ((sbyte)(0));
            Wis = ((sbyte)(0));
            Con = ((sbyte)(0));
            Dex = ((sbyte)(0));
            Hp = 0;
            Mp = 0;
            Hit = ((sbyte)(0));
            Dmg = ((sbyte)(0));
            Ac = ((sbyte)(0));
            Regen = ((sbyte)(0));
            Mr = ((sbyte)(0));
            Duration = ((uint)(0));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Effects")]
    public partial class Effects
    {
        [XmlAttributeAttribute(AttributeName = "duration")]
        public uint Duration { get; set; }

        [XmlIgnore]
        public bool DurationSpecified { get; set; }

        [XmlIgnore()]
        public bool ItemsSpecified { get; set; }

        [XmlElementAttribute("animations", typeof(Animations))]
        public Animations Animations { get; set; }

        [XmlElementAttribute("damage", typeof(Damage))]
        public Damage Damage { get; set; }

        [XmlElementAttribute("heal", typeof(Heal))]
        public Heal Heal { get; set; }

        [XmlElementAttribute("script", typeof(string))]
        public string Script { get; set; }

        [XmlElementAttribute("sound", typeof(EffectsSound))]
        public EffectsSound Sound { get; set; }

        [XmlElementAttribute("stateffects", typeof(StatEffects))]
        public StatEffects StatEffects { get; set; }

        [XmlElementAttribute("statuses", typeof(Statuses))]
        public Statuses Statuses { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Animations")]
    public partial class Animations
    {
        [XmlElementAttribute("duration", typeof(AnimationDurationGroup))]
        public AnimationDurationGroup Duration { get; set; }

        [XmlElementAttribute("end", typeof(AnimationGroup))]
        public AnimationGroup End { get; set; }

        [XmlElementAttribute("oncast", typeof(AnimationGroup))]
        public AnimationGroup OnCast { get; set; }

        [XmlIgnore()]
        public bool ItemsSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("AnimationDurationGroup")]
    public partial class AnimationDurationGroup
    {
        [XmlElementAttribute("player", typeof(AnimationDuration))]
        public AnimationDuration Player { get; set; }

        [XmlElementAttribute("spelleffect", typeof(AnimationDuration))]
        public AnimationDuration SpellEffect { get; set; }

        [XmlElementAttribute("target", typeof(AnimationDuration))]
        public AnimationDuration Target { get; set; }

        [XmlIgnore()]
        public bool ItemsSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("AnimationDuration")]
    public partial class AnimationDuration
    {
        [XmlAttributeAttribute(AttributeName = "id")]
        public ushort Id { get; set; }

        [XmlAttributeAttribute(AttributeName = "speed")]
        [DefaultValueAttribute(typeof(ushort), "100")]
        public ushort Speed { get; set; }

        [XmlAttributeAttribute(AttributeName = "every")]
        public uint Every { get; set; }

        [XmlIgnore]
        public bool EverySpecified { get; set; }

        [XmlIgnore()]
        public bool IdSpecified { get; set; }

        [XmlIgnore()]
        public bool SpeedSpecified { get; set; }

        public AnimationDuration()
        {
            Speed = ((ushort)(100));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("AnimationGroup")]
    public partial class AnimationGroup
    {
        [XmlElementAttribute("motion", typeof(Animation))]
        public Animation Motion { get; set; }

        [XmlElementAttribute("spelleffect", typeof(Animation))]
        public Animation SpellEffect { get; set; }

        [XmlElementAttribute("target", typeof(Animation))]
        public Animation Target { get; set; }

        [XmlIgnore()]
        public bool ItemsSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Animation")]
    public partial class Animation
    {
        [XmlAttributeAttribute(AttributeName = "id")]
        public ushort Id { get; set; }

        [XmlAttributeAttribute(AttributeName = "speed")]
        [DefaultValueAttribute(typeof(ushort), "100")]
        public ushort Speed { get; set; }

        [XmlIgnore()]
        public bool IdSpecified { get; set; }

        [XmlIgnore()]
        public bool SpeedSpecified { get; set; }

        public Animation()
        {
            Speed = ((ushort)(100));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Damage")]
    public partial class Damage
    {
        [XmlAttributeAttribute(AttributeName = "overtime")]
        public bool Overtime { get; set; }

        [XmlIgnore]
        public bool OvertimeSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "type")]
        public DamageType Type { get; set; }

        [XmlIgnore]
        public bool TypeSpecified { get; set; }

        [XmlIgnore()]
        public bool ItemsSpecified { get; set; }

        [XmlElementAttribute("flags", typeof(DamageFlags))]
        public DamageFlags Flags { get; set; }

        [XmlElementAttribute("formula", typeof(string))]
        public string Formula { get; set; }

        [XmlElementAttribute("simple", typeof(SimpleQuantity))]
        public SimpleQuantity Simple { get; set; }
    }

    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("DamageFlags")]
    public enum DamageFlags
    {
        /// <remarks/>
        scaled = 1,

        /// <remarks/>
        resistance = 2,

        /// <remarks/>
        threat = 4,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("SimpleQuantity")]
    public partial class SimpleQuantity
    {
        [XmlAttributeAttribute(DataType = "nonNegativeInteger", AttributeName = "min")]
        [DefaultValueAttribute("0")]
        public string Min { get; set; }

        [XmlAttributeAttribute(DataType = "nonNegativeInteger", AttributeName = "max")]
        [DefaultValueAttribute("0")]
        public string Max { get; set; }

        [XmlIgnore()]
        public bool MinSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxSpecified { get; set; }

        public SimpleQuantity()
        {
            Min = "0";
            Max = "0";
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Heal")]
    public partial class Heal
    {
        [XmlElementAttribute("formula", typeof(string))]
        public string Formula { get; set; }

        [XmlElementAttribute("simple", typeof(SimpleQuantity))]
        public SimpleQuantity Simple { get; set; }

        [XmlAttributeAttribute(AttributeName = "overtime")]
        public bool Overtime { get; set; }

        [XmlIgnore]
        public bool OvertimeSpecified { get; set; }

        [XmlIgnore()]
        public bool ItemSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("EffectsSound")]
    public partial class EffectsSound
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
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("HealthChange")]
    public partial class HealthChange
    {
        [XmlElementAttribute("formula", typeof(string))]
        public string Formula { get; set; }

        [XmlElementAttribute("simple", typeof(SimpleQuantity))]
        public SimpleQuantity Simple { get; set; }

        [XmlIgnore()]
        public bool ItemSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Requirements")]
    public partial class Requirements
    {
        [XmlIgnore()]
        public bool ItemsSpecified { get; set; }

        [XmlElementAttribute("ab", typeof(RequirementsAB))]
        public RequirementsAB AB { get; set; }

        [XmlElementAttribute("gold", typeof(uint))]
        public uint Gold { get; set; }

        [XmlElementAttribute("items", typeof(ItemsSpecification))]
        public ItemsSpecification Items { get; set; }

        [XmlElementAttribute("level", typeof(RequirementsLevel))]
        public RequirementsLevel Level { get; set; }

        [XmlElementAttribute("physical", typeof(RequirementsPhysical))]
        public RequirementsPhysical Physical { get; set; }

        [XmlElementAttribute("prerequisites", typeof(LearnPrerequisites))]
        public LearnPrerequisites Prerequisites { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("RequirementsAB")]
    public partial class RequirementsAB
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

        public RequirementsAB()
        {
            Min = ((byte)(0));
            Max = ((byte)(255));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("RequirementsLevel")]
    public partial class RequirementsLevel
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

        public RequirementsLevel()
        {
            Min = ((byte)(0));
            Max = ((byte)(255));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("RequirementsPhysical")]
    public partial class RequirementsPhysical
    {
        [XmlAttributeAttribute(AttributeName = "str")]
        [DefaultValueAttribute(typeof(byte), "0")]
        public byte Str { get; set; }

        [XmlAttributeAttribute(AttributeName = "int")]
        [DefaultValueAttribute(typeof(byte), "0")]
        public byte Int { get; set; }

        [XmlAttributeAttribute(AttributeName = "wis")]
        [DefaultValueAttribute(typeof(byte), "0")]
        public byte Wis { get; set; }

        [XmlAttributeAttribute(AttributeName = "con")]
        [DefaultValueAttribute(typeof(byte), "0")]
        public byte Con { get; set; }

        [XmlAttributeAttribute(AttributeName = "dex")]
        [DefaultValueAttribute(typeof(byte), "0")]
        public byte Dex { get; set; }

        [XmlAttributeAttribute(AttributeName = "hp")]
        [DefaultValueAttribute(typeof(uint), "0")]
        public uint Hp { get; set; }

        [XmlAttributeAttribute(AttributeName = "mp")]
        [DefaultValueAttribute(typeof(uint), "0")]
        public uint Mp { get; set; }

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

        public RequirementsPhysical()
        {
            Str = ((byte)(0));
            Int = ((byte)(0));
            Wis = ((byte)(0));
            Con = ((byte)(0));
            Dex = ((byte)(0));
            Hp = ((uint)(0));
            Mp = ((uint)(0));
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("LearnPrerequisites")]
    public partial class LearnPrerequisites
    {
        private List<LearnPrerequisite> _prerequisite;

        [XmlIgnore()]
        public bool PrerequisiteSpecified { get; set; }

        [XmlElementAttribute("prerequisite", ElementName = "prerequisite")]
        public List<LearnPrerequisite> Prerequisite
        {
            get
            {
                if ((_prerequisite == null))
                {
                    _prerequisite = new List<LearnPrerequisite>();
                }
                return _prerequisite;
            }
            set
            {
                _prerequisite = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("LearnPrerequisite")]
    public partial class LearnPrerequisite
    {
        [XmlAttributeAttribute(AttributeName = "level")]
        public byte Level { get; set; }

        [XmlIgnore]
        public bool LevelSpecified { get; set; }

        [XmlTextAttribute]
        public string Value { get; set; }

        [XmlIgnore()]
        public bool ValueSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("MaxLevel")]
    public partial class MaxLevel
    {
        [XmlAttributeAttribute(AttributeName = "monk")]
        public byte Monk { get; set; }

        [XmlIgnore]
        public bool MonkSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "warrior")]
        public byte Warrior { get; set; }

        [XmlIgnore]
        public bool WarriorSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "peasant")]
        public byte Peasant { get; set; }

        [XmlIgnore]
        public bool PeasantSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "wizard")]
        public byte Wizard { get; set; }

        [XmlIgnore]
        public bool WizardSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "priest")]
        public byte Priest { get; set; }

        [XmlIgnore]
        public bool PriestSpecified { get; set; }

        [XmlAttributeAttribute(AttributeName = "rogue")]
        public byte Rogue { get; set; }

        [XmlIgnore]
        public bool RogueSpecified { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Intents")]
    public partial class Intents
    {
        private List<Intent> _intent;

        [XmlIgnore()]
        public bool IntentSpecified { get; set; }

        [XmlElementAttribute("intent", ElementName = "intent")]
        public List<Intent> Intent
        {
            get
            {
                if ((_intent == null))
                {
                    _intent = new List<Intent>();
                }
                return _intent;
            }
            set
            {
                _intent = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Intent")]
    public partial class Intent
    {
        private List<IntentTarget> _target;

        [XmlAttributeAttribute(AttributeName = "isclick")]
        [DefaultValueAttribute(false)]
        public bool Isclick { get; set; }

        [XmlAttributeAttribute(AttributeName = "radius")]
        [DefaultValueAttribute(typeof(byte), "0")]
        public byte Radius { get; set; }

        [XmlAttributeAttribute(AttributeName = "direction")]
        [DefaultValueAttribute(IntentDirection.front)]
        public IntentDirection Direction { get; set; }

        [XmlAttributeAttribute(AttributeName = "maxtargets")]
        [DefaultValueAttribute(typeof(byte), "0")]
        public byte Maxtargets { get; set; }

        [XmlIgnore()]
        public bool IsclickSpecified { get; set; }

        [XmlIgnore()]
        public bool RadiusSpecified { get; set; }

        [XmlIgnore()]
        public bool DirectionSpecified { get; set; }

        [XmlIgnore()]
        public bool TargetSpecified { get; set; }

        [XmlIgnore()]
        public bool MaxtargetsSpecified { get; set; }

        public Intent()
        {
            Isclick = false;
            Radius = ((byte)(0));
            Direction = IntentDirection.front;
            Maxtargets = ((byte)(0));
        }

        [XmlAttributeAttribute(AttributeName = "target")]
        public List<IntentTarget> Target
        {
            get
            {
                if ((_target == null))
                {
                    _target = new List<IntentTarget>();
                }
                return _target;
            }
            set
            {
                _target = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("IntentDirection")]
    public enum IntentDirection
    {
        /// <remarks/>
        front,

        /// <remarks/>
        back,

        /// <remarks/>
        left,

        /// <remarks/>
        right,

        /// <remarks/>
        nearby,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("IntentTarget")]
    public enum IntentTarget
    {
        /// <remarks/>
        hostile,

        /// <remarks/>
        friendly,

        /// <remarks/>
        pvp,

        /// <remarks/>
        group,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Categories")]
    public partial class Categories
    {
        private List<object> _category;

        [XmlIgnore()]
        public bool CategorySpecified { get; set; }

        [XmlElementAttribute("category", ElementName = "category")]
        public List<object> Category
        {
            get
            {
                if ((_category == null))
                {
                    _category = new List<object>();
                }
                return _category;
            }
            set
            {
                _category = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("CastCostStat")]
    public partial class CastCostStat
    {
        [XmlAttributeAttribute(AttributeName = "hp")]
        [DefaultValueAttribute("0")]
        public string Hp { get; set; }

        [XmlAttributeAttribute(AttributeName = "mp")]
        [DefaultValueAttribute("0")]
        public string Mp { get; set; }

        [XmlIgnore()]
        public bool HpSpecified { get; set; }

        [XmlIgnore()]
        public bool MpSpecified { get; set; }

        public CastCostStat()
        {
            Hp = "0";
            Mp = "0";
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1038.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.hybrasyl.com/XML/Actions")]
    [XmlRootAttribute("Book")]
    public enum Book
    {
        /// <remarks/>
        primaryskill,

        /// <remarks/>
        secondaryskill,

        /// <remarks/>
        utilityskill,

        /// <remarks/>
        primaryspell,

        /// <remarks/>
        secondaryspell,

        /// <remarks/>
        utilityspell,
    }
}

#pragma warning restore