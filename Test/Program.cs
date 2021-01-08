using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using Domain;

namespace Test
{
    public class Program
    {
        private static ISessionFactory sessionFactory = null;

        static void Main(string[] args)
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();

            Console.WriteLine("Exporting DB schema... ");

            Configuration cfg = new Configuration();
            cfg.Configure();

            new SchemaExport(cfg).Execute(true, true, false);

            Console.WriteLine("Done! ");
            Console.WriteLine("Remplissage de la BD... ");
            FillDB();
            Console.WriteLine("Fait!");
            Console.ReadKey();
        }
        static void FillDB()
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                Categorie cat1 = new Categorie("Manga");
                Categorie cat2 = new Categorie("BD");
                Categorie cat3 = new Categorie("Comic");
                session.Save(cat1);
                session.Save(cat2);
                session.Save(cat3);
            }
        }
    }
        
}
