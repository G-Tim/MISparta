using System;

namespace Gladiateur
{
	public class Gladiator
	{

		private int id = 0, stuffPoints = 10, totalWin, teamWin, defeats;
		private double ratio;
		private string name;
		private Stuff[] stuff = new Stuff[] {};
		public Team team;
		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public Gladiator (Team p_team, string p_name, String[] p_stuff)
		{
			this.id = this.id;
			this.name = p_name;
			this.team = p_team;
			this.totalWin = 3;
			this.teamWin = 2;
			this.defeats = 1;
			this.ratio = this.teamWin / this.defeats;

			for(var i=0; i<p_stuff.Length; i++) {
				this.stuff[i] = new Stuff(p_stuff[i]);
				stuffPoints += this.stuff[i].Item.point;
			}
		}

		public string getThis()
		{
			return "\t\t\t* GLADIATEUR: " + this.name + " / Ordre de passage: " + this.id;
		}


	}
}

