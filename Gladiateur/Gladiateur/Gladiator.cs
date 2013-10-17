using System;

namespace Gladiateur
{
	public class Gladiator
	{
		private int id, stuffPoints, stuffValue, totalWin, teamWin, defeats;
		private double ratio;
		private string team, name;
		private string stuff;

		public Gladiator (string p_name, int p_id, string p_team, string p_stuff)
		{
			this.name = p_name;
			this.id = p_id;
			this.team = p_team;
			this.stuff = p_stuff;
			this.totalWin = 3;
			this.teamWin = 2;
			this.defeats = 1;
			this.ratio = this.teamWin / this.defeats;
			this.stuffPoints = 10 - this.stuffValue;
			this.stuffValue = 0;
		}

		public virtual string SePresenter()
		{
			return "Je suis le gladiateur " + this.name + " et mon ordre de passage est " + id + ".";
		}


	}
}

