using System;
using System.Threading;
using GameStructure.Creatures;
using GameStructure.Enums;
using GameStructure.Hero;
using GameStructure.Models;

namespace GameStructure
{
    class Program
    {
        static void Main()
        {
            Wizard asd = new Wizard("Deni");
            var worgen = CreatureFactory.CreateCreature(EnemyType.Worgen);

            if (asd.AttackDamage > worgen.Health)
            {
                asd.Health -= worgen.AttackDamage;
                asd.Exp
                Console.WriteLine("Worgen is defeated!");
                Thread.Sleep(2000);
                Console.WriteLine("Remaining health : {0}", asd.Health);
            }

        }
    }
}
