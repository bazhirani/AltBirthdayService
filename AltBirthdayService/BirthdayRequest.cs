using System;
using System.Runtime.Serialization;

namespace AltBirthdayService
{
    [DataContract]
    public class BirthdayRequest
    {
        [DataMember]
        public DateTimeOffset DateOfBirth { get; set; }
    }
}