using UnityEngine;

namespace Assets.Scripts
{
	public class Task3 : MonoBehaviour
	{
		[SerializeField]
		private HeroClass m_heroClass;
		[SerializeField]
		private int m_rounds;
		
		private BaseCharacter hero;
		private BaseCharacter enemy;
		private void Awake()
		{
			CharacterFactory cf = new CharacterFactory();
			hero = cf.CreateHero(m_heroClass);
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
			arena.Run(hero, enemy, m_rounds);
		}

	}
}