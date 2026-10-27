using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;

namespace Assets.Scripts
{
    public class Task4 : MonoBehaviour
    {
        [SerializeField] int CountHeros;
		[SerializeField] int CountEnemys;
        Team HeroTeam = new Team();
        Team EnemyTeam = new Team();
		private void Awake()
		{
            CharacterFactory cf = new CharacterFactory();
            for (int i = 0; i < CountHeros; i++)
            {
                HeroTeam.AddUnit(cf.CreateRandomHero());
            }
            for (int i = 0; i < CountEnemys; i++)
            {
                EnemyTeam.AddUnit(cf.CreateEnemy());
            }
		}
		void Start()
        {
            TeamArena ta = new TeamArena(HeroTeam, EnemyTeam);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class TeamArena
    {
		[SerializeField] public float krit = 3.0f;
		public TeamArena(Team HeroTeam, Team EnemyTeam)
        {
            int _tempIndex = 0;
            Unit _tempUnit = EnemyTeam._units[_tempIndex];
			// 1 удар - Hero
            foreach (var Hero in HeroTeam._units) // Бьет каждый герой за раунд
            {
				float damage = CalculateDamage(Hero.GetDamage(), _tempUnit.GetArmor(), Hero.GetWeapone().element, _tempUnit.GetWeapone().element, krit);
				_tempUnit.SubtractHP((int)damage);
				Debug.Log(Hero.GetName() + " наносит: " + damage + " по " + _tempUnit.GetName());
                if (!_tempUnit.IsAlive())
                {
                    if (_tempIndex < EnemyTeam._units.Count) // Еще остались враги
                    {
						_tempIndex++;
                    }
                    else 
                    {
                        Debug.Log("Герои победили");// победа
                        return;
                    }
                }
            }
            _tempIndex = 0;
			_tempUnit = HeroTeam._units[_tempIndex];
			// 2 удар - Enemy
			foreach (var Enemy in EnemyTeam._units) // Бьет каждый герой за раунд
			{
				float damage = CalculateDamage(Enemy.GetDamage(), _tempUnit.GetArmor(), Enemy.GetWeapone().element, _tempUnit.GetWeapone().element, krit);
				_tempUnit.SubtractHP((int)damage);
				Debug.Log(Enemy.GetName() + " наносит: " + damage + " по " + _tempUnit.GetName());
				if (!_tempUnit.IsAlive())
				{
					if (_tempIndex < HeroTeam._units.Count) // Еще остались враги
					{
						_tempIndex++;
					}
					else
					{
						Debug.Log("Противники победили, а вы проиграли");// победа
						return;
					}
				}
			}
		}

		float CalculateDamage(float _damage, float _armor, Element _selfElement, Element _enemyElement, float _krit)
		{
			if (_selfElement == _enemyElement)
			{
				return 0.0f;
			}
			float _baseDamage;

			if (_damage > _armor)
			{
				_baseDamage = _damage - _armor;
			}
			else
			{
				_baseDamage = 1;
			}
			if (_selfElement != _enemyElement)
			{
				_baseDamage = (float)Math.Floor(_baseDamage * 1.5f);
			}
			System.Random _random = new System.Random();
			if (_random.Next(0, 100) < (_krit * 100.0f))
			{
				_baseDamage *= 2.0f;
			}
			return _baseDamage;
		}
	}
	public class Team
    {
        bool IsAlive = true;
        public List<Unit> _units = new List<Unit>();
        public void AddUnit(Unit _unit)
        {
            _units.Add(_unit);
        }
        public void RemoveUnit(Unit _unit)
        {
            _units.Remove(_unit);
            if (_units.Count < 1)
            {
                IsAlive = false;
            }
        }
	}
}