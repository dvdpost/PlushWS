using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using PlushContract;
using System.ServiceModel.Description;

namespace PlushService
{
    public partial class PlushService : ServiceBase
    {
        private ServiceHost _wcfServiceHost;

        public PlushService()
        {
            InitializeComponent();
            //

            if (!System.Diagnostics.EventLog.SourceExists("PlushServiceSource")) 
		    {         
				    System.Diagnostics.EventLog.CreateEventSource(
                        "PlushServiceSource", "PlushServiceLog");
		    }
            evtlogMobileService.Source = "PlushServiceSource";
            evtlogMobileService.Log = "PlushServiceLog";
            evtlogMobileService.WriteEntry("PlushServiceSource initializing...");
            //
            var baseUri = String.Format("http://{0}:{1}/api", "localhost", 12353);
            _wcfServiceHost = new ServiceHost(typeof(HostPlushService));

            // TODO recheck initial values for buffer sizes and timeouts


            //var webHttpBinding = new WebHttpBinding
            //                             {
            //                                 MaxReceivedMessageSize = 10485760,
            //                                 ReaderQuotas = { MaxStringContentLength = 10485760 },
            //                                 ReceiveTimeout = new TimeSpan(0, 3, 0)
            //                             };


            var webHttpBinding = new WebHttpBinding
            {
                MaxReceivedMessageSize = int.MaxValue,
                ReaderQuotas = { MaxStringContentLength = int.MaxValue },
                MaxBufferSize = int.MaxValue,
                WriteEncoding = ASCIIEncoding.UTF8,
                ReceiveTimeout = new TimeSpan(0, 3, 0),
                CloseTimeout = new TimeSpan(0, 3, 0),
                OpenTimeout = new TimeSpan(0, 1, 0),
                SendTimeout = new TimeSpan(0, 3, 0)
            };
            ////webHttpBinding.Security.Mode = WebHttpSecurityMode.Transport;
            ////webHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

            var se = _wcfServiceHost.AddServiceEndpoint(typeof(IMobileService), webHttpBinding, baseUri);
            se.Behaviors.Add(new WebHttpBehavior());
            evtlogMobileService.WriteEntry("PlushServiceSource Initialized");
        }

        static void Main(string[] args)
        {
            ServiceBase.Run(new PlushService());            
        }

        protected override void OnStart(string[] args)
        {
            //if (_wcfServiceHost != null)
            //{
            //    _wcfServiceHost.Close();
            //}

            //// Create a ServiceHost for the CalculatorService type and 
            //// provide the base address.
            //_wcfServiceHost = new ServiceHost(typeof(WCFServiceClient));

            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            //serviceHost.Open();
            try
            {
                evtlogMobileService.WriteEntry("PlushServiceSource Before open");
                _wcfServiceHost.Open();
                evtlogMobileService.WriteEntry("PlushServiceSource Opened succesfully");
            }
            catch (Exception ex)
            {
                evtlogMobileService.WriteEntry("PlushServiceSource OnStart: " + ex.Message + "InnerMsg: " + (ex.InnerException != null ? ex.InnerException.Message : ""));
            }
            evtlogMobileService.WriteEntry("PlushServiceSource Started");
        }

        protected override void OnStop()
        {
            if (_wcfServiceHost != null)
            {
                try
                {
                    _wcfServiceHost.Close();
                }
                catch (Exception ex)
                {
                    evtlogMobileService.WriteEntry("PlushServiceSource OnStop: " + ex.Message + "InnerMsg: " + (ex.InnerException != null ? ex.InnerException.Message : ""));
                }
                _wcfServiceHost = null;
            }
        }
    }
}
