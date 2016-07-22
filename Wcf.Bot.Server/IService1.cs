using WcfBot;
using System.ServiceModel;
using System.ServiceModel.Web;

[ServiceContract]
public interface IService1
{
    [OperationContract]
    [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = @"/Update")]
    void GetUpdate(Update update);
}