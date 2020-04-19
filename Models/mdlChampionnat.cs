using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class MdlChampionnat
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Annee { get; set; }

        public override string ToString()
        {
            return (this.Annee + " - " + this.Nom);
        }
    }



}
