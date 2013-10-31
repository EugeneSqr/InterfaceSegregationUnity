using System;

using PrincipleApplied.Settings;

namespace PrincipleApplied
{
    public class EmailSender
    {
        private readonly IEmailSettings m_settings;

        public EmailSender(IEmailSettings settings)
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
