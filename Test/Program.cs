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
            InitDB();
            Console.WriteLine("Done! ");
            Console.WriteLine("Remplissage de la BD... ");
            FillDB();
            Console.WriteLine("Fait!");
            Console.ReadKey();
        }
        static void InitDB()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();

            new SchemaExport(cfg).Execute(true, true, false);
        }
        static void FillDB()
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                Categorie cat1 = new Categorie("Manga");
                Categorie cat2 = new Categorie("BD");
                Categorie cat3 = new Categorie("Comic");

                Genre g1 = new Genre("Drame");
                Genre g2 = new Genre("Fantastique");
                Genre g3 = new Genre("Humour");
                Genre g4 = new Genre("Suspence");
                Genre g5 = new Genre("Polar/Thriller");
                Genre g6 = new Genre("Franco-Belge");
                Genre g7 = new Genre("Aventure");
                Genre g8 = new Genre("Biographie");
                Genre g9 = new Genre("Super-Héros");
                Genre g10 = new Genre("Jeunesse");
                Genre g11 = new Genre("Western");
                Genre g12 = new Genre("Documentaire/Encyclopédie");

                Serie s1 = new Serie("Death Note");
                Serie s2 = new Serie("Gaston");
                Serie s3 = new Serie("Tintin");
                Serie s4 = new Serie("Persepolis");
                Serie s5 = new Serie("Astérix");
                Serie s6 = new Serie("Rubrique-à-Brac");
                Serie s7 = new Serie("Watchmen");
                Serie s8 = new Serie("Les Schtroumpfs");
                Serie s9 = new Serie("Le Chat");
                Serie s10 = new Serie("Lucky Luke");
                Serie s11 = new Serie("Civil War");
                Serie s12 = new Serie("Maus");
                Serie s13 = new Serie("Calvin et Hobbes");

                Auteur a1 = new Auteur("Tsugumi", "Ohba");
                Auteur a2 = new Auteur("André", "Franquin");
                Auteur a3 = new Auteur("Hergé", "");
                Auteur a4 = new Auteur("Marjane", "Strapi");
                Auteur a5 = new Auteur("René", "Gosciny");
                Auteur a6 = new Auteur("Gotlib", "");
                Auteur a7 = new Auteur("Alan", "Moore");
                Auteur a8 = new Auteur("Peyo", "");
                Auteur a9 = new Auteur("Yvan", "Delporte");
                Auteur a10 = new Auteur("Philippe", "Geluck");
                Auteur a11 = new Auteur("Morris", "");
                Auteur a12 = new Auteur("Mark", "Millar");
                Auteur a13 = new Auteur("Art", "Spiegelman");
                Auteur a14 = new Auteur("Albert", "Uderzo");
                Auteur a15 = new Auteur("Bill", "Watterson");

                Editeur e1 = new Editeur("Kana");
                Editeur e2 = new Editeur("Dupuis");
                Editeur e3 = new Editeur("Casterman");
                Editeur e4 = new Editeur("L'association"); 
                Editeur e5 = new Editeur("Hacette Livre"); 
                Editeur e6 = new Editeur("Dargaud"); 
                Editeur e7 = new Editeur("DC Comics"); 
                Editeur e8 = new Editeur("Marvel France"); 
                Editeur e9 = new Editeur("Flammarion"); 
                Editeur e10 = new Editeur("Lombard"); 
                Editeur e11 = new Editeur("Warner Books");

                session.Save(cat1);
                session.Save(cat2);
                session.Save(cat3);
            }
        }
    }
        
}
