namespace Assets.Scripts
{
    public interface IFight
    {
        public int GetDamage();
        public float GetArmor();
        public void SubtractHp(int countHp);
    }
}