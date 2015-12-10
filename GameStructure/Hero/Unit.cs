using System;

namespace GameStructure.Hero
{
    public abstract class Unit
    {
        private string name;
        private int health;
        private int attackDamage;

        protected Unit(string name, int health, int attackDamage)
        {
            this.Name = name;
            this.Health = health;
            this.AttackDamage = attackDamage;
        }

        public int AttackDamage
        {
            get { return attackDamage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Attack damage cannot be negative");
                }
                this.attackDamage = value;
            }
        }

        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health cannot be negative");
                }
                this.health = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                this.name = value;
            }
        }
    }
}