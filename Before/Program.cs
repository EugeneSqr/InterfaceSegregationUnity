using System;

using Before.Settings;

using Microsoft.Practices.Unity;

namespace Before
{
    public class Program
    {
        public static void Main()
        {
            var container = new UnityContainer();
            container.RegisterType<ISiteSettings, SiteSettings>();
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
