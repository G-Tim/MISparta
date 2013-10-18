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


		public Item ()
		{

		}
		public Item (int p_ID, string p_ItemName, int p_init, int p_def, int p_attack, int p_point)
		{
			this.ID = p_ID;
			this.itemName = p_ItemName;
			this.init = p_init;
			this.def = p_def;
			this.attack = p_attack;
			this.point = p_point;
			// { ID, NomItem, Init, Def, Atk, point} 
		}


		public string PresenterStuff()
		{
			return " Item " + this.ID + ": " + this.itemName + ", initiative: " + this.init + ", Défense: " + this.def + ", Attaque: " + this.attack + ", Point d'équipements: " + this.point;
		}

	}
}