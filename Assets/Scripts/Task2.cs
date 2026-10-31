using Assets.Scripts;
using UnityEngine;

namespace Assets.Scripts
{
	public class Task2 : MonoBehaviour
	{
		private void Start()
		{
			Inventory inv = new Inventory();
			
			inv.RemoveItem("Амбассадор", 1);
			
			Item item = new Weapone("Меч", 1, 10, Element.None);
			inv.AddItem(item);
			Item item1 = new Armor("Щит", 1, 5, Element.None);
			Debug.Log($"Тип предмета щита {item1.itemType}");
			inv.AddItem(item1);
			Item item2 = new Weapone("Меч", 1, 10, Element.None);
			inv.AddItem(item2);
			Item item3 = new Other("Зелье", 1);
			inv.AddItem(item3);
			Item item4 = new Weapone("Лук", 1, 10, Element.None);
			inv.AddItem(item4);
			Item item5 = new Other("Стрела", 1);
			Item item6 = new Weapone("Лук", 1, 10, Element.None);
			inv.AddItem(item6);
			
			inv.Print();

			item.name = "Meч";

			inv.RemoveItem("Меч", 1);
			inv.RemoveItem("Меч", 10);
			item.name = "Амбассадор";
			inv.RemoveItem("Амбассадор", 1);

			inv.Print();
		}

	}
}