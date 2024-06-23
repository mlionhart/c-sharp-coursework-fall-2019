using System.Diagnostics;
using System.ServiceProcess;

namespace WinService
{
    public partial class WinService : ServiceBase
    {
        public WinService()
        {
            InitializeComponent();
            if (!EventLog.SourceExists("WinService"))
            {
                EventLog.CreateEventSource("WinService", "Application");
            }
            eventLog1.Source = "WinService";
            eventLog1.Log = "Application";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Starting the service", EventLogEntryType.Information, 1001);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Stopping the service", EventLogEntryType.Information, 1001);
        }
    }
}
