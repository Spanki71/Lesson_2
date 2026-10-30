using System;

namespace Assets.Scripts
{
    public class Item
    {
        public String name;
        public int count;
        public float efficiency;
        public Element element;
        
        public Item(String name, int count)
        {
            this.name = name;
            this.count = count;
        }

        public Item(String name, int count, int efficiency)
        {
            this.efficiency = efficiency;
            this.name = name;
            this.count = count;
        }

        public Item(String name, int count, int efficiency, Element element)
        {
            this.name = name;
            this.count = count;
            this.efficiency = efficiency;
            this.element = element;
        }

        public Item()
        {
            name = null;
            count = 0;
        }

    }
}