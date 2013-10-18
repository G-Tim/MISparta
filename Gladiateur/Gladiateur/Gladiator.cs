using System;

namespace Gladiateur
{
	public class Gladiator
	{

 		private int equipmentPoints, equipmentValue, totalWin, teamWin, defeats;
		private double ratio;
		private string name;
		private string equipment;
		private Team team;

		private int id;
		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public Gladiator (Team p_team, string p_name, int p_id /*, string p_equipment*/)
		{
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

		public string getThis()
		{
			return "\t> GLADIATEUR: " + this.name + " | Ordre de passge: " + this.id + "\n";
		}


	}
}

