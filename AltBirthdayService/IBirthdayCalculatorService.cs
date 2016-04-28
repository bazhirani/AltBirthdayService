using System.ServiceModel;

namespace AltBirthdayService
{
    [ServiceContract]
    public interface IBirthdayCalculatorService
    {
        [OperationContract]
        BirthdayResponse Calculate(BirthdayRequest request);
    }
}