namespace Assets.Scripts
{
	public class Mage : BaseCharacter, IUnit
	{
		public Mage()
		{
			this.name = "Mage";
			this.hp = 130;
			minDamage = 6;
			maxDamage = 12;
		}
	}
}
