namespace Assets.Scripts
{
    public class Other : Item
    {
        ItemType type = ItemType.Other;
        public Other(string name, int count) : base(name, count)
        {
            name = base.name;
            count = base.count;
        }
    }
}