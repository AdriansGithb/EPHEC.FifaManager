# FifaManager
Langages et technologies utilisées : 
DataBase : T-SQL, Procédures stockées, SQL Server, avec sécurité sur base de schémas
BackEnd : C#, .Net, Entity Framework (app "BackEnd"), ADO.Net (app "MatchManager")
FrontEnd : C#, Windows Forms
Gestion des erreurs

Fifa Manager SGBD project : Projet réalisé dans le cadre du cours de Systèmes de Gestion de Bases de Données

Enoncé :
Gérer un championnat de Soccer… Un championnat est basé sur une année civile… et est divisé et 2 temps (semestre)…
Chaque championnat est composé de X équipes… C’est une variable pour chaque championnat…
Une équipe est composée au minimum de 5 joueurs et maximum 10.
Je dois pouvoir retrouver l’historique des championnats et matches et résultats d’un joueur.
Dans un championnat, le joueur ne peut jouer que dans une équipe. Mais il peut changer d’équipe à l’intersaison (entre 2 Q). Quand c’est un autre championnat, pas de limite de changement mais si intersaison, il ne peut changer que dans les 3 dernières équipes.
Si une équipe n’a que 5 joueurs, pas de sortie possible.
Un matche possède un résultat :
• Gagné : 3 points
• Perdu : 0
• Nulle : 1 points
Un match est organisé avec 5 joueurs au minimum et 7 au maximum. Il faut donc une feuille de matche.
Si lors de ce matche, un joeur reçoit un carton jaune, exclusion de 1 matche durant le semestre. Si carte rouche, exclusion de 3 matches dès le matche suivant.
Si carton jaune ou rouge au dernier matche, on annule tout puisque on redémarre le semestre suivant…
Si on reçoit des cartes dans des matches différents, les absences s’additionnent.
On doit aussi encoder qui a marqué les goals…
Si à cause des cartes, une équipe n’a pas assez de joueur, elle perd d’office.
Lors d’une inscription d’un joueur dans la feuille de match, il doit y avoir une vérification de la possibilité d’inscrire le joueur…
Les matches ne se jouent que les samedis et dimanches. Un planning des matches doit être généré automatiquement et modifiable… Si des matches ne peuvent pas être insérés automatiquement, ils doivent être insérés dans les autres de la semaine manuellement.
C’est un quoi un Q : C’est 5 semaines obligatoires…
2 programmes à faire :
Le premier « Backend » permet de gérer les championnats, équipes,… bref tout…
Le deuxième programme « MatchManagement » permet uniquement de gérer les feuilles de matche… Joueurs et qui a gagné et les cartes.
Fifa manager 2020
VANHOEKE Adrian Page | 37
D’un point de vue technique :
• Des tables sans accès par personne sauf sa
• Des stored procedure et views avec schémas
• Sécurité au niveau du des schémas.
o 2 schémas : Backend et l’autres MatchManagement…
• Découpe obligatoire en BL, DAL, Modèles et Erreurs…
• Le backend doit utiliser EF et MatchManagement ADO.NET
• 2 users SQL, le premier Backend et l’autres MAtchManagement…
Fonctionnalités obligatoires dans le Backend
• Inscrire des joueurs dans une équipe et les limites…transfert Q1 et Q2
• Génération des horaires des matches et la possibilité de les modifier.
• Possibilité de voir les résultats et les modifier ainsi que visualiser les cartes et les inscriptions des joueurs au matche.
• Visualiser le classement
Fonctionnalités obligatoires du MatchManagement
• Inscrire les joueurs pour le matche + contrôles
• Donner le résultat et les cartes et les goals.
Le cahier des charges
• L’énoncé du projet compris par vous
• Analyse des cas business par exemple avec des mookup d’écrans, avec description complète de ce que cela fait.
• Liste des règles et contrôles du projet :
o R1 : un joueur ne peut être inscrit que dans une équipe par championnat…
o …
Ces règles sont les erreurs qui doivent être gérées par votre gestion d’erreur.
• Schéma E-A
• Lister où sont implémentés les erreurs business
o R1 est implémenté dans le trigger x et dans le code là…
1 solution avec 7 projets
• 2 windows forms
• 5 class libraries
