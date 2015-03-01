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
            catch(UserException UE)
            {
                dynamic Error = new ExpandoObject();
                Error.status = UE.Message;
                return Error;
            }
        }

        public dynamic Register(UserData user)
        {
            try
            {
                return repo.Register(user);
            }
            catch(UserException UE)
            {
                dynamic Error = new ExpandoObject();
                Error.status = UE.Message;
                return Error;
            }
        }

        public UserData GetUserById(int userId)
        {
            return repo.GetUserById(userId);
        }

        public void LogFriendRequest(int Sender, int Reciever)
        {
            repo.LogFriendRequest(Sender, Reciever);
        }

        public void AcceptFriendRequest(int Sender, int Reciever)
        {
            repo.AcceptFriendRequest(Sender, Reciever);
        }

        public void DeclineFriendRequest(int sender, int reciever)
        {
            repo.DeclineFriendRequest(sender, reciever);
        }
    }
}
