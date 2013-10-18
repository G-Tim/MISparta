using System;
using System.Collections.Generic;

namespace Gladiateur
{
	class MainClass
		{
			//User Test = new User ("Tim", "G.", "Team Warior-Boss-JteDémonte");
			//Console.WriteLine (Test.SePresenter()); 

			//Gladiator Spartacus = new Gladiator ("Spartacus", 1, "Team A", "Trident, Bouclier");
			//Console.WriteLine (Spartacus.SePresenter ());

			/***** Initialisation des joueurs *****/
			/**************************************/
			List<User> LstUsers = new List<User> ();
			User joueur1 = new User("Tim", "G.", "G-Tim-le-Magnifique");                        LstUsers.Add(joueur1);
			User joueur2 = new User("Polo", "G.", "Polo-Seigneur-des-Enfers");                  LstUsers.Add(joueur2);
			User joueur3 = new User("Nico", "M.", "Nicolas-Ambassadeur-des-Contrées-du-Nord");  LstUsers.Add(joueur3);
			User joueur4 = new User("Guigui", "F.", "Guillaume-le-Grand");                      LstUsers.Add(joueur4);

			/***** Initialisation des équipes & gladiateurs *****/
			/**************************************/
			List<Team> LstTeams = new List<Team> ();
			// joueur1
			Team team1_j1 = new Team(joueur1, 1, "Les Superwariors", "Une team qui mise tout sur la force.", new String[3] {"Marcel", "Henri", "Félix"});                     LstTeams.Add(team1_j1);
			// joueur2
			Team team1_j2 = new Team(joueur2, 1, "Killers", "La team des killers !", new String[3] {"Hervé", "Steve", "Mamadou"});                                            LstTeams.Add(team1_j2);
			// joueur3
			Team team1_j3 = new Team(joueur3, 1, "Nyancats", "Les ch'arc-en-ciel en force !", new String[3] {"Jonas", "John", "Jackie"});                                     LstTeams.Add(team1_j3);
			// joueur4
			Team team1_j4 = new Team(joueur4, 1, "Ligue des justiciers", "Les superjusticiers sont de retour.", new String[3] {"Jean-Pierre", "Jean-René", "Jean-François"}); LstTeams.Add(team1_j4);


			/***** Affichage des infos (joueurs/équipes/gladiateurs) *****/
			foreach (User b_joueur in LstUsers) {
				Console.WriteLine ("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

				Console.WriteLine(	b_joueur.getThis()	);

				foreach (Team b_team in LstTeams) {
					if(b_team.userAlias.Alias == b_joueur.Alias)
						Console.WriteLine(	b_team.getThis()	);

					foreach (Gladiator b_glad in b_team.getGladiators())
						Console.WriteLine (b_glad);
				}
			}


			/*
			 * List<Team> sortByTheTwoStrongestTeam = (from b_team in Team
			       orderby b_team.getPercentVictory() descending
			       select b_team).Take(2).ToList();
			*/
		}
}
