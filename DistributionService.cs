using System.ServiceProcess;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin;
using SignalRWindowsService.Model;
using System.Collections.Concurrent;
using System;
using TwangRLibrary.Model;
using System.Dynamic;
using System.Collections.Generic;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(SignalRWindowsService.Startup))]
namespace SignalRWindowsService
{
    public partial class DistributionService : ServiceBase
    {
        
        public DistributionService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            if (!System.Diagnostics.EventLog.SourceExists("DistributionService"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "DistributionService", "Application");
            }
            eventLog1.Source = "DistributionService";
            eventLog1.Log = "Application";

            eventLog1.WriteEntry("In OnStart");
            string url = "http://37.187.35.32:8081";
            WebApp.Start(url);
            
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In OnStop");
        }
    }

    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR(new HubConfiguration { EnableJSONP = true });
        }
    }
    public class DistributionHub : Hub
    {
        public static ConcurrentDictionary<int, string> ConnectionStringList = new ConcurrentDictionary<int, string>();
        public static ConcurrentDictionary<string, UserData> UserDataList = new ConcurrentDictionary<string, UserData>();
        public static ConcurrentDictionary<string, List<int>> Chats = new ConcurrentDictionary<string, List<int>>();
        public static int ChatID = 0;
        /*--------------------------------------------------------------------------------------------------------------------*/
        public void GetBills()
        {
            Bills Bills = new Bills();
            Bills.GetAllBills();
            Clients.Caller.displayBills(Bills);
        }

        /*--------------------------------------------------TwangR Functions--------------------------------------------------*/

        public override Task OnDisconnected(bool stopCalled)
        {
            UserData user = new UserData();
            if (UserDataList.TryGetValue(Context.ConnectionId, out user))
                LeaveRealTime();

            return base.OnDisconnected(stopCalled);
        }

        public void JoinRealTime(UserData user)
        {
            ConnectionStringList.TryAdd(user.UserId, Context.ConnectionId);
            UserDataList.TryAdd(Context.ConnectionId, user);
        }

        public void LeaveRealTime()
        {
            UserData user = new UserData();
            string ConnectionId;
            UserDataList.TryRemove(Context.ConnectionId, out user);
            ConnectionStringList.TryRemove(user.UserId, out ConnectionId);
            Clients.All.refreshFriendsList();
        }

        public Message Send(string MessageID, string messageUp, string sender, bool isSelf, string ChatId)
        {
            Message message = new Message();
            message.messageID = MessageID;
            message.sender = sender;
            message.message = messageUp;
            message.isSelf = isSelf;
            List<string> recipients = new List<string>();

            Parallel.ForEach(Chats, chat => { 
                if(chat.Key.Equals(ChatID))
                {
                    foreach(int user in chat.Value)
                    {
                        recipients.Add(ConnectionIdByUserId(user));
                    }
                }
            });

            Clients.Clients(recipients).addMessage(message, ChatId);
            return message;
        }

        public string AddChat(int chatter, int chatee)
        {
            ChatID++;
            Chats.TryAdd("Chat" + ChatID, new List<int>() { chatter, chatee } );
            return "Chat" + ChatID;
        }

        public List<string> GetChats(int UserId)
        {
            List<string> chats = new List<string>();

            Parallel.ForEach(Chats, chat =>
            {
                if (chat.Value.Contains(UserId))
                    chats.Add(chat.Key);
            });

            return chats;
        }

        public void Login(string Username, string Password)
        {
            dynamic user = new UserData();
            user = user.Login(Username, Password);

            if (user is UserData)
            {
                Clients.Caller.loginSuccess(user.UserId, user.UserName, user.UserRealName, user.UserEmail, user.UserNickName);
                JoinRealTime(user);
            }
            else
            {
                string status = user.status;
                Clients.Caller.loginFailure(status);
            }
        }

        public void Register(string userName, string userPassword, string userRealName, string userEmail, string userNickName)
        {
            dynamic user = new UserData();
            user.UserName = userName;
            user.UserPassword = userPassword;
            user.UserRealName = userRealName;
            user.UserEmail = userEmail;
            user.UserNickName = userNickName;

            user = user.Register(user);

            if (user is UserData)
                Clients.Caller.registerSuccess(user.UserId, user.UserName, user.UserRealName, user.UserEmail, user.UserNickName);
            else
                Clients.Caller.registerFailure(user.status);
        }
        
        public string InsertStatus(string StatusContent, int UserId)
        {
            Status Status = new Status();
            Status.StatusContent = StatusContent;
            Status.StatusAuthorID = UserId;
            return Status.InsertStatus(Status);
        }

        public Statuses GetNewsFeed(int UserID)
        {
            Statuses statuses = new Statuses();
            statuses.GetNewsFeed(UserID);
            return statuses;
        }

        public Statuses GetPostsByUser(int UserId)
        {
            Statuses statuses = new Statuses();
            statuses.GetAllPostsByUser(UserId);
            return statuses;
        }

        public Users GetUsersByName(string queryText)
        {
            Users users = new Users();
            users.GetUsersByName(queryText);
            return users;
        }

        public UserData GetUserByID(int userId)
        {
            UserData user = new UserData();
            user = user.GetUserById(userId);
            return user;
        }

        public Users GetFriendsList(int UserId)
        {
            Users friends = new Users();
            friends.GetFriendsList(UserId);
            return friends;
        }

        public Users GetFriendRequests(int UserId)
        {
            Users requests = new Users();
            requests.GetFriendRequests(UserId);
            return requests;
        }

        public string SendFriendRequest(int sender, int reciever)
        {
            try
            {
                UserData user = new UserData();
                user.LogFriendRequest(sender, reciever);
                Clients.Client(ConnectionIdByUserId(reciever)).notifyFriendRequest(sender);
                return "Passed";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        public string AcceptFriendRequest(int sender, int reciever)
        {
            try
            {
                UserData user = new UserData();
                user.AcceptFriendRequest(sender, reciever);
                Clients.Client(ConnectionIdByUserId(sender)).notifyFriendAccept(reciever);
                return "Passed";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        public string DeclineFriendRequest(int sender, int reciever)
        {
            try
            {
                UserData user = new UserData();
                user.DeclineFriendRequest(sender, reciever);
                return "Passed";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        public string ConnectionIdByUserId(int UserId)
        {
            string ConnectionId;
            ConnectionStringList.TryGetValue(UserId, out ConnectionId);
            return ConnectionId;
        }

        public Users GetOnlineFriends(int UserId)
        {
            Users friends = new Users();
            Users onlineFriends = new Users();
            friends.GetFriendsList(UserId);

            Parallel.ForEach(friends, friend =>
            {
                string ConnectionString;
                if (ConnectionStringList.TryGetValue(friend.UserId, out ConnectionString))
                    onlineFriends.Add(friend);
            });

            return onlineFriends;

        }

        /*--------------------------------------------------------------------------------------------------------------------*/
        public void TestConnection()
        {
            Clients.Caller.ConnectionSuccessful();
        }
    }
}
