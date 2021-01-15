using DAL;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IUtilisateurRepository utilisateurRepository = new UtilisateurRepository();
            IAlbumRepository albumRepository = new AlbumRepository();
            ICategorieRepository categorieRepository = new CategorieRepository();
            IGenreRepository genreRepository = new GenreRepository();
            //Application.Run(new Accueil());
            //Application.Run(new BDliotheque());

            Application.Run(new BDliotheque(utilisateurRepository, albumRepository,categorieRepository,genreRepository));
        }
    }
}
