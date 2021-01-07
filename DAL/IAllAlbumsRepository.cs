using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IAllAlbumsRepository
    {
        //Récupère la liste des albums
        IList<Album> GetAll();
    }
}
