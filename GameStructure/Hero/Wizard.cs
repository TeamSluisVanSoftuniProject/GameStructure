namespace GameStructure.Hero
{
    public class Wizard : Hero
    {
        private const int WizardHealth = 200;
        private const int WizardDamage = 100;

        public Wizard(string name) 
            :base (name, WizardHealth, WizardDamage)
        {
        }
    }
}