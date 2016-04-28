using System;
using System.Runtime.Serialization;

namespace AltBirthdayService
{
    [DataContract]
    public class BirthdayResponse
    {
        [DataMember]
        public DateTimeOffset TenThousandDaysOld { get; set; }

        [DataMember]
        public DateTimeOffset TwentyFiveThousandDaysOld { get; set; }
    }
}