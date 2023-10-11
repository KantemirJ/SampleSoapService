using SampleSoapService.Models;
using System.ServiceModel;

namespace SampleSoapService.Services
{
    [ServiceContract]
    public interface IDatabaseManager
    {
        [OperationContract]
        string InsertData(Employee data);
        
    }
}
