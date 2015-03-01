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
                StatusAuthorID = StatusDB.StatusAuthorID,
                StatusAuthor = StatusDB.StatusAuthor,
                StatusContent = StatusDB.StatusContent,
                StatusLikes = StatusDB.StatusLikes,
                LogDate = StatusDB.Logdate.ToString()
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

        public string InsertStatus(Status status)
        {
            try
            {
                _dataContext.TwangR_data_insertnewpost(status.StatusContent, status.StatusAuthorID);
                return "Passed";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        public void UpdateStatus(Status status)
        {
            throw new NotImplementedException();
        }

        public List<UserData> GetUsersByName(string QueryText)
        {
            return LoginDbToUserData(_dataContext.Twangr_user_getusersbyname(QueryText).ToList());
        }

        public UserData GetUserById(int UserId)
        {
            return LoginDbToUserData(_dataContext.Twangr_user_getuserbyid(UserId).ToList()).FirstOrDefault();
        }

        public List<UserData> GetFriendsList(int UserId)
        {
            return LoginDbToUserData(_dataContext.TwangR_user_GetFriendList(UserId).ToList());
        }

        public List<UserData> GetFriendRequests(int UserId)
        {
            return LoginDbToUserData(_dataContext.TwangR_user_getpendingfriendrequests(UserId).ToList());
        }

        public void LogFriendRequest(int Sender, int Reciever)
        {
            _dataContext.TwangR_data_logfriendrequest(Sender, Reciever);
        }

        public void AcceptFriendRequest(int Sender, int Reciever)
        {
            _dataContext.TwangR_data_acceptfriendrequest(Sender, Reciever);
        }

        public void DeclineFriendRequest(int Sender, int Reciever)
        {
            _dataContext.TwangR_data_declinefriendrequest(Sender, Reciever);
        }
    }
}
