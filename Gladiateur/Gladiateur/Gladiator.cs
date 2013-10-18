using System;

namespace Gladiateur
{
	public class Gladiator
	{
		private int id, equipmentPoints, equipmentValue, totalWin, teamWin, defeats;
		private double ratio;
		private string name;
		private string equipment;
		private Team team;

		public Gladiator (Team p_team, string p_name, int p_id /*, string p_equipment*/)
		{
			if(p_id > 3) {
				return Console.WriteLine("Impossible de créer un gladiateur. Le nombre maximal est fixé à 3.");
			}
			this.id = p_id;
			this.name = p_name;
			this.team = p_team;
			//this.equipment = p_equipment;
			this.totalWin = 3;
			this.teamWin = 2;
			this.defeats = 1;
			this.ratio = this.teamWin / this.defeats;
			this.equipmentPoints = 10 - this.equipmentValue;
			this.equipmentValue = 0;
		}



		public virtual string SePresenter()
		{
			return "Je suis le gladiateur " + this.name + " et mon ordre de passage est " + id + ".";
		}


	}
}

