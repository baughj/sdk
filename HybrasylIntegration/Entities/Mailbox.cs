using System.Linq;

namespace Hybrasyl.Entities
{
    public class Mailbox : MessageStore
    {
        public bool HasUnreadMessages
        {
            get { return Messages.Any(m => m.Read == false); }
        }

        public Mailbox(string name) : base(name)
        {
            
        }
    }
}
