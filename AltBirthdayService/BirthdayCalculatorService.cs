using System;
using log4net;

namespace AltBirthdayService
{
    public class BirthdayCalculatorService : IBirthdayCalculatorService
    {
        private readonly ILog _log = LogManager.GetLogger(typeof (BirthdayCalculatorService));
        public BirthdayResponse Calculate(BirthdayRequest request)
        {
            _log.Info($"Processing request for {request.DateOfBirth}.");
            var tenKDate = request.DateOfBirth.Add(TimeSpan.FromDays(10000));
            var twentyFiveKDate = request.DateOfBirth.Add(TimeSpan.FromDays(25000));

            _log.Info($"Returning response; 10,000: {tenKDate}, 25,000: {twentyFiveKDate}.");
            return new BirthdayResponse {TenThousandDaysOld = tenKDate, TwentyFiveThousandDaysOld = twentyFiveKDate};
        }
    }
}