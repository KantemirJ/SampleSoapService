using System.ServiceModel;

namespace SampleSoapService.Services
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string Sum(int num1, int num2);
    }
}
