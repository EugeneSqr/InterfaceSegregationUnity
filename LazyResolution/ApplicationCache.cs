using System;

using LazyResolution.Settings;

namespace LazyResolution
{
    public class ApplicationCache
    {
        private readonly ICacheSettings m_settings;

        public ApplicationCache(ICacheSettings settings)
        {
            m_settings = settings;
        }

        public void Insert()
        {
            Console.WriteLine("Item inserted into cache. Duration is set to {0}", m_settings.CacheTimeoutMinutes);
        }
    }
}
