using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Genre
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public Genre() { }
        public Genre(string nom)
        {
            Nom = nom;
        }
    }
}
