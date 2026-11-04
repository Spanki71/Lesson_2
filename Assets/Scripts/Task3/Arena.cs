using UnityEngine;

namespace Assets.Scripts
{
    public class Arena
    {
        private string m_heroName;
        private string m_enemyName;
        private string m_st;

        private float m_heroDamage;
        private float m_enemyDamage;

        public void Run(IUnit hero, IUnit enemy, int rounds)
        {
            m_heroName = hero.GetName();
            m_enemyName = enemy.GetName();
            m_st = $"{m_heroName} ( {hero.GetHp()} HP) против ";
            m_st += $"{m_enemyName} ({enemy.GetHp()} HP)";
            Debug.Log(m_st);

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
                string debugInfo;
                m_heroDamage = CalculateTheDamage.CalculateDamage(hero.GetDamage() + hWDamage,
                    eArmor,
                    hElement,
                    eElement,
                    hero.GetKrit(),
                    out debugInfo);
                enemy.SubtractHp(m_heroDamage);
                m_st = $"Раунд {i}:{hero.GetName()} наносит {m_heroDamage} у противника {enemy.GetHp()};";

                if (enemy.IsAlive())
                {
                    m_enemyDamage = CalculateTheDamage.CalculateDamage(enemy.GetDamage() + eWDamage,
                        hArmor,
                        eElement,
                        hElement,
                        enemy.GetKrit(),
                        out debugInfo);
                    hero.SubtractHp(m_enemyDamage);
                    m_st += $"{enemy.GetName()} наносит {m_enemyDamage} у героя {hero.GetHp()}";
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

                Debug.Log(m_st);
            }

            Debug.Log($"Ничья у героя осталось {hero.GetHp()} HP, у {enemy.GetName()} осталось {enemy.GetHp()} HP");
        }
    }
}