using System;
using GameStructure.Models;

namespace GameStructure.Hero
{
    public abstract class Hero : Unit
    {
        private int experience;
        private int kills;
        private int gold;
        private Inventory inventory;

        protected Hero(string name, int health, int attackDamage) 
            :base(name, health, attackDamage)
        {
            this.inventory = new Inventory();
            this.Level = 1;
        }

        public int Experience { get; set; }

        public int Gold { get; set; }

        public int Kills { get; set; }

        public Inventory Inventory { get; set; }

        public int Level { get; set; }

        public override int GetAttackDemage()
        {
            int damage = this.AttackDamage;

            if (damage <= 0)
            {
                damage = 10;
            }

            return damage;
        }
    }

}