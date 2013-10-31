using System;

namespace PrincipleApplied.Settings
{
    public class SiteSettings : IEmailSettings, ICacheSettings, IAppearanceSettings
    {
        public SiteSettings()
        {
            Console.WriteLine("----------New Site settings instance created------------");
        }

        public int CacheTimeoutMinutes
        {
            get { return 1; }
        }

        public string Title
        {
            get { return "My awesome site"; }
        }

        public string EmailSenderName
        {
            get { return "Vasya"; }
        }

        public string EmailSenderAddress
        {
            get { return "vasya@domain.com"; }
        }
    }
}
