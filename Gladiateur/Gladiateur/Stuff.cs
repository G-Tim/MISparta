using System;

namespace Gladiateur
{
	public class Stuff
	{
		public Gladiator glad;
		public Item item;
		public Item Item {
			get {
				return item;
			}
			set {
				item = value;
			}
		}

		public Stuff ( string p_itemname )
		{
			this.item = new Item();
			item.createItem (p_itemname);
		}

	}
}