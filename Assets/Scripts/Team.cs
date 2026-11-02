using System.Collections.Generic;
namespace Assets.Scripts
{
    public class Team
    {
        public List<IUnit> units = new  List<IUnit>();
        public void AddUnit(IUnit unit)
        {
            units.Add(unit);
        }
        public void RemoveUnit(IUnit unit)
        {
            units.Remove(unit);
        }
    }
}