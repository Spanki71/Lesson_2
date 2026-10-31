namespace Assets.Scripts
{
    public abstract class BaseCharacter : IUnit
    {
        public Inventory inventory = new Inventory();
        public bool isAlive = true;
        public string name = "Hero";
        public float hp = 100.0f;
        public int minDamage = 10;
        public int maxDamage = 16;
        public float krit = 0.3f;

        public string GetName()
        {
            return name;
        }

        public float GetDamage()
        {
            System.Random r = new System.Random();
            return r.Next(minDamage, maxDamage);
        }

        public float GetHp()
        {
            return hp;
        }

        public void SubtractHp(float countHp)
        {
            if (countHp >= hp)
            {
                hp = 0;
                isAlive = false;
            }
            else
            {
                hp -= countHp;
            }
        }

        public bool IsAlive()
        {
            return isAlive;
        }

        public Weapone GetWeapone()
        {
            foreach (var item in inventory.items)
            {
                if (item is Weapone weapone)
                {
                    return weapone;
                }
            }

            return null;
        }

        public float GetArmor()
        {
            foreach (var item in inventory.items)
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
            return krit;
        }

        public void AddItem(Item item)
        {
            inventory.AddItem(item);
        }
    }
}