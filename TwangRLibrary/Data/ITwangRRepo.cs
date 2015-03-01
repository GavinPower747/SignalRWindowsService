using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwangRLibrary.Model;

namespace TwangRLibrary.Data
{
    public interface ITwangRRepo
    {
        void LogMessage(Message message);
        void LogFriendRequest(int Sender, int Reciever);
        void AcceptFriendRequest(int Sender, int Reciever);
        void DeclineFriendRequest(int Sender, int Reciever);
        UserData Login(string username, string password);
        UserData Register(UserData data);
        UserData GetUserById(int userId);
        List<Status> GetNewsFeed(int UserId);
        List<Status> GetAllPostsByUser(int UserId);
        string InsertStatus(Status status);
        void UpdateStatus(Status status);
        List<UserData> GetUsersByName(string QueryText);
        List<UserData> GetFriendsList(int UserId);
        List<UserData> GetFriendRequests(int UserId);
    }
}
