using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using SimpleWifi;

namespace ConsoleApplication1
{
    class Program
    {
        private static Wifi wifi;

        public static void Main()
        {
            wifi = new Wifi();
            // listen to wifi changes
            wifi.ConnectionStatusChanged += wifi_connectionStatusChanged;

            NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(AddressChangedCallback);
            Console.WriteLine("Listening...");
            Console.ReadLine();
        }

        private static void wifi_connectionStatusChanged(object sender, WifiStatusEventArgs e)
        {
            Console.WriteLine("wifi changed");
            if(e.NewStatus==WifiStatus.Connected)
            HandleListenEvent();
        }

        static void AddressChangedCallback(object sender, EventArgs e)
        {
            Console.WriteLine("address changed");

        }

        private static bool HandleListenEvent()
        {
            if(wifi.ConnectionStatus == WifiStatus.Connected)
            {
                List<AccessPoint> aps = wifi.GetAccessPoints();
                foreach(AccessPoint ap in aps)
                {
                    if(ap.IsConnected)
                    {
                        Console.WriteLine("i'm connected to " + ap.Name);
                        if(ap.Name=="WLAN-503v")
                        {
                            Console.WriteLine("That's mine enable!!!");
                            return true;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("not for me, disable");
            }
            return false;
        }
        
        
    }
}
