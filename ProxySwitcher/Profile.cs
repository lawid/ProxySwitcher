using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher
{
    public class Profile
    {
        internal const char SEPARATOR = '|';

        public string Title { get; set; }
        public string Proxy { get; set; }


        public Profile()
        {
            Title = "Default";
        }

        public Profile(string title, string proxy)
            : this()
        {
            Title = title;
            Proxy = proxy;
        }

        public Profile(string storage)
        {
            string[] parts = storage.Split(SEPARATOR);
            Title = parts[0];
            Proxy = parts[1];
        }

        public override string ToString()
        {
            return Title + SEPARATOR + Proxy;
        }
    }
}
