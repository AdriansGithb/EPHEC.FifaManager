using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    public class BusinessErrors : Exception
    {
        private string _Message;

        public BusinessErrors(string erMsg)
        {
            switch (erMsg)
            {
                case "NewResultRecordInDB":
                   _Message = "Les données ont été modifiées entre-temps. Veuillez recommencer la procédure";
                    break;
                default: _Message = "Erreur inconnue, veuillez contacter un administrateur";
                    break;
            }
        }

        public override string Message
        {
            get { return _Message; }
        }
    }
}
