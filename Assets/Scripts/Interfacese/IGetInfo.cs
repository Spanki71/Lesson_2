namespace Assets.Scripts
{
    public interface IGetInfo
    {
        public string GetName();
        public float GetHp();
        public bool IsAlive();
        public Weapone GetWeapone();
        public float GetArmor();
    }
}