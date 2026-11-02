using System;

namespace Assets.Scripts
{
	public class CharacterFactory
	{
		
		
		public IUnit CreateHero(HeroClass heroClass)
		{
			switch (heroClass)
			{
				case HeroClass.Warrior:
					return new Warrior();;
				case HeroClass.Mage:
					return new Mage();
				default:
					return new Warrior();
			}
		}
		public IUnit CreateRandomHero()
		{
			Random r = new Random();
			switch (r.Next(0, 2))
			{
				case 0:
					return new Warrior();
				case 1:
					return new Mage();
			}
			return null;
		}
		public IUnit CreateEnemy()
		{
			Random r = new Random();
			switch (r.Next(0, 3))
			{
				case 0:
					return new Goblin();
				case 1:
					return new Ork();
				case 2:
					return new Troll();
				default:
					return new Goblin();
			}
		}
	}
}

