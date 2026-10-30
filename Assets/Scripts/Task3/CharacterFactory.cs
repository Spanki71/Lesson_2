using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.Scripts
{
	public class CharacterFactory
	{
		public Element RandomElement()
		{
			Random r = new Random();
			switch (r.Next(0, 5))
			{
				case 0:
					return Element.Eart;
				case 1:
					return Element.Ice;
				case 2:
					return Element.Wather;
				case 3:
					return Element.Fire;
				case 4:
					return Element.None;
			}
			return Element.None;
		}
		
		
		
		public IUnit CreateHero(HeroClass Class)
		{
			switch (Class)
			{
				case HeroClass.Warrior:
					Warrior Warrior = new Warrior();
					Random r = new Random();
					Warrior._inventory.AddItem("Weapone", 1, r.Next(10, 16), RandomElement());
					Warrior._inventory.AddItem("Armor", 1, r.Next(2, 15));
					return Warrior;
				case HeroClass.Mage:
					Mage Mage = new Mage();
					r = new Random();
					Mage._inventory.AddItem("Weapone", 1, r.Next(5, 25), RandomElement());
					Mage._inventory.AddItem("Armor", 1, r.Next(2, 15));
					return Mage;
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
					Warrior Warrior = new Warrior();
					r = new Random();
					Warrior._inventory.AddItem("Weapone", 1, r.Next(5, 25), RandomElement());
					Warrior._inventory.AddItem("Armor", 1, r.Next(2, 15));
					return Warrior;
				case 1:
					Mage Mage = new Mage();
					r = new Random();
					Mage._inventory.AddItem("Weapone", 1, r.Next(5, 25), RandomElement());
					Mage._inventory.AddItem("Armor", 1, r.Next(2, 15));
					return Mage;
			}
			return null;
		}
		public IUnit CreateEnemy()
		{
			Random r = new Random();
			switch (r.Next(0, 3))
			{
				case 0:
					Goblin Goblin = new Goblin();
					r = new Random();
					Goblin._inventory.AddItem("Weapone", 1, r.Next(4, 8), RandomElement());
					Goblin._inventory.AddItem("Armor", 1, r.Next(0, 10));
					return Goblin;
				case 1:
					Ork Ork = new Ork();
					r = new Random();
					Ork._inventory.AddItem("Weapone", 1, r.Next(5, 10), RandomElement());
					Ork._inventory.AddItem("Armor", 1, r.Next(0, 10));
					return Ork;
				case 2:
					Troll Troll = new Troll();
					r = new Random();
					Troll._inventory.AddItem("Weapone", 1, r.Next(8, 12), RandomElement());
					Troll._inventory.AddItem("Armor", 1, r.Next(0, 10));
					return Troll;
			}
			return null;
		}
	}
}
