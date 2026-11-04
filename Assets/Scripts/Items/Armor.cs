using System;

namespace Assets.Scripts
{
    public class Armor : Item
    {
        private static Random rand = new Random();
        public int hpArmor;
        public Element element;
        private ItemType type = ItemType.Armor;
        
        public static Armor CreateRandom()
        {
            Element e = Element.None;
            
            switch (rand.Next(0, 5))
            {
                case 0:
                    e = Element.Eart;
                    break;
                case 1:
                    e = Element.Fire;
                    break;
                case 2:
                    e = Element.Ice;
                    break;
                case 3:
                    e = Element.Wather;
                    break;
                case 4:
                    e = Element.Fire;
                    break;
            }

            switch (rand.Next(0, 3))
            {
                case 0:
                    return new Armor("Щит", 1, rand.Next(5, 25), e);
                case 1:
                    return new Armor("Кольчуга", 1, rand.Next(5, 25), e);
                case 2:
                    return new Armor("Латы", 1, rand.Next(5, 25), e);
                default:
                    return new Armor("Шлем", 1, rand.Next(5, 25), e);
            }
        }
        
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