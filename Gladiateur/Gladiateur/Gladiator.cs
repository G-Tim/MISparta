using System;
using System.Collections.Generic;

namespace Gladiateur
{
	public class Gladiator
	{

		private int id = 0, stuffPoints = 10, totalWin, teamWin, defeats;
		private double ratio;
		private string name;
		public string Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}

		private List<Stuff> stuff = new List<Stuff>();
		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public Gladiator (string p_name, String[] p_stuff)
		{
			this.id = this.id;
			this.name = p_name;
			this.totalWin = 3;
			this.teamWin = 2;
			this.defeats = 1;
			this.ratio = this.teamWin / this.defeats;

			for(var i=0; i<p_stuff.Length; i++) {
				stuff.Add(new Stuff(p_stuff[i]));
				if( (stuffPoints - stuff[i].Item.point) >= 0 ) {
					stuffPoints -= stuff[i].Item.point;
				} else {
					Console.WriteLine ("ERREUR: Le nombre de points restants ("+stuffPoints+") du gladiateur est inférieur au nombre de points de l'équipement ("+stuff[i].Item.point+").");
				}
			}
		}

		public string getThis()
		{
			return "\t\t\t* GLADIATEUR: " + this.name + " / Ordre de passage: " + this.id;
		}


	}
}

