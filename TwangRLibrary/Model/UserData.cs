using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwangRLibrary.Data;

namespace TwangRLibrary.Model
{
    public class UserData
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserRealName { get; set; }
        public string UserEmail { get; set; }
        public string UserNickName { get; set; }
        public string UserStatus { get; set; }

        public List<Chat> ActiveChats { get; set; }

        private readonly ITwangRRepo repo;

        public UserData() : this(new TwangRRepo()) { }
        public UserData(ITwangRRepo repo)
        {
            this.repo = repo;
        }

        public dynamic Login(string username, string password)
        {
            try
            {
                return repo.Login(username, password);
            }
            catch(BadLoginException BLE)
            {
                dynamic Error = new ExpandoObject();
                Error.status = BLE.Message;
                return Error;
            }
        }
    }
}
