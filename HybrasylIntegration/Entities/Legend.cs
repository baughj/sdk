using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hybrasyl.Entities
{
    public class Legend : IEnumerable<LegendMark>
    {
        public const int MaximumLegendSize = 254;
        public SortedDictionary<DateTime, LegendMark> Entries { get; set; }

        public Dictionary<string, LegendMark> LegendIndex { get; set; }

        public int Count => Entries.Count;

        public Legend()
        {
            Entries = new SortedDictionary<DateTime, LegendMark>();
            LegendIndex = new Dictionary<string, LegendMark>();
        }

        public IEnumerator<LegendMark> GetEnumerator()
        {
            return Entries.Values.ToList().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
    public class LegendMark
    {
        public string Prefix { get; set; }
        public LegendColor Color { get; set; }
        public LegendIcon Icon { get; set; }
        public string Text { get; set; }
        public bool Public { get; set; }
        public DateTime Created { get; }
        public DateTime LastUpdated { get; set; }
        public int Quantity { get; set; }

        public LegendMark(LegendIcon icon, LegendColor color, string text, DateTime created,
            string prefix = default(string), bool isPublic = true, int quantity = 0)
        {
            Icon = icon;
            Color = color;
            Text = text;
            Public = isPublic;
            Quantity = quantity;
            Prefix = prefix;
            Created = created;
            LastUpdated = created;
        }
    }
}
