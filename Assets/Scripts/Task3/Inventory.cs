using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;

namespace Assets.Scripts
{
	public class Inventory
	{
		public List<Item> _items = new List<Item>(10);
		int _count = 0;
		public string Print()
		{
			string st = "";
			for (int i = 0; i < _items.Count; i++)
			{
				st += _items[i].Name + " x" + _items[i].Count + "\n";
			}
			return st;
		}
		public void AddItem(String Name, int Count)
		{
			if (Count < 1)
			{
				return;
			}

			for (int i = 0; i < _items.Count; i++)
			{
				if (_items[i].Name == Name)
				{
					_items[i].Count += Count;
					return;
				}
			}
			if (_count < 10)
			{
				_items.Add(new Item(Name, Count));
				_count++;
				return;
			}
			// Мест нет
		}
		public void AddItem(String Name, int Count, int efficiency)
		{
			if (Count < 1)
			{
				return;
			}

			for (int i = 0; i < _items.Count; i++)
			{
				if (_items[i].Name == Name)
				{
					_items[i].Count += Count;
					return;
				}
			}
			if (_count < 10)
			{
				_items.Add(new Item(Name, Count, efficiency));
				_count++;
				return;
			}
			// Мест нет
		}
		public void AddItem(String Name, int Count, int efficiency, Element element)
		{
			if (Count < 1)
			{
				return;
			}

			for (int i = 0; i < _items.Count; i++)
			{
				if (_items[i].Name == Name)
				{
					_items[i].Count += Count;
					return;
				}
			}
			if (_count < 10)
			{
				_items.Add(new Item(Name, Count, efficiency, element));
				_count++;
				return;
			}
			// Мест нет
		}
		public void RemoveItem(String Name, int CountToRemove)
		{
			int _countToRemove = CountToRemove;
			for (int i = 0; i < _count; i++)
			{
				if (_items[i].Name == Name)
				{
					if (_items[i].Count > _countToRemove)
					{
						_items[i].Count -= _countToRemove;
						return;
					}
					else if (_items[i].Count == _countToRemove)
					{
						_items.Remove(_items[i]);
						_count--;
						return;
					}
					else 
					{
						// Удаляется больше чем есть
					}
				}
			}
			// Предмет не найден
		}
	}
	public class Item
	{
		public Item(String Name, int Count)
		{
			this.Name = Name;
			this.Count = Count;
		}
		public Item(String Name, int Count, int efficiency)
		{
			this.efficiency = efficiency;
			this.Name = Name;
			this.Count = Count;
		}
		public Item(String Name, int Count, int efficiency, Element _element)
		{
			this.efficiency = efficiency;
			this.Name = Name;
			this.Count = Count;
			element = _element;
		}
		public Item()
		{
			Name = null;
			Count = 0;
		}
		public String Name;
		public int Count;
		public float efficiency;
		public Element element;
	}
}
