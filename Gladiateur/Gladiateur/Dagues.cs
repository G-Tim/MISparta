using System;

namespace Gladiateur
{
	public class Dagues : Item
	{
		public Dagues ()
		{
			this.ID = 1;
			this.ItemName = "Dagues";
			this.init = 1;
			this.def = 0;
			this.attack = 60;
			this.point = 2;
		}
	}
}
