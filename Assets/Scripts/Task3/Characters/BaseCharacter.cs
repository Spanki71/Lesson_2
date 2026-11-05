using System;

namespace Assets.Scripts
{
    public class BaseCharacter// : IUnit
    {
        private Inventory m_inventory = new Inventory();
        private string m_name = "Hero";
        private float m_hp = 100.0f;
        private int m_damage;
        private float m_krit = 0.3f;
        private bool m_isAlive = true;

        public BaseCharacter(string name,float hp,int minDamage,int maxDamage)
        {
            m_name = name;
            m_hp = hp;
            Random r =  new Random();
            m_damage = r.Next(minDamage, maxDamage);
        }

        public string GetName()
        {
            return m_name;
        }

        public float GetDamage()
        {
            return m_damage;
        }

        public float GetHp()
        {
            return m_hp;
        }

        public void SubtractHp(float countHp)
        {
            if (countHp >= m_hp)
            {
                m_hp = 0;
                m_isAlive = false;
            }
            else
            {
                m_hp -= countHp;
            }
        }

        public bool IsAlive()
        {
            return m_isAlive;
        }

        public Weapone GetWeapone()
        {
            foreach (var item in m_inventory.items)
            {
                if (item.itemType == ItemType.Weapone)
                {
                    return (Weapone)item;
                }
            }
            return null;
        }

        public float GetArmor()
        {
            foreach (var item in m_inventory.items)
            {
                if (item is Armor armor )
                {
                    return armor.hpArmor;
                }
            }

            return 0.0f;
        }

        public float GetKrit()
        {
            return m_krit;
        }

        public void AddItem(Item item)
        {
            m_inventory.AddItem(item);
        }
    }
}