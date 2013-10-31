using System;

using Before.Settings;

namespace Before
{
    public class TitlePrinter
    {
        private readonly ISiteSettings m_settings;

        public TitlePrinter(ISiteSettings settings)
        {
            m_settings = settings;
        }

        public void Print()
        {
            Console.WriteLine(m_settings.Title);
        }
    }
}
