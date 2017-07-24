using System.Collections.Generic;
using C3;

namespace Hybrasyl.Entities
{
    public class Map
    {
        
        public byte Flags { get; set; }
        //public byte Music { get; set; }
        public byte[] RawData { get; set; }
        public ushort Checksum { get; set; }
        public bool[,] IsWall { get; set; }

        
        public string Message { get; set; }

        public QuadTree<VisibleObject> EntityTree { get; set; }

        public HashSet<VisibleObject> Objects { get; private set; }
        public Dictionary<string, User> Users { get; private set; }

        

        public Map()
        {
            Users = new Dictionary<string, User>();
            Objects = new HashSet<VisibleObject>();
        }

    }

    public class Location
    {
        public ushort MapId { get; set; }
        public Direction Direction { get; set; }
        public byte X { get; set; }
        public byte Y { get; set; }
        public bool WorldMap { get; set; }
    }
}
