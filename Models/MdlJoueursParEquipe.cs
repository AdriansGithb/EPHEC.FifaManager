using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MdlJoueursParEquipe
    {
        public int CEqp_Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomPrenom { get; set; }
        public DateTime LastUpdate { get; set; }

        public MdlJoueursParEquipe()
        {

        }

        public MdlJoueursParEquipe(int id, string nom, string prenom)
        {
            this.CEqp_Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.NomPrenom = $"{nom} {prenom}";
        }
    }
}
