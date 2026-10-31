namespace Assets.Scripts
{
    public class Weapone : Item
    {
        public int damage;
        public Element element;
        public Weapone(string name, int count, int damage, Element element) : base(name, count)
        {
            name = base.name;
            count = base.count;
            this.damage = damage;
            this.element = element;
            this.itemType = ItemType.Weapone;
        }
    }
}