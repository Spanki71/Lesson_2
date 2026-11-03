using System;

namespace Assets.Scripts
{
    public class Weapone : Item
    {
        public int damage;
        public Element element;
        private ItemType type =  ItemType.Weapone;
        
        public static Weapone CreateRandom()
        {
            Random rand = new Random();
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
                    return new Weapone("Меч", 1, rand.Next(5, 25), e);
                case 1:
                    return new Weapone("Булава", 1, rand.Next(5, 25), e);
                case 2:
                    return new Weapone("Копье", 1, rand.Next(5, 25), e);
                default:
                    return new Weapone("Меч", 1, rand.Next(5, 25), e);
            }
        }
        
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