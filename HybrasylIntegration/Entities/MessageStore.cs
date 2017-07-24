using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrasyl.Entities
{
    public class Message
    {

        public string Subject { get; set; }
        public string Body { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public DateTime Created { get; set; }
        public bool Highlighted { get; set; }
        public bool Deleted { get; set; }
        private bool _read;

        public bool Read
        {
            get { return _read; }
            set
            {
                _read = value;
                if (value == true)
                    ReadTime = DateTime.Now;
            }
        }

        public DateTime ReadTime { get; set; }
        public string Guid { get; private set; }
        public int Id { get; set; }

        public Message(string recipient, string sender, string subject, string body)
        {
            Created = DateTime.Now;
            Recipient = recipient;
            Sender = sender;
            Subject = subject;
            Body = body;
            Deleted = false;
            Highlighted = false;
            Guid = System.Guid.NewGuid().ToString();
            Read = false;
        }

    }

    public class MessageStoreLocked : Exception
    {
    }

    public class MessageStore
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public List<Message> Messages { get; set; }
        public string Guid { get; set; }
        public short CurrentId { get; set; }
        public int Id { get; set; }

        public bool Full => Messages.Count == short.MaxValue;
        private int _lock;
        public bool IsSaving;
        public bool IsLocked => _lock == 1;

        public MessageStore(string name, string displayName = "")
        {
            Name = name;
            IsSaving = false;
            Guid = System.Guid.NewGuid().ToString();
            CurrentId = 0;
            _lock = 0;
            Messages = new List<Message>();
            DisplayName = displayName != "" ? displayName : Name;
        }

        public string StorageKey => string.Concat(GetType(), ':', Name.ToLower());


    }
}
