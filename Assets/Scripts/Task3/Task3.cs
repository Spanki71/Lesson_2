using UnityEngine;
using System;
using NUnit.Framework.Constraints;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Assets.Scripts
{
	public class Task3 : MonoBehaviour
	{
		private IUnit hero;
		private IUnit enemy;
		[SerializeField] private HeroClass s_heroClass;
		[SerializeField] private int s_rounds;
		private void Awake()
		{
			CharacterFactory cf = new CharacterFactory();
			hero = cf.CreateHero(s_heroClass);
			enemy = cf.CreateEnemy();
		}
		void Start()
		{
			Arena arena = new Arena();
			arena.Run(hero, enemy, s_rounds);
		}

	}
}