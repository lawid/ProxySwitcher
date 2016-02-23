namespace ProxySwitcher
{
    public class Profile
    {
        public string Title { get; set; }
        public string Proxy { get; set; }

        public string DisplayView
        {
            get
            {
                var label = Title;
                if (ProxyController.Instance.GetCurrentProxy() == Proxy) label += " (current)";
                return label;
            }
        }
    }
}
