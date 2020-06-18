using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class MdlChampionnat
    {
        public static int SsnWeeks = 5;
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Annee { get; set; }
        public string NomString { get; set; }

        public MdlChampionnat()
        {

        }
        
        public MdlChampionnat(int id, string nom, int annee)
        {
            this.Id = id;
            this.Nom = nom;
            this.Annee = annee;
            this.NomString = $"{this.Annee} - {this.Nom}";
        }
        
    }



}
