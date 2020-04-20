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
        
        // A SUPPRIMER SI UTILISATION CONSTRUCTEUR = OK
        //public override string ToString()
        //{
        //    return (this.Annee + " - " + this.Nom);
        //}
    }



}
