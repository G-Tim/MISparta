using System;

namespace Gladiateur/Equipment
{
	public class EquipmentAttack : Equipment
	{
		private int attackRatio, initiative; // ratio d'attaque en % (chances de toucher) | niveau initiative de l'arme [1-5]

		public EquipmentAttack ()
		{
		}

		public getAttackRatio() {
			return this.attackRatio;
		}

		public getInitiative() {
			return this.initiative;
		}

		public attack() {

		}
	}
}

