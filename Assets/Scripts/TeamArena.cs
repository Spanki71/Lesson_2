using UnityEngine;

namespace Assets.Scripts
{
    public class TeamArena
    {
        public float krit = 3.0f;

        public void Run(Team heroTeam, Team enemyTeam, int rounds)
        {
            string debugInfo;
            
            if (heroTeam.units.Count == 0 || enemyTeam.units.Count == 0)
            {
                Debug.Log("Введите корректное колличество участников команд");
                return;
            }

            for (int i = 0; i < rounds; i++)
            {
                IUnit tempUnit = enemyTeam.units[0];
                Weapone hWeapone; 
                float hArmor; 
                Weapone eWeapone = tempUnit.GetWeapone(); 
                float eArmor = tempUnit.GetArmor();
                Debug.LogWarning($"раунд {i}");
                foreach (var hero in heroTeam.units)
                {
                    hWeapone = hero.GetWeapone();
                    float damage = hero.GetDamage() + CalculateTheDamage.CalculateDamage(hWeapone.damage,
                            eArmor,
                            hWeapone.element,
                            eWeapone.element,
                            krit,
                            out debugInfo);
                    
                    tempUnit.SubtractHp(damage);
                    Debug.Log($"{hero.GetName()} наносит: {damage} по {tempUnit.GetName()}");

                    if (!tempUnit.IsAlive())
                    {
                        if (enemyTeam.units.Count > 1)
                        {
                            enemyTeam.RemoveUnit(enemyTeam.units[0]);
                            Debug.Log($"{tempUnit.GetName()} умер, осталось противников {enemyTeam.units.Count}");
                            
                            tempUnit = enemyTeam.units[0];
                            eWeapone = tempUnit.GetWeapone();
                            eArmor = tempUnit.GetArmor();
                        }
                        else
                        {
                            Debug.Log("Герои победили");
                            return;
                        }
                    }
                }
                
                tempUnit = heroTeam.units[0];
                hWeapone = tempUnit.GetWeapone();
                hArmor = tempUnit.GetArmor();

                foreach (var enemy in enemyTeam.units)
                {
                    eWeapone = enemy.GetWeapone();
                    float damage = enemy.GetDamage() + CalculateTheDamage.CalculateDamage(eWeapone.damage,
                        hArmor,
                        eWeapone.element,
                        hWeapone.element,
                        krit,
                        out debugInfo);
                    
                    tempUnit.SubtractHp(damage);
                    Debug.Log($"{enemy.GetName()} наносит: {damage} по {tempUnit.GetName()}");
                    if (!tempUnit.IsAlive())
                    {
                        if (heroTeam.units.Count > 1)
                        {
                            heroTeam.RemoveUnit(tempUnit);
                            Debug.Log($"{tempUnit.GetName()} умер, осталось героев {heroTeam.units.Count}");
          
                            tempUnit = heroTeam.units[0];
                            hWeapone = tempUnit.GetWeapone();
                            hArmor = tempUnit.GetArmor();
                        }
                        else
                        {
                            Debug.Log("Противники победили");
                            return;
                        }
                    }
                }
            }
            
            Debug.Log("Ничья");
        }
    }
}