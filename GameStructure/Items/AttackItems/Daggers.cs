namespace GameStructure.Models
{
    public class Daggers : AttackItem
    {
        private const int daggersDamage = 20;

        public Daggers(string name, ItemType itemType) 
            :base (name, itemType, daggersDamage)
        {
        }
    }
}