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
        public string messageID {get; set;}
        public string sender { get; set; }
        public string message { get; set; }
        public bool isSelf { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ChatId { get; set; }

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
