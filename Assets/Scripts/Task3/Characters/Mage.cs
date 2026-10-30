using System.Text;

namespace Assets.Scripts
{
	public class Mage : BaseCharacter, IUnit
	{
		HeroClass heroClass = HeroClass.Mage;
		public Mage()
		{
			this.name = "Mage";
			this.hp = 130;
			minDamage = 6;
			maxDamage = 12;
		}
	}
}
