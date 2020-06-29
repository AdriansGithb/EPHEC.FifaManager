using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MdlMatchList
    {
        public int Match_ID { get; set; }
        public string DateString { get; set; }
        public int Saison_num { get; set; }
        public string Nom_EqpDom { get; set; }
        public string Nom_EqpVisit { get; set; }
        public string NomString { get; set; }

        public MdlMatchList()
        {

        }

        public MdlMatchList(int matchId, string dateString, int ssnNum, string nomEqpDom, string nomEqpVisit)
        {
            this.Match_ID = matchId;
            this.DateString = dateString;
            this.Saison_num = ssnNum;
            this.Nom_EqpDom = nomEqpDom;
            this.Nom_EqpVisit = nomEqpVisit;
            this.NomString = $"{this.DateString}   | Q{this.Saison_num} | #{this.Match_ID} |   {this.Nom_EqpDom}><{this.Nom_EqpVisit} ";
        }

    }
}
