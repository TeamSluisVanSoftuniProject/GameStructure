using System;
using GameStructure.Enums;
using GameStructure.Interfaces;

namespace GameStructure.Models
{
    public abstract class Item : IItem
    {
        private string name;
        private const int CommonPrice = 100;
        private const int RarePrice = 500;
        private const int EpicPrice = 900;

        protected Item(string name, ItemType itemType)
        {
            this.Name = name;
            this.ItemType = itemType;
        }

        public int Price
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Item.CommonPrice;
                    case ItemType.Rare: return Item.RarePrice;
                    case ItemType.Epic: return Item.EpicPrice;
                    default: return Item.CommonPrice;
                }
            }
        }

        public ItemType ItemType { get; set; }

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