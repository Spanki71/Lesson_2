namespace Assets.Scripts
{
    public class Armor : Item
    {
        
        public int hpArmor;
        public Element element;
        public Armor(string name, int count, int hpArmor, Element element) : base(name, count)
        {
            name = base.name;
            count = base.count;
            this.hpArmor = hpArmor;
            this.element = element;
            this.itemType = ItemType.Armor;
        }
    }
}