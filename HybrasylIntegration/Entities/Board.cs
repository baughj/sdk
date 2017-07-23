using System.Collections.Generic;

namespace Hybrasyl.Entities
{
    public enum BoardAccessLevel
    {
        Read,
        Write,       // N.B. Write implies read
        Moderate,    // Moderator implies r/w access
    };

    public class Board : MessageStore
    {
        public bool Global { get; set; }
        public HashSet<string> ModeratorList { get; set; }
        public HashSet<string> ReaderList { get; set; }
        public HashSet<string> WriterList { get; set; }
        public HashSet<string> BlockList { get; set; }

        public Board(string name) : base(name)
        {
            Global = false;
        }
    }
}
