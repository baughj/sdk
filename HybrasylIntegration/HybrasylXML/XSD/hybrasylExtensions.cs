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

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Hybrasyl.Items
{
    public partial class Item
    {
        [XmlIgnore]
        public bool IsVariant { get; set; }

        [XmlIgnore]
        public Item ParentItem { get; set; }

        [XmlIgnore]
        public bool Stackable
        {
            get { return Properties.Stackable != null; }
        }

        [XmlIgnore]
        public Variant CurrentVariant { get; set; }

        [XmlIgnore]
        public Dictionary<int, Item> Variants { get; set; }

        public int Id
        {
            get
            {
                unchecked
                {
                    if (Properties.Appearance.DisplaySprite > 0)
                    {
                        return 31*Name.GetHashCode()*(Properties.Restrictions.Gender.GetHashCode() + 1)*
                               Properties.Appearance.DisplaySprite.GetHashCode();
                    }
                    return 31*Name.GetHashCode()*(Properties.Restrictions.Gender.GetHashCode() + 1);
                }
            }
        }

        public Item Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Position = 0;
            object obj = bf.Deserialize(ms);
            ms.Close();
            return (Item)obj;
        }
    }
}

namespace Hybrasyl.Castables
{
    public partial class Castable
    {
        public int Id
        {
            get
            {
                unchecked
                {
                    return 31*(Name.GetHashCode() + 1);
                }
            }
        }

        public byte CastableLevel { get; set; }
    }
}
