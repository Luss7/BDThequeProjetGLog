using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IWishlistRepository
    {
        //TODO : Récupère la liste des albums de la wishlist
        IList<WishList> GetAll();
    }
}
