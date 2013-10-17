using System;

namespace Gladiateur.Equipment
{
	public class EquipmentDefense : Equipment
	{
		private int defenseRatio; // ratio de défense en % (chances de bloquer)

		public EquipmentDefense ()
		{
		}

		public int getDefenseRatio() {
			return this.defenseRatio;
		}

		public void block() {

		}
	}
}
