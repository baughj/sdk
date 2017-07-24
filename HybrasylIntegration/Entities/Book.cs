using System;
using System.Collections;
using System.Collections.Generic;
using Hybrasyl.Castables;
using Hybrasyl.Items;

namespace Hybrasyl.Entities
{
    public class Book : IEnumerable<Castable>
    {
        public bool IsFull => Count == Size;

        public int EmptySlots => Size - Count;
        public int Size { get; }
        public int Count { get; set; }
        public Dictionary<int, Castable> ItemIndex { get; set; }
        public Castable[] Items { get; set; }

        public Castable this[byte slot]
        {
            get
            {
                var index = slot - 1;
                if (index < 0 || index >= Size)
                    return null;
                return Items[index];
            }
            set
            {
                var index = slot - 1;
                if (index < 0 || index >= Size) return;
                Items[index] = value;
            }
        }

        public Book()
        {
            Items = new Castable[90];
            Size = 90;
            ItemIndex = new Dictionary<int, Castable>();
        }

        public Book(int size)
        {
            Items = new Castable[size];
            Size = size;
            ItemIndex = new Dictionary<int, Castable>();
        }

        public IEnumerator<Castable> GetEnumerator()
        {
            for (var i = 0; i < Size; ++i)
            {
                if (Items[i] != null)
                    yield return Items[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public sealed class SkillBook : Book { }
    public sealed class SpellBook : Book { }

    public class Inventory : IEnumerable<Item>
    {
        public DateTime LastSaved { get; set; }

        public Item[] Items { get; set; }
        public Dictionary<int, List<Item>> InventoryIndex { get; set; }

        public int Size { get; private set; }
        public int Count { get; private set; }
        public int Weight { get; private set; }
        public Item Weapon => Items[(int)ServerItemSlots.Weapon];
        public Item Armor => Items[(int)ServerItemSlots.Armor];
        public Item Shield => Items[(int)ServerItemSlots.Shield];
        public Item Helmet => Items[(int)ServerItemSlots.Helmet];
        public Item Earring => Items[(int)ServerItemSlots.Earring];
        public Item Necklace => Items[(int)ServerItemSlots.Necklace];
        public Item LRing => Items[(int)ServerItemSlots.LHand];
        public Item RRing => Items[(int)ServerItemSlots.RHand];
        public Item LGauntlet => Items[(int)ServerItemSlots.LArm];
        public Item RGauntlet => Items[(int)ServerItemSlots.RArm];
        public Item Belt => Items[(int)ServerItemSlots.Waist];
        public Item Greaves => Items[(int)ServerItemSlots.Leg];
        public Item Boots => Items[(int)ServerItemSlots.Foot];
        public Item FirstAcc => Items[(int)ServerItemSlots.FirstAcc];
        public Item Overcoat => Items[(int)ServerItemSlots.Trousers];
        public Item DisplayHelm => Items[(int)ServerItemSlots.Coat];
        public Item SecondAcc => Items[(int)ServerItemSlots.SecondAcc];
        public Item ThirdAcc => Items[(int)ServerItemSlots.ThirdAcc];
        public bool IsFull => Count == Size;
        public int EmptySlots => Size - Count;

        public Inventory(int size)
        {
            Items = new Item[size];
            Size = size;
            InventoryIndex = new Dictionary<int, List<Item>>();
        }

        public Item this[byte slot]
        {
            get
            {
                var index = slot - 1;
                if (index < 0 || index >= Size) return null;
                return Items[index];
            }
            internal set
            {
                int index = slot - 1;
                if (index < 0 || index >= Size) return;
                Items[index] = value;
            }
        }

        public IEnumerator<Item> GetEnumerator()
        {
            for (var i = 0; i < Size; ++i)
            {
                if (Items[i] != null)
                    yield return Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
