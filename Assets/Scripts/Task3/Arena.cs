using UnityEngine;

namespace Assets.Scripts
{
    public class Arena
    {
        private string s_heroName;
        private string s_enemyName;
        private string s_st;

        private float heroDamage;
        private float enemyDamage;

        public void Run(IUnit hero, IUnit enemy, int rounds)
        {
            s_heroName = hero.GetName();
            s_enemyName = enemy.GetName();
            s_st = $"{s_heroName} ( {hero.GetHp()} HP) против ";
            s_st += $"{s_enemyName} ({enemy.GetHp()} HP)";
            Debug.Log(s_st);

            Weapone hw = hero.GetWeapone();
            Weapone ew = enemy.GetWeapone();
            int hWDamage = hw.damage;
            int eWDamage = ew.damage;
            Element hElement = hw.element;
            Element eElement = ew.element;
            float hArmor = hero.GetArmor();
            float eArmor = enemy.GetArmor();

            for (int i = 0; i < rounds; i++)
            {
                heroDamage = CalculateTheDamage.CalculateDamage(hero.GetDamage() + hWDamage, eArmor, hElement, eElement,
                    hero.GetKrit());
                enemy.SubtractHp(heroDamage);
                s_st = $"Раунд {i}:{hero.GetName()} наносит {heroDamage} у противника {enemy.GetHp()};";

                if (enemy.IsAlive())
                {
                    enemyDamage = CalculateTheDamage.CalculateDamage(enemy.GetDamage() + eWDamage, hArmor, eElement,
                        hElement, enemy.GetKrit());
                    hero.SubtractHp(enemyDamage);
                    s_st += $"{enemy.GetName()} наносит {enemyDamage} у героя {hero.GetHp()}";
                    if (!hero.IsAlive())
                    {
                        Debug.Log("Поражение");
                        return;
                    }
                }
                else
                {
                    Debug.Log($"Победа у героя осталось {hero.GetHp()} HP");
                    return;
                }

                Debug.Log(s_st);
            }

            Debug.Log($"Ничья у героя осталось {hero.GetHp()} HP, у {enemy.GetName()} осталось {enemy.GetHp()} HP");
        }
    }
}