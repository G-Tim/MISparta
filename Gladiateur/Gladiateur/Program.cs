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

			/***** Initialisation des gladiateurs *****/
			// joueur1 > team1
			Gladiator glad1_j1 = new Gladiator ("Marcel", new String[] { "Bouclier_rectangulaire", "Dagues" } );
			Gladiator glad2_j1 = new Gladiator ("Henry", new String[] { "Epée", "Petit_Bouclier_Rond" } );
			Gladiator glad3_j1 = new Gladiator ("Jean-Jacques", new String[] { "Filet", "Dagues", "Casque" } );
			// joueur2 > team1
			Gladiator glad1_j2 = new Gladiator ("Dany", new String[] { "Bouclier_rectangulaire", "Dagues" } );
			Gladiator glad2_j2 = new Gladiator ("Toto", new String[] { "Epée", "Petit_Bouclier_Rond" } );
			Gladiator glad3_j2 = new Gladiator ("Georges", new String[] { "Filet", "Dagues", "Casque" } );
			// joueur3 > team1
			Gladiator glad1_j3 = new Gladiator ("Felix", new String[] { "Bouclier_rectangulaire", "Dagues" } );
			Gladiator glad2_j3 = new Gladiator ("Sam", new String[] { "Epée", "Petit_Bouclier_Rond" } );
			Gladiator glad3_j3 = new Gladiator ("Babar", new String[] { "Filet", "Dagues", "Casque" } );
			// joueur4 > team1
			Gladiator glad1_j4 = new Gladiator ("Derick", new String[] { "Bouclier_rectangulaire", "Dagues" } );
			Gladiator glad2_j4 = new Gladiator ("Mamadou", new String[] { "Epée", "Petit_Bouclier_Rond" } );
			Gladiator glad3_j4 = new Gladiator ("Titi", new String[] { "Filet", "Dagues", "Casque" } );

			/***** Initialisation des équipes *****/
			// (les instances de gladiateurs sont réparties dans les équipes)
			List<Team> LstTeams = new List<Team> ();
			// joueur1
			Team team1_j1 = new Team (joueur1, new Gladiator[3] {glad1_j1, glad2_j1, glad3_j1}, 1, "Les Superwariors", "Une team qui mise tout sur la force." ); LstTeams.Add (team1_j1);
			// joueur2
			Team team1_j2 = new Team (joueur2, new Gladiator[3] {glad1_j2, glad2_j2, glad3_j2}, 1, "Killers", "La team des killers !"); LstTeams.Add (team1_j2);
			// joueur3
			Team team1_j3 = new Team (joueur3, new Gladiator[3] {glad1_j3, glad2_j3, glad3_j3}, 1, "Nyancats", "Les ch'arc-en-ciel en force !"); LstTeams.Add (team1_j3);
			// joueur4
			Team team1_j4 = new Team (joueur4, new Gladiator[3] {glad1_j4, glad2_j4, glad3_j4}, 1, "Ligue des justiciers", "Les superjusticiers sont de retour."); LstTeams.Add (team1_j4);

			/***** Initialisation des équipements *****/
			// joueur1
			//Stuff stuff1_team1_j1 = new Stuff ( team1_j1.getGladiators()[0], new Bouclier_rectangulaire() );

			/***** Affichage des infos (joueurs/équipes/gladiateurs) *****/
			foreach (User b_joueur in LstUsers) {
				Console.WriteLine ("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

				Console.WriteLine (b_joueur.getThis ());

			// ***************************************************************************************************************************//

				foreach (Team b_team in LstTeams) {
					if (b_team.userAlias.Alias == b_joueur.Alias) {
						Console.WriteLine (b_team.getGladiators ());
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
