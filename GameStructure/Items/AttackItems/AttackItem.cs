namespace GameStructure.Models
{
    public class AttackItem : Item
    {
        public AttackItem(string name, ItemType itemType, int damage) 
            : base(name, itemType)
        {
            this.Damage = damage;
        }

        public int Damage { get; set; }
    }
}