using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
namespace ConsoleApplication1
{
    class Program
    {
        public static void Main()
        {
            NetworkChange.NetworkAddressChanged += new
            NetworkAddressChangedEventHandler(AddressChangedCallback);
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(AvailabilityChanged);
            Console.WriteLine("Listening...");
            Console.ReadLine();
        }

        private static void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            Console.WriteLine("availability changed");
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface n in adapters)
            {

                Console.WriteLine(" {0} is {1}", n.Name, n.OperationalStatus);
            }
        }


        static void AddressChangedCallback(object sender, EventArgs e)
        {



            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface n in adapters)
            {

                Console.WriteLine(" {0} is {1}", n.Name, n.OperationalStatus);
            }
        }
    }
}
