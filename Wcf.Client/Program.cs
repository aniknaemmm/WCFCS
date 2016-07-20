using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1;

namespace Wcf.Client
{
    namespace Client
    {
        [ServiceContract]
        public interface IMyObject
        {
            [OperationContract]
            string GetCommandString(int i);
        }

        class Program
        {
            static void Main(string[] args)
            {
                Uri tcpUri = new Uri("http://212.98.178.83:8733/Design_Time_Addresses/WcfServiceLibrary1/Service1/");
                EndpointAddress address = new EndpointAddress(tcpUri);
                BasicHttpBinding binding = new BasicHttpBinding();
                ChannelFactory<IService1> factory = new ChannelFactory<IService1>(binding, address);
                IService1 service = factory.CreateChannel();
                Console.WriteLine("Вызываю метод сервиса...?");
                Console.WriteLine(service.GetData(1));
                Console.WriteLine(service.GetData(2));
                Console.WriteLine(service.GetData(20));
                Console.WriteLine(service.GetData(1562492));
                Console.WriteLine(service.GetData(0));
                Console.ReadLine();
            }
        }
    }
}
