using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class EditeurRepository: Repository, IEditeurRepository
    {
        public void Save(Editeur editeur)
        {
            Session.SaveOrUpdate(editeur);
            Session.Flush();
        }

        public IList<Editeur> GetAll()
        {
            return Session.Query<Editeur>().ToList();
        }
    }
}
