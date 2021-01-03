using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Editeur
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public Editeur() { }
        public Editeur(string nom)
        {
            Nom = nom; 
        }

    }
}
