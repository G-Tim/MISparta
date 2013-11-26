using System;
using System.Collections.Generic;

namespace Gladiateur
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/***************************/
			/***** INITIALISATIONS *****/
			/***************************/

			/***** Initialisation des joueurs *****/
			List<User> LstUsers = new List<User> ();
			User joueur1 = new User ("Tim", "G.", "G-Tim-le-Magnifique");                       LstUsers.Add (joueur1);
			User joueur2 = new User ("Polo", "G.", "Polo-Seigneur-des-Enfers");                 LstUsers.Add (joueur2);
			User joueur3 = new User ("Nico", "J.", "Nicolas-Ambassadeur-des-Contrées-du-Nord"); LstUsers.Add (joueur3);
			User joueur4 = new User ("Guigui", "F.", "Guillaume-le-Grand");                     LstUsers.Add (joueur4);

			/***** Initialisation des équipes *****/
			List<Team> LstTeams = new List<Team> ();
			// joueur1
			Team team1_j1 = new Team (joueur1, 1, "Les Superwariors", "Une team qui mise tout sur la force." /*, new String[3] { "Marcel", "Henri", "Félix" }*/);                     LstTeams.Add (team1_j1);
			// joueur2
			Team team1_j2 = new Team (joueur2, 1, "Killers", "La team des killers !" /*, new String[3] { "Hervé", "Steve", "Mamadou" }*/);                                            LstTeams.Add (team1_j2);
			// joueur3
			Team team1_j3 = new Team (joueur3, 1, "Nyancats", "Les ch'arc-en-ciel en force !" /*, new String[3] { "Jonas", "John", "Jackie" }*/);                                     LstTeams.Add (team1_j3);
			// joueur4
			Team team1_j4 = new Team (joueur4, 1, "Ligue des justiciers", "Les superjusticiers sont de retour." /*, new String[3] { "Jean-Pierre", "Jean-René", "Jean-François" }*/); LstTeams.Add (team1_j4);

			/***** Initialisation des gladiateurs *****/
			// joueur1
			Gladiator glad1_team1_j1 = new Gladiator (team1_j1, "Marcel", new String[] { "Bouclier_rectangulaire", "Epée" } );

			/***** Initialisation des équipements *****/
			// joueur1
			//Stuff stuff1_team1_j1 = new Stuff ( team1_j1.getGladiators()[0], new Bouclier_rectangulaire() );

			/***** Affichage des infos (joueurs/équipes/gladiateurs) *****/
			foreach (User b_joueur in LstUsers) {
				Console.WriteLine ("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

				Console.WriteLine (b_joueur.getThis ());


			// ****  affichage des items: méthode en provenance de item.cs, pas de parametre. L'item n° correspond à l'id de l'item. **** //

				Dagues Gueda = new Dagues ();
				Console.WriteLine (Gueda.PresenterStuff ());

			// ***************************************************************************************************************************//

				foreach (Team b_team in LstTeams) {
					if (b_team.userAlias.Alias == b_joueur.Alias) {
						Console.WriteLine (b_team.getThis ());

						foreach (Gladiator b_glad in b_team.getGladiators()) {
							if(b_glad.team.Name == b_team.Name) {
								Console.WriteLine (b_glad.getThis());
							}
						}
					}
				}
			}

			/***************************/
			/********* COMBAT  *********/
			/***************************/


			/*
		 * List<Team> sortByTheTwoStrongestTeam = (from b_team in Team
		       orderby b_team.getPercentVictory() descending
		       select b_team).Take(2).ToList();
		*/
		}
	}
}
