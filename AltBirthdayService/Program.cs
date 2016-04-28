using log4net;
using Topshelf;

namespace AltBirthdayService
{
    internal class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof (Program));
        private static void Main(string[] args)
        {
            _log.Debug("Starting topshelf host factory.");
            HostFactory.Run(x => 
            {
                x.Service<ServiceHostRunner>(s => 
                {
                    s.ConstructUsing(name => new ServiceHostRunner()); 
                    s.WhenStarted(tc => tc.Start()); 
                    s.WhenStopped(tc => tc.Stop()); 
                });
                x.RunAsLocalSystem();

                x.SetDescription("Give your birthdays in 10K and 25K days"); 
                x.SetDisplayName("Alternative Birthday Service"); 
                x.SetServiceName("AltBirthdayService"); 
            });
        }
    }
}