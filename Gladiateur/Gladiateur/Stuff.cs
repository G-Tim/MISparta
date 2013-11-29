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
			switch(p_itemname) {
				case "Bouclier_rectangulaire":
				this.Item = new Bouclier_rectangulaire ();
				break;
				case "Casque":
				this.Item = new Casque ();
				break;
				case "Dagues":
				this.Item = new Dagues ();
				break;
				case "Epée":
				this.Item = new Epee ();
				break;
				case "Filet":
				this.Item = new Filet ();
				break;
				case "Lance":
				this.Item = new Lance ();
				break;
				case "Petit_Bouclier_Rond":
				this.Item = new Petit_Bouclier_Rond ();
				break;
				case "Trident":
				this.Item = new Trident ();
				break;
				default:
				break;

			}
		}

	}
}