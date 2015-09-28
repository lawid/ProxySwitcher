using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxySwitcher.Properties;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ProxySwitcher
{
    public class ProfileModel
    {
        private BindingList<Profile> _proxies = new BindingList<Profile>();

        public BindingList<Profile> Proxies { get { return _proxies; } }

        public ProfileModel()
        {
            if (Settings.Default.ProfilesJson != null)
            {
                JArray profiles = JArray.Parse(Settings.Default.ProfilesJson);
                foreach (string profile in profiles)
                {
                    Profile p = JsonConvert.DeserializeObject<Profile>(profile);
                    _proxies.Add(p);
                }
            }
        }
        
        public Profile FindCurrentProxy(string proxy)
        {
            return Proxies.FirstOrDefault(p => proxy == p.Proxy);
        }

        public void SaveProfiles()
        {
            JArray profilesArray = new JArray();
            foreach (var profile in Proxies)
            {
                profilesArray.Add(JsonConvert.SerializeObject(profile));
            }

            Settings.Default.ProfilesJson = profilesArray.ToString(Formatting.None, null);
            Settings.Default.Save();
        }


    }
}
