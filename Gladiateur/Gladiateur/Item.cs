using System;

namespace Gladiateur
{
	public class Item
	{

		public int init, def, attack, point, ID;

		public string itemName;
		public string ItemName {
			get {
				return itemName;
			}
			set {
				itemName = value;
			}
		}

//		public string ItemName
//		{
//			get{
//				return ItemName;  
//			}
//			set{
////				if( )//condition sur le nombre de point stuff restant
////				{
//					this.ItemName = 5;
////				}
//			}
//		}

		public void createItem( string itemname ) {
			switch(itemname) {
				case "Bouclier_rectangulaire":
					new Bouclier_rectangulaire ();
					break;
				case "Casque":
					new Casque ();
					break;
				case "Dagues":
					new Dagues ();
					break;
				case "Epée":
					new Epee ();
					break;
				case "Filet":
					new Filet ();
					break;
				case "Lance":
					new Lance ();
					break;
				case "Petit_Bouclier_Rond":
					new Petit_Bouclier_Rond ();
					break;
				case "Trident":
					new Trident ();
					break;
				default:
					break;

			}
		}


		public string PresenterStuff()
		{
			return " Item " + this.ID + ": " + this.ItemName + ", initiative: " + this.init + ", Défense: " + this.def + ", Attaque: " + this.attack + ", Point d'équipements: " + this.point;
		}

	}
}