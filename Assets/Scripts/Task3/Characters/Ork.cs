using System.Text;

namespace Assets.Scripts
{
	public class Ork : BaseCharacter,   IUnit
	{
		public Ork()
		{
			this.name = "Ork";
			this.hp = 80;
			minDamage = 5;
			maxDamage = 10;
		}
	}
}
