using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.ServiceModel;
using WcfServiceLibrary1;

namespace Wcf.Xamarin.Engine
{

    [Activity(Label = "Wcf.Xamarin.Engine", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;



        protected override void OnCreate(Bundle bundle)
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
            var Sys = service.GetData(2);

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);



            

                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Answer from server");
                alert.SetMessage(service.GetData(123213));
                alert.SetPositiveButton("ok", (senderAlert, args) =>
                {
                    Toast.MakeText(this, "ok!",
                        ToastLength.Short).Show();
                });

                alert.SetNegativeButton("Cancel", (senderAlert, args) =>
                {
                    Toast.MakeText(this, "Cancelled!",
                        ToastLength.Short).Show();
                });

                Dialog dialog = alert.Create();
                dialog.Show();






            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

