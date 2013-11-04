using System;

namespace Gladiateur
{
	public class Trident: Item
	{
		public Trident () 
		{
			this.ID = 4;
			this.itemName = "Trident";
			this.init = 3;
			this.def = 10;
			this.attack = 40;
			this.point = 7;
		}
	}
}