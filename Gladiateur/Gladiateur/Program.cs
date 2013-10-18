using System;
using System.Collections.Generic;

namespace Gladiateur
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//User Test = new User ("Tim", "G.", "Team Warior-Boss-JteDémonte");
			//Console.WriteLine (Test.SePresenter()); 

			//Gladiator Spartacus = new Gladiator ("Spartacus", 1, "Team A", "Trident, Bouclier");
			//Console.WriteLine (Spartacus.SePresenter ());

			/***** Initialisation des joueurs *****/
			/**************************************/
			List<User> LstUsers = new List<User> ();
			User joueur1 = new User("Tim", "G.", "Team Warior-Boss-JteDémonte");  LstUsers.Add (joueur1);
			User joueur2 = new User("Polo", "G.", "Team Warior-Boss-JteDémonte"); LstUsers.Add (joueur2);
			User joueur3 = new User("Josette", "M.", "Team Killer-Boss-JteKen");  LstUsers.Add (joueur3);
			User joueur4 = new User("Gisèle", "F.", "Team Killer-Boss-JteKen");   LstUsers.Add (joueur4);

			/***** Initialisation des équipes *****/
			/**************************************/
			List<Team> LstTeams = new List<Team> ();
			// joueur1
			Team team1_1 = new Team(joueur1, 1, "Les Superwariors", "Une team qui mise tout sur la force.");    LstTeams.Add (team1_1)
			// joueur2
			Team team2_1 = new Team(joueur2, 1, "Killers", "La team des killers !");                            LstTeams.Add (team2_1);
			// joueur3
			Team team3_1 = new Team(joueur3, 1, "Nyancats", "Les ch'arc-en-ciel en force !");                   LstTeams.Add (team3_1);
			// joueur4
			Team team4_1 = new Team(joueur4, 1, "Ligue des justiciers", "Les superjusticiers sont de retour."); LstTeams.Add (team4_1);

			/***** Initialisation des gladiateurs *****/
			/******************************************/
			List<Gladiator> LstGlads = new List<Gladiator> ();
			// joueur1 / team1
			Gladiator g1_1_1 = new Gladiator(team1_1, "Marcel", 1); LstGlads.Add (g1_1_1);
			Gladiator g1_1_2 = new Gladiator(team1_1, "Marcel", 2); LstGlads.Add (g1_1_2);
			Gladiator g1_1_3 = new Gladiator(team1_1, "Marcel", 3); LstGlads.Add (g1_1_3);
			// joueur2 / team1
			Gladiator g2_1_1 = new Gladiator(team2_1, "Hervé", 1); LstGlads.Add (g2_1_1);
			Gladiator g2_1_2 = new Gladiator(team2_1, "Steve", 2); LstGlads.Add (g2_1_2);
			Gladiator g2_1_3 = new Gladiator(team2_1, "Mamadou", 3); LstGlads.Add (g2_1_3);
			// joueur3 / team1
			Gladiator g3_1_1 = new Gladiator(team3_1, "Jonas", 1); LstGlads.Add (g3_1_1);
			// joueur4 / team1
			Gladiator g4_1_1 = new Gladiator(team4_1, "Jean-Pierre", 1); LstGlads.Add (g4_1_1);


			/***** Affichage des infos joueurs & équipes *****/
			foreach (User b_joueur in LstUsers) {
				Console.WriteLine(	b_joueur.getThis()	);
			}

			Console.WriteLine(	"========================"	);

			foreach (Team b_team in LstTeams) {
				Console.WriteLine(	b_team.getThis()	);
			}

			Console.WriteLine(	"========================"	);

		}
	}
}
