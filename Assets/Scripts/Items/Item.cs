using System;

namespace Assets.Scripts
{
    public abstract class Item
    {
        public ItemType itemType =  ItemType.Other;
        public String name;
        public int count;
        
        public Item(String name, int count)
        {
            this.name = name;
            this.count = count;
        }

    }
}