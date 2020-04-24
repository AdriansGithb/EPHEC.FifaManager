using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MdlSaison
    {
        public int Id { get; set; }
        public int Champ_Id { get; set; }
        public DateTime Debut { get; set; }
        public int FirstOrSecond { get; set; }
        public DateTime? GnrClndr { get; set; }
    }
}
