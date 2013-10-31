using System;

using Before.Settings;

namespace Before
{
    public class ApplicationCache
    {
        private readonly ISiteSettings m_settings;

        public ApplicationCache(ISiteSettings settings)
        {
            m_settings = settings;
        }

        public void Insert()
        {
            Console.WriteLine("Item inserted into cache. Duration is set to {0}", m_settings.CacheTimeoutMinutes);
        }
    }
}
