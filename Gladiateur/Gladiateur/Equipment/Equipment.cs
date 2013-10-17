using System;

namespace Gladiateur.Equipment
{
	public class Equipment
	{
		private string equipmentType; // nom de l'équipement actuel
		private int stuffPoints;  // coût en points de l'équipement actuel

		public string getEquipmentType() {
			return this.equipmentType;
		}

		public int getStuffPoints() {
			return this.stuffPoints;
		}

		public Equipment ()
		{
		}
	}
}
