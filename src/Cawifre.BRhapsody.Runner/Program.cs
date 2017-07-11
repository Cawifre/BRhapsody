using Autofac;
using Cawifre.BRhapsody.Flow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cawifre.BRhapsody.Runner
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var container = BuildContainer())
            {
                using (var scope = container.BeginLifetimeScope())
                {
                    scope.ResolveNamed<IVerse>(Verses.Intro).Play();
                    scope.ResolveNamed<IVerse>(Verses.One).Play();
                    scope.ResolveNamed<IVerse>(Verses.Two).Play();
                    scope.ResolveNamed<IVerse>(Verses.Three).Play();
                    scope.ResolveNamed<IVerse>(Verses.Four).Play();
                    scope.ResolveNamed<IVerse>(Verses.Outro).Play();
                }
            }
#if DEBUG
            Console.Write("Press any key to exit...");
            Console.ReadKey();
#endif
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterInstance(Console.Out)
                   .As<TextWriter>()
                   .ExternallyOwned();

            builder.RegisterInstance(Console.In)
                   .As<TextReader>()
                   .ExternallyOwned();

            builder.RegisterType<Intro>()
                   .PropertiesAutowired()
                   .Named<IVerse>(Verses.Intro)
                   .InstancePerLifetimeScope();

            builder.RegisterType<VerseOne>()
                   .PropertiesAutowired()
                   .Named<IVerse>(Verses.One)
                   .InstancePerLifetimeScope();

            builder.RegisterType<VerseTwo>()
                   .PropertiesAutowired()
                   .Named<IVerse>(Verses.Two)
                   .InstancePerLifetimeScope();

            builder.RegisterType<VerseThree>()
                   .PropertiesAutowired()
                   .Named<IVerse>(Verses.Three)
                   .InstancePerLifetimeScope();

            builder.RegisterType<VerseFour>()
                   .PropertiesAutowired()
                   .Named<IVerse>(Verses.Four)
                   .InstancePerLifetimeScope();

            builder.RegisterType<Outro>()
                   .PropertiesAutowired()
                   .Named<IVerse>(Verses.Outro)
                   .InstancePerLifetimeScope();

            var life = DateTime.Now.Ticks % 2 == 0
                ? (ILife)new RealLife()
                : new FantasyLife();
            builder.Register(c => DateTime.Now.Ticks % 2 == 0 ? (ILife)new RealLife() : new FantasyLife())
                   .As<ILife>()
                   .InstancePerLifetimeScope();

            return builder.Build();
        }

        private static class Verses
        {
            public static string Intro => "intro";
            public static string One => "i";
            public static string Two => "ii";
            public static string Three => "iii";
            public static string Four => "iv";
            public static string Outro => "outro";
        }
    }
}
