using UnityEngine;

namespace Assets.Scripts
{
    public class Arena
    {
        private string s_heroName;
        private string s_enemyName;
        private string s_st;

        private int heroDamage;
        private int enemyDamage;
        
        public void Run(IUnit hero, IUnit enemy, int rounds)
        {
            s_heroName = hero.GetName();
            s_enemyName = enemy.GetName();
            s_st = $"{s_heroName} ( {hero.GetHp()} HP) против ";
            s_st += $"{s_enemyName} ({enemy.GetHp()} HP)";
            Debug.Log(s_st);
            
            
            for (int i = 0; i < rounds; i++)
            {
                //heroDamage = CalculateTheDamage.CalculateDamage(hero.GetDamage(), enemy.GetArmor(), hero.GetWeapone);
                heroDamage = hero.GetDamage();
                enemy.SubtractHp(heroDamage);
                s_st = $"Раунд {i}:{hero.GetName()} наносит {heroDamage} у противника {enemy.GetHp()};";

                if (enemy.IsAlive())
                {
                    enemyDamage = enemy.GetDamage();
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
