using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwangRLibrary.Model;

namespace TwangRLibrary.Data
{
    public class TwangRRepo : ITwangRRepo
    {
        private TwangRDataContext _dataContext = new TwangRDataContext();

        public void LogMessage(Message message) { }

        public UserData Login(string username, string password)
        {
            string status = "";
            List<UserData> users = LoginDbToUserData(_dataContext.TwangR_user_login(username, password, ref status));

            if (!status.Equals("Successful"))
                throw new BadLoginException(status);

            return users[0];
        }

        private List<UserData> LoginDbToUserData(IEnumerable<LoginDB> logindb)
        {
            return logindb.Select(login => new UserData { 
                UserId = login.UserID,
                UserName = login.UserName,
                UserPassword = login.PasswordHash,
                UserEmail = login.UserEmail,
                UserNickName = login.UserEmail,
                UserRealName = login.UserRealName
            }).ToList();
        }

        public string Register(UserData data) { return "Implement Me"; }
    }
}
