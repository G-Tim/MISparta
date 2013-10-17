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

			 
		}
	}
}
