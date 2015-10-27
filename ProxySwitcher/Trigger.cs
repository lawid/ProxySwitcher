using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher.Triggers
{


    public class Trigger
    {
        public string Title { get; set; }
        public bool IsWiFiTrigger { get; set; }
        public string WiFiSsid { get; set; }
        public bool IsAddressTrigger { get; set; }
        public string AddressMask { get; set; }
        public string ProfileToActivate { get; set; }
    }
}
