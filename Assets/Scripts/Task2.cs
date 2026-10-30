using Assets.Scripts;
using UnityEngine;

namespace Assets.Scripts
{
	public class Task2 : MonoBehaviour
	{
		private void Start()
		{
			Inventory inv = new Inventory();

			Item item = new Item("Меч", 1);
			inv.AddItem(item);
			item.name = "Щит";
			inv.AddItem(item);
			item.name = "Меч";
			inv.AddItem(item);
			inv.AddItem(item);
			item.name = "Зелье";
			inv.AddItem(item);
			item.name = "Лук";
			inv.AddItem(item);
			item.name = "Стрелы";


			item.name = "Meч";

			inv.RemoveItem(item, 1);
			inv.RemoveItem(item, 10);
			item.name = "Амбассадор";
			inv.RemoveItem(item, 1);

			inv.Print();
		}

	}
}