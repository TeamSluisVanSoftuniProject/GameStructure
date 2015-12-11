using GameStructure.Interfaces;

namespace GameStructure.Models.HealthItems
{
    public class Potion : HealthItem, IHeal
    {
        private const int potionHealing = 20;

        public Potion(string name, ItemType itemType) 
            :base(name, itemType, potionHealing)
        {
        }

        public override int Heal { get; }
        public int Health { get; set; }
    }
}