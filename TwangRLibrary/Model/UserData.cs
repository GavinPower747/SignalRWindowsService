using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwangRLibrary.Model
{
    public class UserData
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }

        public List<Chat> ActiveChats { get; set; }
    }
}
