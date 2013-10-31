using System;

using EarlyRegistration.Settings;

using Microsoft.Practices.Unity;

namespace EarlyRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new UnityContainer();
            SiteSettings settings = new SiteSettings();
            container.RegisterType<IEmailSettings>(new InjectionFactory(i => settings));
            container.RegisterType<IAppearanceSettings>(new InjectionFactory(i => settings));
            container.RegisterType<ICacheSettings>(new InjectionFactory(i => settings));
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
