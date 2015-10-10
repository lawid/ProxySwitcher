
using ProxySwitcher.Triggers;
using SimpleWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace ProxySwitcher
{
    public class TriggerListener
    {
        public delegate void ProxyTriggeredEventHandler(Profile profile, string reason);
        public event ProxyTriggeredEventHandler OnProxyTriggered;

        private ProfileModel profileModel = ProfileModel.Instance;
        private Wifi wifi;
        private bool wifiMatch, addressMatch;
        private string wifiSsid, address;
        private Profile candidate;

        public BindingList<Trigger> WiFiTriggers { get; private set; }

        public TriggerListener()
        {
            // listen to wifi changes
            wifi = new Wifi();
            wifi.ConnectionStatusChanged += WiFiConnectionChanged;

            // Listen to address changes
            NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(NetworkAddressChanged);
            Console.WriteLine("Listening...");
        }





        private void CheckMatch()
        {
            if (wifiMatch || addressMatch)
            {
                Console.WriteLine("Find and enable proxy");
            }
        }


        private void NetworkAddressChanged(object sender, EventArgs e)
        {
            Console.WriteLine("address changed " + e);
            CheckMatch();
        }


        private void WiFiConnectionChanged(object sender, WifiStatusEventArgs e)
        {
            Console.WriteLine("wifi changed");

            if (e.NewStatus == WifiStatus.Connected)
            {
                List<AccessPoint> accessPoints = wifi.GetAccessPoints();
                foreach (AccessPoint ap in accessPoints)
                {
                    if (ap.IsConnected)
                    {
                        Console.WriteLine("i'm connected to " + ap.Name);
                        if (ap.Name == "WLAN-503v")
                        {
                            Console.WriteLine("That's mine enable!!!");

                            wifiSsid = ap.Name;
                            wifiMatch = true;

                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("not for me, disable");
                wifiMatch = false;
            }

            CheckMatch();
        }
    }
}

