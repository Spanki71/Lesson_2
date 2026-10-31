namespace Assets.Scripts
{
    public interface IFight
    {
        public float GetDamage();
        public void SubtractHp(float countHp);
        public float GetKrit();
    }
}