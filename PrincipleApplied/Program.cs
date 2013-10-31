using System;

using Microsoft.Practices.Unity;

using PrincipleApplied.Settings;

namespace PrincipleApplied
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IEmailSettings, SiteSettings>();
            container.RegisterType<IAppearanceSettings, SiteSettings>();
            container.RegisterType<ICacheSettings, SiteSettings>();
            container.RegisterType<EmailSender>();
            container.RegisterType<TitlePrinter>();
            container.RegisterType<ApplicationCache>();

            container.Resolve<EmailSender>().SendEmail();
            container.Resolve<TitlePrinter>().Print();
            container.Resolve<ApplicationCache>().Insert();
            Console.ReadKey();
        }
    }
}
