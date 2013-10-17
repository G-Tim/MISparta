using System;

namespace Gladiateur
{
	public class User
	{
		private string firstname, lastname, alias;
		private DateTime registerDate;
		private int Score;

		public User (string p_firstname, string p_lastname, string p_alias)
		{
			this.firstname = p_firstname;
			this.lastname = p_lastname;
			this.alias = p_alias;
			//			this.registerDate = 10/10/2014;
			this.Score = 10;

		}

		public string getFirstname() {
			return this.firstname;
		}

		public string getLastname() {
			return this.lastname;
		}

		public string getAlias() {
			return this.alias;
		}

		public string getScore() {
			return this.score;
		}


		public virtual string SePresenter()
		{
			return "Je suis " + this.firstname + " " + this.lastname + " et mon Pseudo est " + this.alias + ".";
		}

	}
}

