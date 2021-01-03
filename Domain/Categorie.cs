using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Categorie
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public Categorie() { }
        public Categorie(string nom)
        {
            Nom = nom;
        }
    }
}
