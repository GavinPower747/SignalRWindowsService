using System.ServiceProcess;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin;
using SignalRWindowsService.Model;

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
        public void GetBills()
        {
            Bills Bills = new Bills();
            Bills.GetAllBills();
            Clients.Caller.displayBills(Bills);
        }

        public void TestConnection()
        {
            Clients.Caller.ConnectionSuccessful();
        }
    }
}
