
using ProxySwitcher.Triggers;
using SimpleWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace ProxySwitcher.Triggers
{
    public class TriggerListener
    {
        public delegate void ProxyTriggeredEventHandler(Profile profile, string reason);
        public event ProxyTriggeredEventHandler OnProxyTriggered;

        private ProfileModel profiles = ProfileModel.Instance;
        private TriggerModel triggers = TriggerModel.Instance;
        private Wifi wifi;




        private WifiStatus wifiState;
        private string wifiSsid;

        public TriggerListener()
        {
            // listen to wifi changes
            wifi = new Wifi();
            wifi.ConnectionStatusChanged += WiFiConnectionChanged;

            // Listen to address changes
            NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(NetworkAddressChanged);
            Console.WriteLine("Listening...");
            PollCurrentState();
        }


        private void PollCurrentState()
        {
            // WiFi
            wifiState = wifi.ConnectionStatus;

            // if connected find ssid
            if (wifiState == WifiStatus.Connected)
            {
                foreach (AccessPoint ap in wifi.GetAccessPoints())
                {
                    if (ap.IsConnected)
                    {
                        Console.WriteLine("i'm connected to " + ap.Name);
                        wifiSsid = ap.Name;
                    }
                }
            }

            // Network address


            Trigger candidate = null;

            foreach (Trigger trigger in triggers.Triggers)
            {
                bool wifiMatch = false, addressMatch = false;
                if (trigger.IsWiFiTrigger && trigger.WiFiSsid == wifiSsid && wifiState == WifiStatus.Connected)
                {
                    Console.WriteLine("found a trigger for this ssid, ");
                    wifiMatch = true;
                }
                //if(trigger.IsAddressTrigger && trigger.AddressMask ==?)
                //{

                //addressMatch = true;                
                //}


                // check if it doesn't match, and continue search if so
                if ((trigger.IsWiFiTrigger && trigger.IsAddressTrigger && !(wifiMatch && addressMatch))
                    || (trigger.IsWiFiTrigger && !wifiMatch)
                    || (trigger.IsAddressTrigger && !addressMatch)
                    || !(trigger.IsWiFiTrigger || trigger.IsAddressTrigger))
                {
                    Console.WriteLine(trigger.Title + " is no good, continue");
                    continue;
                }

                candidate = trigger;
                break;
            }

            if (candidate != null)
            {
                Console.WriteLine("it seems we have a winner: " + candidate.Title);
            }
            else
            {
                Console.WriteLine("no trigger found, maybe wanna disable?");
            }
        }


        private void NetworkAddressChanged(object sender, EventArgs e)
        {
            Console.WriteLine("address changed " + e);
            PollCurrentState();
        }


        private void WiFiConnectionChanged(object sender, WifiStatusEventArgs e)
        {
            Console.WriteLine("wifi changed");
            PollCurrentState();
        }
    }
}

