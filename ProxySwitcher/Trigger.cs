using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher.Triggers
{


    public class Trigger
    {
        public TriggerType TriggerType { get; set; }
        public string TriggerProperty { get; set; }
        public string ProfileToActivate { get; set; }
    }

    public enum TriggerType
    {
        WiFi, Address
    }
}
