using UnityEngine;
using System;
using NUnit.Framework.Constraints;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Assets.Scripts
{
	public class Task3 : MonoBehaviour
	{
		private Unit Hero;
		private Unit Enemy;
		[SerializeField] public HeroClass Class;
		[SerializeField] int rounds;
		private void Awake()
		{
			CharacterFactory cf = new CharacterFactory();
			Hero = cf.CreateHero(Class);
			Enemy = cf.CreateEnemy();
		}
		void Start()
		{
			Arena arena = new Arena(Hero, Enemy, rounds);
		}

	}
	public class Arena // Нужен Debug.Log();  
	{
		public Arena(Unit Hero, Unit Enemy, int rounds)
		{
			System.Random random = new System.Random();
			int HeroDamage;
			int EnemyDamage;
			Debug.Log(Hero.GetName() + " (" + Hero.GetHP() + " HP)" + "против"
				+ Enemy.GetName() + " (" + Enemy.GetHP() + " HP)");
			string st = "";
			for (int i = 0; i < rounds; i++)
			{

				HeroDamage = Hero.GetDamage();
				Enemy.SubtractHP(HeroDamage);
				st = "Раунд " + i + ": " + Hero.GetName() + " наносит " + HeroDamage + ", у противника " + Enemy.GetHP()
					+ "; ";

				if (Enemy.IsAlive())
				{
					EnemyDamage = Enemy.GetDamage();
					Hero.SubtractHP(EnemyDamage);
					st += Enemy.GetName() + " наносит " + EnemyDamage + " у героя " + Hero.GetHP();
					if (!Hero.IsAlive())
					{
						Debug.Log("Поражение");
						return;
					}
				}
				else
				{
					Debug.Log("Победа у героя осталось " + Hero.GetHP() + "HP");
					return;
				}
				Debug.Log(st);
			}
			Debug.Log("Ничья у героя осталось " + Hero.GetHP() + "HP, у " + Enemy.GetName() + " осталось "
				+ Enemy.GetHP() + " HP");
		}
	}
}