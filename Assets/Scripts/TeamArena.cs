using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class TeamArena
    {
        public float krit = 3.0f;

        public void Run(Team heroTeam, Team enemyTeam, int rounds)
        {
            int tempIndex = 0;
            IUnit tempUnit = enemyTeam.units[tempIndex];
            Weapone hw;
            Weapone ew = tempUnit.GetWeapone();
            for (int i = 0; i < rounds; i++)
            {

                foreach (var hero in heroTeam.units)
                {
                    hw = hero.GetWeapone();
                    float damage =
                        CalculateTheDamage.CalculateDamage(hw.damage, tempUnit.GetArmor(), hw.element, ew.element,
                            krit);
                    tempUnit.SubtractHp(damage);
                    Debug.Log($"{hero.GetName()} наносит: {damage} по {tempUnit.GetName()}");

                    if (!tempUnit.IsAlive())
                    {
                        if (tempIndex < enemyTeam.units.Count)
                        {
                            tempIndex++;
                        }
                        else
                        {
                            Debug.Log("Герои победили");
                            return;
                        }
                    }
                }

                tempIndex = 0;
                tempUnit = heroTeam.units[tempIndex];

                foreach (var enemy in enemyTeam.units)
                {
                    Weapone w = enemy.GetWeapone();
                    float damage = CalculateTheDamage.CalculateDamage(enemy.GetWeapone().damage, tempUnit.GetArmor(),
                        enemy.GetWeapone().element, tempUnit.GetWeapone().element, krit);
                    tempUnit.SubtractHp(damage);
                    Debug.Log($"{enemy.GetName()} наносит: {damage} по {tempUnit.GetName()}");
                    if (!tempUnit.IsAlive())
                    {
                        if (tempIndex < heroTeam.units.Count)
                        {
                            tempIndex++;
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