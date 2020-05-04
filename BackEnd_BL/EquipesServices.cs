using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd_DAL;
using Models;

namespace BackEnd_BL
{
    public class EquipesServices
    {
        public static int nbJoueursMin = 5;

        public static int nbJoueursMax = 10;

        //inscription de la liste sélectionnée (reçoit la sélection de joueurs à inscrire, l'équipe dans laquelle il faut les inscrire, le nb de joueurs inscrits dans l'équipe)
        public void InscrireJoueurs(List<MdlJoueurs> slctdJoueurs, MdlEquipeChamp eqp, int nbJrEqp)
        {

        }

        //créer une fonction pour vérifier le nb max (à utiliser lors du click inscrire)
        // et une pour vérifier le nb min (à utiliser lors du click desinscrire)
        //utiliser les 2 dans la fonction de sauvegarde vers la BD
    }
}
