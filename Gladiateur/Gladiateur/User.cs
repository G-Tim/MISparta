using System;

namespace Gladiateur
{
	public class User
	{
		/********** Attributes **********/
		private string firstname;
		public string Firstname {
			get {
				return firstname;
			}
			set {
				firstname = value;
			}
		}


		private string lastname;
		public string Lastname {
			get {
				return lastname;
			}
			set {
				lastname = value;
			}
		}

		private string alias;
		public string Alias {
			get {
				return alias;
			}
			set {
				alias = value;
			}
		}


		private int score;
		public int Score {
			get {
				return score;
			}
			set {
				score = value;
			}
		}

		//private DateTime registerDate;

		/********** Methods **********/
		public User (string p_firstname, string p_lastname, string p_alias)
		{
			this.Firstname = p_firstname;
			this.lastname = p_lastname;
			this.alias = p_alias;
			//this.registerDate = 10/10/2014;
			this.score = 10;
		}

		public string getThis()
		{
			return "JOUEUR: " + this.alias + "\n\t- Prénom: " + this.firstname + "\n\t- Nom: " + this.lastname + "";
		}

	}
}

