using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxySwitcher.Properties;

namespace ProxySwitcher
{
    public class ProfileModel
    {
        private BindingList<Profile> proxies = new BindingList<Profile>();

        public BindingList<Profile> Proxies { get { return proxies; } }

        public ProfileModel()
        {
            if (Settings.Default.Profiles != null)
            {
                foreach (var profile in Settings.Default.Profiles)
                {
                    proxies.Add(new Profile(profile));
                }
            }
        }

        public void AddProfile(Profile profile)
        {
            proxies.Add(profile);
        }

        public void RemoveProfile(Profile selected)
        {
            proxies.Remove(selected);
        }

        public Profile FindCurrentProxy(string proxy)
        {
            return Proxies.FirstOrDefault(p => proxy == p.Proxy);
        }

        public void SaveProfiles()
        {
            Settings.Default.Profiles.Clear();
            foreach (var profile in Proxies)
            {
                Settings.Default.Profiles.Add(profile.ToString());
            }
            Settings.Default.Save();
        }

        
    }
}
