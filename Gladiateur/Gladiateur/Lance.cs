using System;

namespace Gladiateur
{
	public class Lance : Item
	{
		public Lance ()
		{
			this.ID = 3;
			this.itemName = "Lance";
			this.init = 4;
			this.def = 0;
			this.attack = 50;
			this.point = 7;
		}
	}
}