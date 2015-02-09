using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwangRLibrary.Model
{
    public class Chat
    {
        public string ChatId { get; set; }
        public List<UserData> Participants { get; set; }
    }
}
