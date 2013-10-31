using System;

using Before.Settings;

namespace Before
{
    public class EmailSender
    {
        private readonly ISiteSettings m_settings;

        public EmailSender(ISiteSettings settings)
        {
            m_settings = settings;
        }

        public void SendEmail()
        {
            Console.WriteLine(
                "Email is sent by {0} from {1}",
                m_settings.EmailSenderName,
                m_settings.EmailSenderAddress);
        }
    }
}
