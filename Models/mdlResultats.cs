﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MdlResultats
    {
        public int Match_ID { get; set; }
        public DateTime? Date { get; set; }
        public string Nom_EqpDom { get; set; }
        public string Nom_EqpVisit { get; set; }
        public short? GoalsDom { get; set; }
        public short? GoalsVisit { get; set; }
        public string ResultDom { get; set; }
        public string ResultVisit { get; set; }
    }
}
