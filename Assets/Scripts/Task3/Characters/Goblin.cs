using System.Text;

namespace Assets.Scripts
{
	public class Goblin : BaseCharacter, IUnit
	{
		public Goblin()
		{
			this.name = "Goblin";
			this.hp = 50;
			minDamage = 4;
			maxDamage = 8;
		}
	}
}
