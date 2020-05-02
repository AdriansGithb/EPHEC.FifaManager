using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class MdlJoueurs
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomPrenom { get; set; }

        public MdlJoueurs()
        {

        }

        public MdlJoueurs(int id, string nom, string prenom)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.NomPrenom = $"{nom} {prenom}";
        }
    }
}
