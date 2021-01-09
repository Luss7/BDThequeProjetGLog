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
                Categorie manga = new Categorie("Manga");
                Categorie bd = new Categorie("BD");
                Categorie comic = new Categorie("Comic");

                Genre drame = new Genre("Drame");
                Genre fantastique = new Genre("Fantastique");
                Genre humour = new Genre("Humour");
                Genre suspense = new Genre("Suspense");
                Genre polarThriller = new Genre("Polar/Thriller");
                Genre francoBelge = new Genre("Franco-Belge");
                Genre aventure = new Genre("Aventure");
                Genre biographie = new Genre("Biographie");
                Genre superHeros = new Genre("Super-Héros");
                Genre jeunesse = new Genre("Jeunesse");
                Genre western = new Genre("Western");
                Genre documentaireEncyclopedie = new Genre("Documentaire/Encyclopédie");
                Genre belge = new Genre("Belge");

                Serie deathNote = new Serie("Death Note");
                Serie gaston = new Serie("Gaston");
                Serie tintin = new Serie("Tintin");
                Serie persepolis = new Serie("Persepolis");
                Serie asterix = new Serie("Astérix");
                Serie rubriqueabrac = new Serie("Rubrique-à-Brac");
                Serie watchmen = new Serie("Watchmen");
                Serie schtroumpfs = new Serie("Les Schtroumpfs");
                Serie lechat = new Serie("Le Chat");
                Serie luckyLuke = new Serie("Lucky Luke");
                Serie civilWar = new Serie("Civil War");
                Serie maus = new Serie("Maus");
                Serie calvinHobbes = new Serie("Calvin et Hobbes");

                Auteur ohba = new Auteur("Tsugumi", "Ohba");
                Auteur franquin = new Auteur("André", "Franquin");
                Auteur herge = new Auteur("Hergé", "");
                Auteur strapi = new Auteur("Marjane", "Strapi");
                Auteur gosciny = new Auteur("René", "Gosciny");
                Auteur gotlib = new Auteur("Gotlib", "");
                Auteur moore = new Auteur("Alan", "Moore");
                Auteur peyo = new Auteur("Peyo", "");
                Auteur delporte = new Auteur("Yvan", "Delporte");
                Auteur geluck = new Auteur("Philippe", "Geluck");
                Auteur morris = new Auteur("Morris", "");
                Auteur millar = new Auteur("Mark", "Millar");
                Auteur spiegelman = new Auteur("Art", "Spiegelman");
                Auteur uderzo = new Auteur("Albert", "Uderzo");
                Auteur watterson = new Auteur("Bill", "Watterson");

                Editeur kana = new Editeur("Kana");
                Editeur dupuis = new Editeur("Dupuis");
                Editeur casterman = new Editeur("Casterman");
                Editeur lassociation = new Editeur("L'association"); 
                Editeur hachette = new Editeur("Hacette Livre"); 
                Editeur dargaud = new Editeur("Dargaud"); 
                Editeur dc = new Editeur("DC Comics"); 
                Editeur marvel = new Editeur("Marvel France"); 
                Editeur flammarion = new Editeur("Flammarion"); 
                Editeur lombard = new Editeur("Lombard"); 
                Editeur warner = new Editeur("Warner Books");

                Album alb1 = new Album("", "Death Note - Tome 1", manga, kana, deathNote);
                alb1.Auteurs.Add(ohba);
                alb1.Genres.Add(drame);
                alb1.Genres.Add(fantastique);
                alb1.Genres.Add(polarThriller);
                alb1.Genres.Add(suspense);

                Album alb2 = new Album("", "Gare aux gaffes", bd, dupuis, gaston);
                alb2.Auteurs.Add(franquin);
                alb2.Genres.Add(francoBelge);
                alb2.Genres.Add(humour);

                Album alb3 = new Album("", "Tintin au Tibet", bd, casterman, tintin);
                alb3.Auteurs.Add(herge);
                alb3.Genres.Add(francoBelge);
                alb3.Genres.Add(humour);

                Album alb4 = new Album("", "Persepolis - Tome 1", bd, lassociation, persepolis);
                alb4.Auteurs.Add(strapi);
                alb4.Genres.Add(biographie);

                Album alb5 = new Album("", "Astérix le Gaulois - Astérix Tome 1 ", bd, hachette, asterix);
                alb5.Auteurs.Add(gosciny);
                alb5.Genres.Add(humour);

                Album alb6 = new Album("", "Rubrique-à-brac - Tome 1 ", bd, dargaud, rubriqueabrac);
                alb6.Auteurs.Add(gotlib);
                alb6.Genres.Add(humour);

                Album alb7 = new Album("", "Le Comédien", comic, dc, watchmen);
                alb7.Auteurs.Add(moore);
                alb7.Genres.Add(superHeros);

                Album alb8 = new Album("", "Les Schtroumpfs Noirs ", bd, dupuis, schtroumpfs);
                alb8.Auteurs.Add(peyo);
                alb8.Auteurs.Add(delporte);
                alb8.Genres.Add(aventure);
                alb8.Genres.Add(jeunesse);

                 Album alb9 = new Album("", "Le Chat - Tome 1", bd, casterman, lechat);
                alb9.Auteurs.Add(geluck);
                alb9.Genres.Add(humour);

                Album alb10 = new Album("", "La guérison des Daltons", bd, dargaud, luckyLuke);
                alb10.Auteurs.Add(gosciny);
                alb10.Auteurs.Add(morris);
                alb10.Genres.Add(humour);
                alb10.Genres.Add(belge);
                alb10.Genres.Add(western);

                Album alb11 = new Album("", "Maus - Tome 1 : Un survivant raconte ", bd, flammarion, maus);
                alb11.Auteurs.Add(spiegelman);
                alb11.Genres.Add(documentaireEncyclopedie);

                Album alb12 = new Album("", "Astérix - 2 - La serpe d'or", bd, lombard, asterix);
                alb12.Auteurs.Add(gosciny);
                alb12.Auteurs.Add(uderzo);
                alb12.Genres.Add(humour);

                Album alb13 = new Album("", "Civil War - Tome 01 ", comic, marvel, civilWar);
                alb13.Auteurs.Add(millar);
                alb13.Genres.Add(superHeros);

                Album alb14 = new Album("", "Calvin et Hobbes", bd, warner, calvinHobbes);
                alb14.Auteurs.Add(watterson);
                alb14.Genres.Add(humour);

                Album alb15 = new Album("", "Tintin au pays des Soviets", bd, casterman, tintin);
                alb15.Auteurs.Add(herge);
                alb15.Genres.Add(aventure);
                alb15.Genres.Add(francoBelge);

                session.Save(manga);
                session.Save(bd);
                session.Save(comic);

                session.Save(drame);
                session.Save(fantastique);
                session.Save(polarThriller);
                session.Save(suspense);
                session.Save(francoBelge);
                session.Save(humour);
                session.Save(superHeros);
                session.Save(biographie);
                session.Save(aventure);
                session.Save(jeunesse);
                session.Save(belge);
                session.Save(western);
                session.Save(documentaireEncyclopedie);

                session.Save(kana);
                session.Save(dupuis);
                session.Save(casterman);
                session.Save(lassociation);
                session.Save(hachette);
                session.Save(dargaud);
                session.Save(dc);
                session.Save(marvel);
                session.Save(flammarion);
                session.Save(lombard);
                session.Save(warner);

                session.Save(ohba);
                session.Save(franquin);
                session.Save(herge);
                session.Save(strapi);
                session.Save(gosciny);
                session.Save(moore);
                session.Save(peyo);
                session.Save(delporte);
                session.Save(geluck);
                session.Save(morris);
                session.Save(millar);
                session.Save(spiegelman);
                session.Save(uderzo);
                session.Save(watterson);

                session.Save(deathNote);
                session.Save(gaston);
                session.Save(tintin);
                session.Save(persepolis);
                session.Save(asterix);
                session.Save(rubriqueabrac);
                session.Save(watchmen);
                session.Save(schtroumpfs);
                session.Save(lechat);
                session.Save(luckyLuke);
                session.Save(civilWar);
                session.Save(maus);
                session.Save(calvinHobbes);

                session.Save(alb1);
                session.Save(alb2);
                session.Save(alb3);
                session.Save(alb4);
                session.Save(alb5);
                session.Save(alb6);
                session.Save(alb7);
                session.Save(alb8);
                session.Save(alb9);
                session.Save(alb10);
                session.Save(alb11);
                session.Save(alb12);
                session.Save(alb13);
                session.Save(alb14);
                session.Save(alb15);

                session.Save(alb1);
                session.Save(alb1);
                session.Save(alb1);

            }
        }
    }
        
}
