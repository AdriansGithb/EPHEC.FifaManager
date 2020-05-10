using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MdlCartons
    {
        public string Championnat { get; set; }
        public int Carton_ID { get; set; }
        public string Couleur { get; set; }
        public string Joueur { get; set; }
        public int MatchID_Event { get; set; }
        public string ID_MatchSuspendus { get; set; }
    }
}
