namespace GameStructure.Hero
{
    public abstract class Hero : Unit
    {
        private int experience;
        private int kills;
        private int gold;
        private Inventory inventory;
        // Implement Invtory class / interface.

        protected Hero(string name, int health, int attackDamage) 
            :base(name, health, attackDamage)
        {
        }
    }
}