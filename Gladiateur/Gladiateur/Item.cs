using System;

namespace Gladiateur
{
	public class Item
	{
		public Item ()
		{
			string [][] Item = new string[][]; 
			// { ID, NomItem, Init, Def, Atk, point} 
			Item[0] = {1,"Dague", 1, 0, 60, 2}; 
			Item[1] = {2,"Epée", 2, 0, 70 ,5}; 
			Item[2] = {3,"Lance"};
			Item[3] = {4,"Trident"};
			Item[4] = {5,"Filet"};
			Item[5] = {6,"Petit Bouclier Rond"};
			Item[6] = {7,"Bouclier rectangulaire"};
			Item[7] = {8,"Casque"};

		} 
	}
}


int[][] myIntArray = new int[2][]; 
myIntArray[0] = new int[5];
myIntArray[0][1] = 42;