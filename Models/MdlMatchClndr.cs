using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MdlMatchClndr
    {
        public int Match_ID { get; set; }
        public DateTime? Date { get; set; }
        public int Saison_Id { get; set; }
        public int EqpDom_CoChmp_ID { get; set; }
        public string Nom_EqpDom { get; set; }
        public int EqpVisit_CoChmp_ID { get; set; }
        public string Nom_EqpVisit { get; set; }
        public DateTime LastUpdate { get; set; }

    }
}
