using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MdlMatchMM
    {
        public int Match_ID { get; set; }
        public DateTime? Date { get; set; }
        public string DateString { get; set; }
        public int Saison_num { get; set; }
        public string Nom_EqpDom { get; set; }
        public int EqpDom_CoChmp_ID { get; set; }

        public string Nom_EqpVisit { get; set; }
        public int EqpVisit_CoChmp_ID { get; set; }

        public string NomString { get; set; }

        public MdlMatchMM()
        {

        }

        public MdlMatchMM(int matchId, DateTime? date, string dateString, int ssnNum, string nomEqpDom,int eqpDomCoChmpId, string nomEqpVisit, int eqpVisitCoChmpId)
        {
            this.Match_ID = matchId;
            this.Date = date;
            this.DateString = dateString;
            this.Saison_num = ssnNum;
            this.Nom_EqpDom = nomEqpDom;
            this.EqpDom_CoChmp_ID = eqpDomCoChmpId;
            this.Nom_EqpVisit = nomEqpVisit;
            this.EqpVisit_CoChmp_ID = eqpVisitCoChmpId;
            this.NomString = $"{this.DateString}   | Q{this.Saison_num} | #{this.Match_ID} |   {this.Nom_EqpDom}><{this.Nom_EqpVisit} ";
        }

    }
}
