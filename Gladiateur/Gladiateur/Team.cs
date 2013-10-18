using System;

namespace Gladiateur
{
	public class Team
	{
		private int id = 0, playedMatchs, wonMatchs, lostMatchs;
		private double ratioWin;

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

		private User userAlias;
		public User UserAlias {
			get {
				return userAlias;
			}
			set {
				userAlias = value;
			}
		}

		public Team (User p_userAlias, int p_id, string p_name, string p_desc)
		{
			if(p_id > 5) {
				return Console.WriteLine("Impossible de créer une équipe. Le nombre maximal est fixé à 5.");
			}
			int id = p_id;

			this.name = p_name;
			this.description = p_desc;
			this.userAlias = p_userAlias;;

			this.playedMatchs = 5;
			this.wonMatchs = 3;
			this.lostMatchs = 2;
			this.ratioWin = this.wonMatchs / this.lostMatchs;
		}

		public string getThis()
		{
			return "EQUIPE | Nom: " + this.Name + " /// Description: " + this.Description + " /// Joueur de référence: " + this.UserAlias.Firstname + ".";
		}

	}
}

