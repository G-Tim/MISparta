using System;

namespace Gladiateur
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			User Test = new User ("Tim", "G.", "Team Warior-Boss-JteDémonte");
			Console.WriteLine (Test.SePresenter()); 

			Gladiator Spartacus = new Gladiator ("Spartacus", 1, "Team A", "Trident, Bouclier");
			Console.WriteLine (Spartacus.SePresenter ());

			User joueur1 = new User("Tim", "G.", "Team Warior-Boss-JteDémonte");
			User joueur2 = new User("Tim2", "G.", "Team Warior-Boss-JteDémonte");
			User joueur3 = new User("Tim3", "G.", "Team Warior-Boss-JteDémonte");
			User joueur4 = new User("Tim4", "G.", "Team Warior-Boss-JteDémonte");
		}
	}
}
