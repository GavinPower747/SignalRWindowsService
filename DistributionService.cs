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
        public static ConcurrentDictionary<UserData, string> UserList = new ConcurrentDictionary<UserData, string>();
        /*--------------------------------------------------------------------------------------------------------------------*/
        public void GetBills()
        {
            Bills Bills = new Bills();
            Bills.GetAllBills();
            Clients.Caller.displayBills(Bills);
        }

        /*--------------------------------------------------TwangR Functions--------------------------------------------------*/

        public void Send(string MessageID, string messageUp, string sender, bool isSelf)
        {
            Message message = new Message();
            message.messageID = MessageID;
            message.sender = sender;
            message.message = messageUp;
            message.isSelf = isSelf;
            Clients.All.addMessage(MessageID, messageUp, sender, isSelf);
            Clients.Caller.messageRecieved(MessageID, messageUp, sender, isSelf);
        }

        public void Login(string Username, string Password)
        {
            dynamic user = new UserData();
            user = user.Login(Username, Password);

            if (user is UserData)
                Clients.Caller.loginSuccess(user.UserId, user.UserName, user.UserRealName, user.UserEmail, user.UserNickName);
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
        
        public void InsertStatus(string StatusContent, int UserId)
        {
            Status Status = new Status();
            Status.StatusContent = StatusContent;
            Status.StatusAuthorID = UserId;
            Status.InsertStatus(Status);
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

        /*--------------------------------------------------------------------------------------------------------------------*/
        public void TestConnection()
        {
            Clients.Caller.ConnectionSuccessful();
        }
    }
}
