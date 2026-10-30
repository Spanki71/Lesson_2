using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.Scripts
{
	public interface IUnit
	{
		int GetDamage();
		string GetName();
		int GetHP();
		void SubtractHP(int count);
		bool IsAlive();
		HeroClass GetClass();
		Item GetWeapone();
		float GetArmor();
		void SetWeapone(Item Weapone);
	}
}
