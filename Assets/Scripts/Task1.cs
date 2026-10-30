using UnityEngine;

namespace Assets.Scripts
{
	public class Task1 : MonoBehaviour
	{
		[SerializeField] float damage;
		[SerializeField] float armor;
		[SerializeField] Element weaponElement;
		[SerializeField] Element enemyElement;
		[SerializeField] float krit;
		[SerializeField] int countAttack;

		// Start is called once before the first execution of Update after the MonoBehaviour is created
		void Start()
		{
			
			for (int i = 0; i < countAttack; i++)
			{
				Debug.Log( i + 1 + " удар: " + CalculateTheDamage.CalculateDamageString(damage, armor, weaponElement, enemyElement, krit));

			}
		}
	}
}