using UnityEngine;
using System;
using NUnit.Framework.Constraints;
using System.Runtime.InteropServices.WindowsRuntime;
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
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		Arena arena = new Arena(Hero,Enemy,rounds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Arena
{
    public Arena(Unit Hero, Unit Enemy, int rounds)
    {
        System.Random random = new System.Random();
        int HeroDamage;
		int EnemyDamage;
		Debug.Log(Hero.GetName() + " (" + Hero.GetHP() + " HP)" + "против"
			+ Enemy.GetName() + " (" +Enemy.GetHP() + " HP)");
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
public interface Unit
{
    int GetDamage();
	string GetName();
	int GetHP();
	void SubtractHP(int count);
	bool IsAlive();
}
public enum HeroClass
{
    Warrior,
    Mage
}

public class CharacterFactory
{
    public Unit CreateHero(HeroClass Class)
    {
        switch (Class)
        {
            case HeroClass.Warrior:
                return new Warrior();
			case HeroClass.Mage:
				return new Warrior();
		}
        return new Warrior();
    }
    public Unit CreateEnemy()
    {
        System.Random random = new System.Random();
        switch (random.Next(0, 3))
        {
            case 0: 
                return new Goblin();
			case 1:
				return new Ork();
			case 2:
                return new Troll();
		}
        return null;
    }
}
public class Warrior : Unit
{
	bool _isAlive = true;
	public string GetName()
	{
		return Name;
	}
	public int GetDamage()
    {
        System.Random r = new System.Random();
        return r.Next(MinDamage,MaxDamage);
    }
	public int GetHP()
	{
		return HP;
	}
	public void SubtractHP(int countHP)
	{
		if (countHP >= HP)
		{
			HP = 0;
			_isAlive = false;
		}
		else 
		{
			HP -= countHP;
		}
	}
	public bool IsAlive()
	{
		return _isAlive;
	}
    string Name = "Hero";
	int HP = 100;
    int MinDamage = 10;
    int MaxDamage = 16;

}
public class Mage : Unit
{
	bool _isAlive = true;
	public string GetName()
	{
		return Name;
	}
	public int GetDamage()
	{
		System.Random r = new System.Random();
		return r.Next(MinDamage, MaxDamage);
	}
	public int GetHP()
	{
		return HP;
	}
	public void SubtractHP(int countHP)
	{
		if (countHP >= HP)
		{
			HP = 0;
			_isAlive = false;
		}
		else
		{
			HP -= countHP;
		}
	}
	public bool IsAlive()
	{
		return _isAlive;
	}
	string Name = "Mage";
	int HP = 100;
	int MinDamage = 10;
	int MaxDamage = 16;

}

public class Goblin : Unit
{
	bool _isAlive = true;
	public string GetName()
	{
		return Name;
	}
	public int GetDamage()
	{
		System.Random r = new System.Random();
		return r.Next(MinDamage, MaxDamage);
	}
	public int GetHP()
	{
		return HP;
	}
	public void SubtractHP(int countHP)
	{
		if (countHP >= HP)
		{
			HP = 0;
			_isAlive = false;
		}
		else
		{
			HP -= countHP;
		}
	}
	public bool IsAlive()
	{
		return _isAlive;
	}
	string Name = "Goblin";
	int HP = 50;
	int MinDamage = 4;
	int MaxDamage = 8;

}

public class Ork : Unit
{
	bool _isAlive = true;
	public string GetName()
	{
		return Name;
	}
	public int GetDamage()
	{
		System.Random r = new System.Random();
		return r.Next(MinDamage, MaxDamage);
	}
	public int GetHP()
	{
		return HP;
	}
	public void SubtractHP(int countHP)
	{
		if (countHP >= HP)
		{
			HP = 0;
			_isAlive = false;
		}
		else
		{
			HP -= countHP;
		}
	}
	public bool IsAlive()
	{
		return _isAlive;
	}
	string Name = "Ork";
	int HP = 80;
	int MinDamage = 5;
	int MaxDamage = 10;

}
public class Troll : Unit
{
	bool _isAlive = true;
	public string GetName()
	{
		return Name;
	}
	public int GetDamage()
	{
		System.Random r = new System.Random();
		return r.Next(MinDamage, MaxDamage);
	}
	public int GetHP()
	{
		return HP;
	}
	public void SubtractHP(int countHP)
	{
		if (countHP >= HP)
		{
			HP = 0;
			_isAlive = false;
		}
		else
		{
			HP -= countHP;
		}
	}
	public bool IsAlive()
	{
		return _isAlive;
	}
	string Name = "Troll";
	int HP = 140;
	int MinDamage = 8;
	int MaxDamage = 12;

}