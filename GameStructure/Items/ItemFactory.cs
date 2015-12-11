using System;
using GameStructure.Enums;
using GameStructure.Models.HealthItems;

namespace GameStructure.Models
{
    public class ItemFactory
    {
        public static Item CreateItem(AllItems type)
        {
            switch (type)
            {
                case AllItems.Daggers:
                    return new Daggers("Faithful's Daggers", ItemType.Common);
                case AllItems.Potion:
                    return new Potion("Potion of Health", ItemType.Common);
                default:
                    throw new ArgumentException();
            }
        }
    }
}