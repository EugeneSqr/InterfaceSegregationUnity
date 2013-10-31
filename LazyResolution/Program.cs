using System;

using LazyResolution.Settings;

using Microsoft.Practices.Unity;

namespace LazyResolution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<SiteSettings>(new CustomLifetimeManager());
            container.RegisterType<EmailSender>(new InjectionConstructor(new ResolvedParameter<SiteSettings>()));
            container.RegisterType<TitlePrinter>(new InjectionConstructor(new ResolvedParameter<SiteSettings>()));
            container.RegisterType<ApplicationCache>(new InjectionConstructor(new ResolvedParameter<SiteSettings>()));

            container.Resolve<EmailSender>().SendEmail();
            container.Resolve<TitlePrinter>().Print();
            container.Resolve<ApplicationCache>().Insert();
            Console.ReadKey();
        }
    }
}
