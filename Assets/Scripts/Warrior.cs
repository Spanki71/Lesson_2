using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.Scripts
{
	public class Warrior : Unit
	{
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
		string Name = "Hero";
		int HP = 100;
		int MinDamage = 10;
		int MaxDamage = 16;

	}
}
