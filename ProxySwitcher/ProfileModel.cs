using System.ComponentModel;
using System.Linq;
using ProxySwitcher.Properties;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ProxySwitcher
{
    public class ProfileModel
    {
        public static ProfileModel Instance { get; } = new ProfileModel();

        public BindingList<Profile> Proxies { get; } = new BindingList<Profile>();

        private ProfileModel()
        {
            if (Settings.Default.ProfilesJson != null)
            {
                JArray profiles = JArray.Parse(Settings.Default.ProfilesJson);
                foreach (string profile in profiles)
                {
                    Profile p = JsonConvert.DeserializeObject<Profile>(profile);
                    Proxies.Add(p);
                }
            }
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

        public Profile FindProfileByProxy(string proxy) => Proxies.FirstOrDefault(p => proxy == p.Proxy);
        public Profile FindProxyByTitle(string title) => Proxies.FirstOrDefault(p => title == p.Title);
    }
}
