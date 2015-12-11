using System;
using GameStructure.Enums;
using GameStructure.Hero;
using GameStructure.Models;

namespace GameStructure
{
    class Program
    {
        static void Main()
        {
            var asd = ItemFactory.CreateItem(AllItems.Daggers);
            ItemFactory.CreateItem(AllItems.Potion);

            Console.WriteLine(asd.Name);

        }
    }
}
