namespace Assets.Scripts
{
	public class Warrior : BaseCharacter,  IUnit
	{
		public Warrior()
		{
			this.name = "Warrior";
			this.hp = 100;
			minDamage = 10;
			maxDamage = 16;
		}
	}
}
