using System;

namespace Assets.Scripts
{
	public class CharacterFactory
	{
		private Random m_rand = new Random();
		public IUnit CreateHero(HeroClass heroClass)
		{
			switch (heroClass)
			{
				case HeroClass.Warrior:
					return new BaseCharacter("Warrior" ,100.0f, 10, 16);
				case HeroClass.Mage:
					return new BaseCharacter("Mage" ,130.0f, 6, 12);
				default:
					return new BaseCharacter("Warrior" ,100.0f, 10, 16);
			}
		}

		public IUnit CreateRandomHero()
		{
			switch (m_rand.Next(0, 2))
			{
				case 0:
					return new BaseCharacter("Warrior" ,100.0f, 10, 16);
				case 1:
					return new BaseCharacter("Mage" ,130.0f, 6, 12);
			}
			return null;
		}

		public IUnit CreateEnemy()
		{
			switch (m_rand.Next(0, 3))
			{
				case 0:
					return new BaseCharacter("Goblin" ,50.0f, 4, 8);
				case 1:
					return new BaseCharacter("Ork" ,80.0f, 5, 10);
				case 2:
					return new BaseCharacter("Troll" ,140.0f, 8, 12);
				default:
					return new BaseCharacter("Goblin" ,50.0f, 4, 8);
			}
		}
	}
}

