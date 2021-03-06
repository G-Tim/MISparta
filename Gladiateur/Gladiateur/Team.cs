using System;
using System.Collections.Generic;

namespace Gladiateur
{
	public class Team
	{
		private int playedMatchs, wonMatchs, lostMatchs;
		public int id;
		private double ratioWin;

		List<Gladiator> LstGlads = new List<Gladiator> ();

		private string name;
		public string Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}

		private string description;
		public string Description {
			get {
				return description;
			}
			set {
				description = value;
			}
		}

		public User userAlias;
		public User UserAlias {
			get {
				return userAlias;
			}
			set {
				userAlias = value;
			}
		}

		public Team (User p_userAlias, Gladiator[] p_glads, int p_id, string p_name, string p_desc)
		{
			for(var i=0; i<3; i++) {
				LstGlads.Add(p_glads[i]);
			}

			int id = p_id;

			this.name = p_name;
			this.description = p_desc;
			this.userAlias = p_userAlias;

			this.playedMatchs = 5;
			this.wonMatchs = 3;
			this.lostMatchs = 2;
			this.ratioWin = this.wonMatchs / this.lostMatchs;

			// Création des gladiateurs
			/*int counter = 1;
			foreach(string glad in p_gladiators) {
				if(counter <= 3) {
					Gladiator gladiator = new Gladiator (this, glad, counter);
					gladiator.Id = counter; // set de l'ID gladiateur dans l'objet
					LstGlads.Add (gladiator); // création d'une liste d'objets de type Gladiator
				}
				counter++;
			}*/

		}

		public string getThis()
		{
			return "\n\t> EQUIPE: " + this.Name + "\n\t\t- Description: " + this.Description + "\t\t";
		}

		public string getGladiators()
		{
			foreach(Gladiator glads in LstGlads) {
				return "\n\t> GLADIATEUR: [nom] " + glads.Name + "";
			}
		}

	}
}

