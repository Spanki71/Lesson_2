namespace Assets.Scripts
{
    public abstract class BaseCharacter : IUnit
    {
        public Inventory inventory = new Inventory();
        public bool isAlive = true;
        public string name = "Hero";
        public int hp = 100;
        public int minDamage = 10;
        public int maxDamage = 16;

        public string GetName()
        {
            return name;
        }

        public int GetDamage()
        {
            System.Random r = new System.Random();
            return r.Next(minDamage, maxDamage);
        }

        public int GetHp()
        {
            return hp;
        }

        public void SubtractHp(int countHp)
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

        public Item GetWeapone()
        {
            foreach (var item in inventory.items)
            {
                if (item.name == "Weapone")
                {
                    return item;
                }
            }

            return null;
        }

        public float GetArmor()
        {
            foreach (var item in inventory.items)
            {
                if (item.name == "Armor")
                {
                    return item.efficiency;
                }
            }

            return 0.0f;
        }
    }
}