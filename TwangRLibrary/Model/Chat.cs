using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwangRLibrary.Data;

namespace TwangRLibrary.Model
{
    public class Chat
    {
        public string ChatId { get; set; }
        public List<int> Participants { get; set; }

        private readonly ITwangRRepo repo;

        public Chat() : this(new TwangRRepo()) { }
        public Chat(ITwangRRepo repo)
        {
            this.repo = repo;
            Participants = new List<int>();
        }
    }
}
