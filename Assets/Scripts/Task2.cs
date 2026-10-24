using Assets.Scripts;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Task2 : MonoBehaviour//inventory, переписал в MonoBehaviour, потому что мне нужен вывод(Debug.Log)
{
	private void Start()
	{
		AddItem("Меч", 1);
		AddItem("Щит", 1);
		AddItem("Меч", 1);

		AddItem("Зелье", 1);
		AddItem("Лук", 1);
		AddItem("Стрелы", 1);

		AddItem("проверка 6", 1);
		AddItem("проверка 7", 1);
		AddItem("проверка 8", 1);
		AddItem("проверка 9", 1);
		AddItem("проверка 10", 1);
		AddItem("проверка 11", 1);

		RemoveItem("Меч", 1);
		RemoveItem("Меч", 1);
		RemoveItem("Меч", 1);
		RemoveItem("Амбассадор", 1);

		Print();
	}
	List<Item> _items = new List<Item>(10);
	int _count = 0;
	void Print()
	{
		string st = "Состояние инвентаря: \n";
		for (int i = 0; i < _count; i++)
		{
			st += _items[i].Name + " x" + _items[i].Count + "\n";
		}
		st += "Занято " + _count + " из 10";
		Debug.Log(st);// Думал, что что-то не выводит, а там надо раскрыть вывод
	}
	public void AddItem(String Name, int Count)
	{
		if (Count < 1)
		{
			Debug.Log("Нельзя добавить такое кол-во");
			return;
		}

		for (int i = 0; i < _items.Count; i++)
		{
			if (_items[i].Name == Name)
			{
				_items[i].Count += Count;
				Debug.Log("Добавлено:" + _items[i].Name + " x" + Count);
				return;
			}
		}
		if (_count < 10)
		{
			_items.Add(new Item(Name, Count));
			_count++;
			Debug.Log("Добавлен новый предмет:" + Name + " x" + Count);
			return;
		}
		// Мест нет
		Debug.Log("Нет свободного места в инвенторе");

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
					Debug.Log("Удалено: " + _items[i].Name + " x" + _countToRemove);
					return;
				}
				else if (_items[i].Count == _countToRemove)
				{
					_items.Remove(_items[i]);
					_count--;
					Debug.Log("Теперь совсем нет: " + Name);
					return;
				}
				else
				{
					// Удаляется больше чем есть
					Debug.Log("Вы пытаетесь удалить" + Name + "больше чем у вас имеется");
				}
			}
		}
		// Предмет не найден
		Debug.Log("Такого предмета нет в инвентаре");
	}
}
public class Item
{
	public Item(String Name, int Count)
	{
		this.Name = Name;
		this.Count = Count;
	}
	public Item()
	{
		Name = null;
		Count = 0;
	}
	public String Name;
	public int Count;
}

