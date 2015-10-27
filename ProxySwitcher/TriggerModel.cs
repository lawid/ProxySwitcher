using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProxySwitcher.Properties;
using ProxySwitcher.Triggers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher.Triggers
{
    public class TriggerModel
    {
        private static TriggerModel _instance = new TriggerModel();
        public static TriggerModel Instance { get { return _instance; } }

        private BindingList<Trigger> _triggers = new BindingList<Trigger>();
        public BindingList<Trigger> Triggers { get { return _triggers; } }

        private TriggerModel()
        {
            if (Settings.Default.TriggersJson != null)
            {
                JArray triggers = JArray.Parse(Settings.Default.TriggersJson);
                foreach (string trigger in triggers)
                {
                    Trigger t = JsonConvert.DeserializeObject<Trigger>(trigger);
                    _triggers.Add(t);
                }
            }
        }

        public void SaveTriggers()
        {
            JArray triggersArray = new JArray();
            foreach (var trigger in Triggers)
            {
                triggersArray.Add(JsonConvert.SerializeObject(trigger));
            }

            Settings.Default.TriggersJson = triggersArray.ToString(Formatting.None, null);
            Settings.Default.Save();
        }
    }
}
