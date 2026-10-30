using System.Text;

namespace Assets.Scripts
{
	public class Troll : BaseCharacter,   IUnit
	{
		public Troll()
		{
			this.name = "Troll";
			this.hp = 140;
			minDamage = 8;
			maxDamage = 12;
		}
	}
}
