using UnityEngine;

namespace Assets.Scripts
{
    public class Task4 : MonoBehaviour
    {
        public Team heroTeam =  new Team();
        public Team enemyTeam  = new Team();
        
        [SerializeField]
        private int countHeros;
        [SerializeField]
		private int countEnemys;
        [SerializeField]
        private int rounds;
        
		private void Awake()
		{
            CharacterFactory cf = new CharacterFactory();
            
                for (int i = 0; i < countHeros; i++)
                {
                    var temp = cf.CreateRandomHero();
                    temp.AddItem(Weapone.CreateRandom());
                    temp.AddItem(Armor.CreateRandom());
                    
                    heroTeam.AddUnit(temp);
                }

                for (int i = 0; i < countEnemys; i++)
                {
                    var temp = cf.CreateEnemy();
                    temp.AddItem(Weapone.CreateRandom());
                    temp.AddItem(Armor.CreateRandom());
                    
                    enemyTeam.AddUnit(temp);
                }
        }
        
		void Start()
        {
            TeamArena ta = new TeamArena();
            ta.Run(heroTeam, enemyTeam, rounds);
        }
    }
}