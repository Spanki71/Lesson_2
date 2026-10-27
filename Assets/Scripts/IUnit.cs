using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.Scripts
{
	public interface Unit
	{
		int GetDamage();
		string GetName();
		int GetHP();
		void SubtractHP(int count);
		bool IsAlive();
	}
}
