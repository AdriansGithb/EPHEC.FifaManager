﻿using System;
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
                case "Schema specified is not valid. Errors: \r\nFifaManager.ssdl(2,2) : error 0152: No Entity Framework provider found for the ADO.NET provider with invariant name 'System.Data.SqlClient'. Make sure the provider is registered in the 'entityFramework' section of the application config file. See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.":
                    _Message = "La base de données n'est pas connectée. Contactez un administrateur.";
                    break;
                case "clndr Ssn 1 non générable":
                    _Message = "La saison 1 a déjà commencé. Le calendrier ne peut donc être (re)généré.";
                    break;
                case "clndr Ssn 2 non générable":
                    _Message ="La saison 2 a déjà commencé. Le calendrier ne peut donc être (re)généré.";
                    break;
                case "clndr Ssn 12 non générable":
                    _Message =
                        "Les 2 saisons sélectionnées ont déjà commencé. Le calendrier ne peut donc être (re)généré.";
                    break;
                case "Date match non modifiée":
                    _Message =
                        "La date sélectionnée est identique à la date prévue intialement. Aucun changement n'est effectué et sauvegardé.";
                    break;
                case "An error occurred while executing the command definition. See the inner exception for details.":
                    _Message = "Erreur d'exécution dans la BD. Contactez un administrateur.";
                    break;
                case "Le match est joué": _Message = "Le match a déjà été joué. La date n'est plus modifiable.";
                    break;
                //default:
                //    _Message = "Erreur inconnue, veuillez contacter un administrateur";
                default:
                    _Message = erMsg;
                    break;
            }
        }

        public override string Message
        {
            get { return _Message; }
        }
    }
}
