using UnityEngine;
using System.Collections.Generic;
namespace Assets.Scripts
{
	public class Inventory
	{
		public List<Item> items = new List<Item>(10);
		int count = 0;

		public void Print()
		{
			string st = "Состояние инвентаря: \n";
			
			for (int i = 0; i < count; i++)
			{
				st += $"{items[i].name} x {items[i].count}\n";
			}

			st += $"Занято {count} из 10";
			Debug.Log(st);
		}

		public void AddItem(Item item)
		{
			int addCount = item.count;
			string name = item.name;
			if (item == null)
			{
				Debug.Log("Невозможно добавить в инвентарь");
				return;
			}

			for (int i = 0; i < items.Count; i++)
			{
				if (items[i].name == name)
				{
					items[i].count += addCount;
					Debug.Log($"Добавлено: {items[i].name} x {addCount}");
					return;
				}
			}

			if (count < 10)
			{
				items.Add(item);
				Debug.Log($"Добавлен новый предмет: {name} x {addCount}");
				count++;
				return;
			}

			Debug.Log("Нет свободного места в инвенторе");
		}
		
		public void RemoveItem(string item, int countToRemove)
		{
			for (int i = 0; i < count; i++)
			{
				if (items[i].name == item)
				{
					if (items[i].count > countToRemove)
					{
						items[i].count -= countToRemove;
						Debug.Log($"Удалено: {item} x {countToRemove}");
						return;
					}
					else if (items[i].count == countToRemove)
					{
						items.Remove(items[i]);
						count--;
						Debug.Log($"Полностью удалено: {item} x {countToRemove}");
						return;
					}
					else
					{
						Debug.Log("Нельзя столько удалить");
					}
				}
			}
			
			Debug.LogWarning($"{item} нет в инвентаре");
		}
	}
}