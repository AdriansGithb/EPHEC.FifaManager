using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MdlJoueurHistorique
    {
        public string Championnat { get; set; }
        public int Saison { get; set; }
        public string Equipe_Joueur { get; set; }
        public int Match_ID { get; set; }
        public DateTime? Match_Date { get; set; }
        public string Resultat { get; set; }
        public string Equipe_Adverse { get; set; }
    }
}
