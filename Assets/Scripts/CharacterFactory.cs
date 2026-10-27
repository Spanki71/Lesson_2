using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.Scripts
{
	public class CharacterFactory
	{
		public Unit CreateHero(HeroClass Class)
		{
			switch (Class)
			{
				case HeroClass.Warrior:
					return new Warrior();
				case HeroClass.Mage:
					return new Warrior();
			}
			return new Warrior();
		}
		public Unit CreateEnemy()
		{
			System.Random random = new System.Random();
			switch (random.Next(0, 3))
			{
				case 0:
					return new Goblin();
				case 1:
					return new Ork();
				case 2:
					return new Troll();
			}
			return null;
		}
	}
}
