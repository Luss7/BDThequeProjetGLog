using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exporting DB schema... ");

            Configuration cfg = new Configuration();
            cfg.Configure();

            new SchemaExport(cfg).Execute(true, true, false);

            Console.WriteLine("Done! ");
            Console.ReadKey();
        }
    }
}
