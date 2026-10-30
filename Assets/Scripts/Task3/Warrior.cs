using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.Scripts
{
	public class Warrior : IUnit
	{
		string Name = "Hero";
		int HP = 100;
		int MinDamage = 10;
		int MaxDamage = 16;
		HeroClass Class;
		
		public Inventory _inventory = new Inventory();
		bool _isAlive = true;
		public string GetName()
		{
			return Name;
		}
		public int GetDamage()
		{
			System.Random r = new System.Random();
			return r.Next(MinDamage, MaxDamage);
		}
		public int GetHP()
		{
			return HP;
		}
		public void SubtractHP(int countHP)
		{
			if (countHP >= HP)
			{
				HP = 0;
				_isAlive = false;
			}
			else
			{
				HP -= countHP;
			}
		}
		public bool IsAlive()
		{
			return _isAlive;
		}
		
		public HeroClass GetClass()
		{
			return Class;
		}
		
		public Item GetWeapone()
		{
			foreach (var _item in _inventory._items)
			{
				if (_item.Name == "Weapone")
				{
					return _item;
				}
			}
			return null;
		}
		
		public float GetArmor()
		{
			foreach (var _item in _inventory._items)
			{
				if (_item.Name == "Armor")
				{
					return _item.efficiency;
				}
			}
			return 0.0f;
		}
		
		public void SetWeapone(Item Weapone)
		{
            foreach (var _item in _inventory._items)
            {
                if (_item.Name == "Weapone")
                {
					_item.efficiency = Weapone.efficiency;
                }
            }
        }
	}
}
