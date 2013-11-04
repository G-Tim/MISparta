using System;

namespace Gladiateur
{
	public class Casque : Item
	{
		public Casque ()
		{
			this.ID = 8;
			this.itemName = "Casque";
			this.init = 0;
			this.def = 10;
			this.attack = 0;
			this.point = 2;
		}
	}
}