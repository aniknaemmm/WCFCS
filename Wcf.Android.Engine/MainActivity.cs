using System;
using Android.App;
using Android.Widget;
using Android.OS;


namespace Wcf.Android.Engine
{


    [Activity(Label = "Wcf.Android.Engine", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);



            //Uri tcpUri = new Uri("http://212.98.178.83:8733/Design_Time_Addresses/WcfServiceLibrary1/Service1/");
            //EndpointAddress address = new EndpointAddress(tcpUri);
            //BasicHttpBinding binding = new BasicHttpBinding();
            //ChannelFactory<IService1> factory = new ChannelFactory<IService1>(binding, address);
            //IService1 service = factory.CreateChannel();
            //Console.WriteLine("Вызываю метод сервиса...?");
            //Console.WriteLine(service.GetData(1));
            //Console.WriteLine(service.GetData(2));
            //Console.WriteLine(service.GetData(20));
            //Console.WriteLine(service.GetData(1562492));
            //Console.WriteLine(service.GetData(0));
            //Console.ReadLine();



            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }

}

