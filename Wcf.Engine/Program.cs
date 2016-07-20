using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1;

namespace Wcf.Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service1), new Uri("http://212.98.178.83:8733/Design_Time_Addresses/WcfServiceLibrary1/Service1/"));
            host.AddServiceEndpoint(typeof(Service1), new BasicHttpBinding(), "");
            host.Open();
            Console.WriteLine("Сервер запущен");
            Console.ReadLine();

            host.Close();
        }
    }
}
