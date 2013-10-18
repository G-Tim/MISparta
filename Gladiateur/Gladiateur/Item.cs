using System;

namespace Gladiateur
{
	public class Item
	{
		private string p_ItemName;
		public int init, def, attack, point;
		public string ItemName ()
		{
			get{
				return p_ItemName; 
			}
			protected set{
				if()//condition sur le nombre de point stuff restant
				{
					this.p_ItemName = 5;
				}
			}
		}


		public Item ()
		{

		}
		public Item (int p_ID, string p_ItemName, int p_init, int p_def, int p_attack, int p_point)
		{
			this.ID = p_ID,
			this.ItemName = p_ItemName;
			this.init = p_init;
			this.def = p_def;
			this.attack = p_attack;
			this.point = p_point;
			// { ID, NomItem, Init, Def, Atk, point} 
		}
	}
