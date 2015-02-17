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
                throw new UserException(status);

            return users[0];
        }

        private List<UserData> LoginDbToUserData(IEnumerable<LoginDB> logindb)
        {
            return logindb.Select(login => new UserData { 
                UserId = login.UserID,
                UserName = login.UserName,
                UserPassword = login.PasswordHash,
                UserEmail = login.UserEmail,
                UserNickName = login.UserNickName,
                UserRealName = login.UserRealName
            }).ToList();
        }

        public UserData Register(UserData data) 
        {
            string status = "";
            List<UserData> users = LoginDbToUserData(_dataContext.TwangR_user_register(data.UserName, data.UserPassword, data.UserRealName, data.UserEmail, data.UserNickName, ref status));

            if (!status.Equals("Successful"))
                throw new UserException(status);

            return users[0];
        }

        public List<Status> StatusDBToStatus(IEnumerable<StatusDB> StatusDBs)
        {
            return StatusDBs.Select(StatusDB => new Status
            {
                StatusId = StatusDB.StatusID,
                StatusAuthor = StatusDB.StatusAuthor,
                StatusContent = StatusDB.StatusContent,
                StatusLikes = StatusDB.StatusLikes,
                LogDate = StatusDB.LogDate.ToString()
            }).ToList();
        }

        public List<Status> GetNewsFeed(int UserId)
        {
            return StatusDBToStatus(_dataContext.TwangR_data_getnewsfeed(UserId));
        }

        public List<Status> GetAllPostsByUser(int UserId)
        {
            return StatusDBToStatus(_dataContext.TwangR_data_getallpostsbyuser(UserId));
        }

        public void InsertStatus(Status status)
        {
            _dataContext.TwangR_data_insertnewpost(status.StatusContent, status.StatusAuthor);
        }

        public void UpdateStatus(Status status)
        {
            throw new NotImplementedException();
        }
    }
}
