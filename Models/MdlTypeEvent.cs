using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MdlTypeEvent
    {
        public int Id { get; set; }
        public string Libelle { get; set; }

        public int Nb_Jours_Suspension { get; set; }
        public bool Susp_Next_Match { get; set; }

    }
}
