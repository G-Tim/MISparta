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
			List<User> LstUsers = new List<User> ();

			User joueur1 = new User("Tim", "G.", "Team Warior-Boss-JteDémonte");
				LstUsers.Add (joueur1);
			User joueur2 = new User("Polo", "G.", "Team Warior-Boss-JteDémonte");
				LstUsers.Add (joueur2);
			User joueur3 = new User("Josette", "M.", "Team Killer-Boss-JteKen");
				LstUsers.Add (joueur3);
			User joueur4 = new User("Gisèle", "F.", "Team Killer-Boss-JteKen");
				LstUsers.Add (joueur4);

			/***** Initialisation des équipes *****/
			List<Team> LstTeams = new List<Team> ();

			Team team1 = new Team(joueur1, "Les Superwariors", "Une team qui mise tout sur la force.");
			LstTeams.Add (team1);
			Team team2 = new Team(joueur2, "Killers", "Le team des killers !");
			LstTeams.Add (team2);
			Team team3 = new Team(joueur3, "Nyancats", "Les ch'arc-en-ciel en force !");
			LstTeams.Add (team3);
			Team team4 = new Team(joueur4, "Ligue des justiciers", "Les superjusticiers sont de retour.");
			LstTeams.Add (team4);

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
