using System;

namespace Gladiateur
{
	public class Gladiator
	{

		private int id, stuffPoints, stuffValue, totalWin, teamWin, defeats;
		private double ratio;
		private string name;
		private string stuff;
		private Team team;
		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public Gladiator (Team p_team, string p_name, int p_id /*, string p_stuff*/)
		{
			this.id = p_id;
			this.name = p_name;
			this.team = p_team;
			//this.stuff = p_stuff;
			this.totalWin = 3;
			this.teamWin = 2;
			this.defeats = 1;
			this.ratio = this.teamWin / this.defeats;
			this.stuffPoints = 10 - this.stuffValue;
			this.stuffValue = 0;
		}

		public string getThis()
		{
			return "\t> GLADIATEUR: " + this.name + " | Ordre de passge: " + this.id + "\n";
		}


	}
}

