using System;
using System.Collections.Generic;
using DAL;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace DALTests
{
    class TestRepository : Repository
    {
        private static ISessionFactory sessionFactory = null;
        internal static void ResetSchema()
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            Configuration cfg = new Configuration();
            cfg.Configure();

            new SchemaExport(cfg).Execute(false, true, false);
        }

        internal static void ClearSession()
        {
            Session.Clear();
        }

        internal static void Execute(string sql)
        {
            ISQLQuery query = Session.CreateSQLQuery(sql);
            query.ExecuteUpdate();
        }

        /// <summary>
        /// Load database with test data
        /// </summary>
        public static void InitDB()
        {
            ResetSchema();
            
            Execute(
                "insert into album  values(1, 'death-note-t1.jpg', 'Death Note - Tome 1', 1, 1, 1);" +
                "insert into album  values(2, 'les-archives-de-lagaffe.jpg', 'Les archives de Lagaffe', 2, 2, 2);" +
                "insert into album  values(3, 'tintin-au-tibet.jpg', 'Tintin au Tibet', 2, 3, 3);" +
                "insert into album  values(4, 'persepolis.jpg', 'Persepolis - Tome 1', 2, 4, 4);" +
                "insert into album  values(5, 'asterix-le-gaulois.jpg', 'Astérix le Gaulois - Astérix Tome 1 ', 2, 5, 5);"
                );

            Execute(
                "insert into album_auteurs values(1, 1)" +
                "insert into album_auteurs values(1, 6);" +
                "insert into album_auteurs values(2, 2);" +
                "insert into album_auteurs values(2, 7);" +
                "insert into album_auteurs values(3, 3);" +
                "insert into album_auteurs values(4, 4);" +
                "insert into album_auteurs values(5, 5);"
                ); 

            Execute(
                "insert into album_genres values(1, 1)" +
                "insert into album_genres values(1, 2);" +
                "insert into album_genres values(1, 3);" +
                "insert into album_genres values(2, 5);" +
                "insert into album_genres values(2, 6);" +
                "insert into album_genres values(3, 5);" +
                "insert into album_genres values(3, 6);" +
                "insert into album_genres values(4, 7);" +
                "insert into album_genres values(5, 6);"
                );

            Execute(
                "insert into auteur values(1, 'Tsugumi', 'Ohba');" +
                "insert into auteur values(2, 'André', 'Franquin');" +
                "insert into auteur values(3, 'Hergé', '');" +
                "insert into auteur values(4, 'Marjane', 'Strapi');" +
                "insert into auteur values(5, 'René', 'Goscinny');" +
                "insert into auteur values(6, 'Takeshi', 'Obata');" +
                "insert into auteur values(7, 'Jidéhem', ''); "
                );

            Execute(
                "insert into categorie values(1, 'Manga');" +
                "insert into categorie values(2, 'BD');"
                );

            Execute(
                "insert into editeur values(1, 'Kana');" +
                "insert into editeur values(2, 'Dupuis');" +
                "insert into editeur values(3, 'Casterman');" +
                "insert into editeur values(4, 'L\'association');"+
                "insert into editeur values(5, 'Hachette Livre');"
                );

            Execute(
                "insert into genre values(1, 'Drame');" +
                "insert into genre values(2, 'Fantastique');" +
                "insert into genre values(3, 'Polar/Thriller');" +
                "insert into genre values(4, 'Suspense');" +
                "insert into genre values(5, 'Franco-Belge');" +
                "insert into genre values(6, 'Humour');" +
                "insert into genre values(7, 'Biographie');" +
                "insert into genre values(8, 'Aventure');"
                );
            Execute(
                "insert into serie values(1, 'Death Note');" +
                "insert into serie values(2, 'Gaston');" +
                "insert into serie values(3, 'Tintin');" +
                "insert into serie values(4, 'Persepolis');" +
                "insert into serie values(5, 'Astérix');" 
                );

            Execute(
                "insert into utilisateur values(1, 'luludu31', 'coucou');" +
                "insert into utilisateur values(2, 'bpesquet', 'jaimelegenielog');" +
                "insert into utilisateur values(3, 'dbrognart', 'kohlanta');"
                );
        }
    }
}
