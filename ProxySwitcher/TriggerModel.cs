using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProxySwitcher.Properties;
using System.ComponentModel;

namespace ProxySwitcher.Triggers
{
    public class TriggerModel
    {
        public static TriggerModel Instance { get; } = new TriggerModel();
        public BindingList<Trigger> Triggers { get; } = new BindingList<Trigger>();

        private TriggerModel()
        {
            if (Settings.Default.TriggersJson != null)
            {
                JArray triggers = JArray.Parse(Settings.Default.TriggersJson);
                foreach (string trigger in triggers)
                {
                    Trigger t = JsonConvert.DeserializeObject<Trigger>(trigger);
                    Triggers.Add(t);
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
