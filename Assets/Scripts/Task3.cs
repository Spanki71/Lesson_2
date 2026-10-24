using UnityEngine;
using System;
using NUnit.Framework.Constraints;
using System.Runtime.InteropServices.WindowsRuntime;
public class Task3 : MonoBehaviour
{
    private Unit Hero;
    private Unit Enemy;
    [SerializeField] public HeroClass Class;
	private void Awake()
	{
        CharacterFactory cf = new CharacterFactory();
        Hero = cf.CreateHero(Class);
        Enemy = cf.CreateEnemy();
	}
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Arena
{
    public Arena(Unit Hero, Unit Enemy)
    {
        System.Random random = new System.Random();
        int HeroDamage = Hero.GetDamage();
		int EnemyDamage = Enemy.GetDamage();
		Debug.Log(Hero.GetName() + Hero.GetHP());
    }
}
public interface Unit
{
    int GetDamage();
	string GetName();
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
                return new Warrior();
			case 1:
				return new Warrior();
			case 2:
                return new Warrior();
		}
        return null;
    }
}
public class Warrior : Unit
{
	public string GetName()
	{
		return Name;
	}
	public int GetDamage()
    {
        System.Random r = new System.Random();
        return r.Next(MinDamage,MaxDamage);
    }
    string Name = "Hero";
	int HP = 100;
    int MinDamage = 10;
    int MaxDamage = 16;

}
public class Mage : Unit
{
	public string GetName()
	{
		return Name;
	}
	public int GetDamage()
	{
		System.Random r = new System.Random();
		return r.Next(MinDamage, MaxDamage);
	}
	string Name = "Hero";
	int HP = 100;
	int MinDamage = 10;
	int MaxDamage = 16;

}

public class Goblin : Unit
{
	public string GetName()
	{
		return Name;
	}
	public int GetDamage()
	{
		System.Random r = new System.Random();
		return r.Next(MinDamage, MaxDamage);
	}
	string Name = "Goblin";
	int HP = 50;
	int MinDamage = 4;
	int MaxDamage = 8;

}

public class Ork : Unit
{
	public string GetName()
	{
		return Name;
	}
	public int GetDamage()
	{
		System.Random r = new System.Random();
		return r.Next(MinDamage, MaxDamage);
	}
	string Name = "Ork";
	int HP = 80;
	int MinDamage = 5;
	int MaxDamage = 10;

}
public class Troll : Unit
{
	public string GetName()
	{
		return Name;
	}
	public int GetDamage()
	{
		System.Random r = new System.Random();
		return r.Next(MinDamage, MaxDamage);
	}
	string Name = "Troll";
	int HP = 140;
	int MinDamage = 8;
	int MaxDamage = 12;

}