using UnityEngine;
using System;
public class Task1 : MonoBehaviour
{
    [SerializeField] float Damage;
	[SerializeField] float Armor;
    [SerializeField] Element WeaponElement;
    [SerializeField] Element EnemyElement;
    [SerializeField] float Krit;
    [SerializeField] int CoutnAttack;
	enum Element
    {
        Eart,
        Wather,
        Fire,
        Ice,
        None
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < CoutnAttack; i++)
        {
            Debug.Log(i+1 + " удар: " + CalculateDamage(Damage, Armor, WeaponElement, EnemyElement, Krit));
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string CalculateDamage(float _damage, float _armor,Element _selfElement, Element _enemyElement, float _krit)
    {
        if (_selfElement == _enemyElement)
        {
            //Debug.Log("Урон не нанесен");
            return "Урон не нанесен";
        }
        string st = "(";
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
            st += "стихия x1,5, ";
        }
        else 
        {
            st += "без стихии, ";
        }
		System.Random _random = new System.Random();
        if (_random.Next(0, 100) < (_krit * 100.0f))
        {
            _baseDamage *= 2.0f;
            st += "крит x2)";
        }
        else
        {
			st += "без крита)";
		}

        //Debug.Log(_baseDamage + " урона " + st);
        return _baseDamage + " урона " + st;

    }
}
