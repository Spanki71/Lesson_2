using UnityEngine;

namespace Assets.Scripts
{
	public class Task1 : MonoBehaviour
	{
		[SerializeField]
		private float m_damage;
		[SerializeField]
		private float m_armor;
		[SerializeField]
		private Element m_weaponElement;
		[SerializeField]
		private Element m_enemyElement;
		[SerializeField]
		private float m_krit;
		[SerializeField]
		private int m_countAttack;

		void Start()
		{
			for (int i = 0; i < m_countAttack; i++)
			{
				string debugInfo;
				CalculateTheDamage.CalculateDamage(m_damage, m_armor, m_weaponElement, m_enemyElement, m_krit, out debugInfo);
				Debug.Log( i + 1 + " удар: " + debugInfo);
			}
		}
	}
}