using System;
namespace Assets.Scripts
{
    public static class CalculateTheDamage
    {
        public static string CalculateDamageString(float damage, float armor, Element selfElement, Element enemyElement, float krit)
        {
            float baseDamage;
            
            if (selfElement == enemyElement)
            {
                return "Урон не нанесен";
            }
            string st = "(";
            
            if (damage > armor)
            {
                baseDamage = damage - armor;
            }
            else
            {
                baseDamage = 1;
            }

            if (selfElement != enemyElement)
            {
                baseDamage = (float)Math.Floor(baseDamage * 1.5f);
                st += "стихия x1,5, ";
            }
            else
            {
                st += "без стихии, ";
            }
            
            System.Random random = new System.Random();
            
            if (random.Next(0, 100) < (krit * 100.0f))
            {
                baseDamage *= 2.0f;
                st += "крит x2)";
            }
            else
            {
                st += "без крита)";
            }
            
            return $"{baseDamage} урона {st}";
        }
        
        public static float CalculateDamage(float damage, float armor, Element selfElement, Element enemyElement, float krit)
        {
            float baseDamage;
            
            if (selfElement == enemyElement)
            {
                return 0.0f;
            }
            
            if (damage > armor)
            {
                baseDamage = damage - armor;
            }
            else
            {
                baseDamage = 1;
            }

            if (selfElement != enemyElement)
            {
                baseDamage = (float)Math.Floor(baseDamage * 1.5f);
            }
            
            System.Random random = new System.Random();
            
            if (random.Next(0, 100) < (krit * 100.0f))
            {
                baseDamage *= 2.0f;
            }

            return baseDamage;
        }
    }
}