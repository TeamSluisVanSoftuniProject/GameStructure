namespace GameStructure.Models.HealthItems
{
    public class Potion : HealthItem
    {
        private const int potionHealing = 20;

        public Potion(string name, ItemType itemType) 
            :base(name, itemType, potionHealing)
        {
        }

        public override int Heal { get; }
    }
}