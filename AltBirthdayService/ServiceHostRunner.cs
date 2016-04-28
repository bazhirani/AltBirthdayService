using System.ServiceModel;
using log4net;

namespace AltBirthdayService
{
    public class ServiceHostRunner
    {
        private readonly ILog _log = LogManager.GetLogger(typeof (ServiceHostRunner));

        private ServiceHost _serviceHost;

        public void Start()
        {
            _serviceHost = new ServiceHost(typeof (BirthdayCalculatorService));
            _serviceHost.Open();
            _log.Info("Opened Service Host");
        }

        public void Stop()
        {
            _serviceHost?.Close();
            _log.Info("Closed Service Host");
        }
    }
}