using System;

namespace Gladiateur
{
	public class Epee : Item
	{
		public Epee ()
		{
			this.ID = 2;
			this.itemName = "Epée";
			this.init = 2;
			this.def = 0;
			this.attack = 70;
			this.point = 5;
		}
	}
}