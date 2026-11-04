using System.Collections.Generic;
namespace Assets.Scripts
{
    public class Team
    {
        public List<BaseCharacter> units = new  List<BaseCharacter>();
        public void AddUnit(BaseCharacter unit)
        {
            units.Add(unit);
        }
        public void RemoveUnit(BaseCharacter unit)
        {
            units.Remove(unit);
        }
    }
}