using GameStructure;
using GameStructure.Models;

public abstract class HealthItem : Item
{
    protected HealthItem(string name, ItemType itemType, int healing)
        : base(name, itemType)
    {
        this.Healing = healing;
    }

    public int Healing { get; set; }

    public abstract int Heal { get; }
}