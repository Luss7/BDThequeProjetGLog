using DAL;
using Domain;
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
            //Application.Run(new Accueil());
            //Application.Run(new BDliotheque());

            Application.Run(new BDliotheque(utilisateurRepository,albumRepository));
        }
    }
}
