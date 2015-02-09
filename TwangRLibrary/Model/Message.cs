using TwangRLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwangRLibrary.Model
{
    public class Message
    {
        public String messageID {get; set; }
        public String sender { get; set; }
        public String message { get; set; }
        public bool isSelf { get; set; }
        public DateTime TimeStamp { get; set; }

        private readonly ITwangRRepo repo;

        public Message() : this(new TwangRRepo()) { }
        public Message(ITwangRRepo repo)
        {
            this.repo = repo;
        }

        public void LogMessage(Message message)
        {
            repo.LogMessage(message);
        }
    }
}
