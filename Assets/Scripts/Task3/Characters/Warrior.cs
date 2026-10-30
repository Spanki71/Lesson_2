using System.Text;

namespace Assets.Scripts
{
	public class Warrior : BaseCharacter,  IUnit
	{
		HeroClass heroClass = HeroClass.Warrior;
		public Warrior()
		{
			this.name = "Warrior";
			this.hp = 100;
			minDamage = 10;
			maxDamage = 16;
		}
	}
}
