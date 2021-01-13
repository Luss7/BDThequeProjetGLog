using System.Windows.Forms;

namespace App
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Accueil());
        }
    }
}
