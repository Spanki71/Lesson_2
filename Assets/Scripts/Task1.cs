using UnityEngine;

namespace Assets.Scripts
{
	public class Task1 : MonoBehaviour
	{
		[SerializeField]
		private float damage;
		[SerializeField]
		private float armor;
		[SerializeField]
		private Element weaponElement;
		[SerializeField]
		private Element enemyElement;
		[SerializeField]
		private float krit;
		[SerializeField]
		private int countAttack;

		void Start()
		{
			for (int i = 0; i < countAttack; i++)
			{
				Debug.Log( i + 1 + " удар: " + CalculateTheDamage.CalculateDamageString(damage, armor, weaponElement, enemyElement, krit));
			}
		}
	}
}