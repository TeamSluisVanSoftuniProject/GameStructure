namespace GameStructure.Interfaces
{
    public interface IInventory
    {
        void AddItem(IItem item);
        void RemoveItem(IItem item);

    }
}