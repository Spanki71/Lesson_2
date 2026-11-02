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
			Weapone hw = new Weapone("Меч",1,10,Element.None);
			Weapone ew = new Weapone("Вражеский меч",1,10,Element.Ice);
			hero.AddItem(hw);
			enemy.AddItem(ew);
			Armor ha = new Armor("Щит",1,5,Element.Eart);
			Armor ea = new Armor("Вражеский щит",5,10,Element.Wather);
			hero.AddItem(ha);
			enemy.AddItem(ea);
		}
		void Start()
		{
			Arena arena = new Arena();
			arena.Run(hero, enemy, s_rounds);
		}

	}
}