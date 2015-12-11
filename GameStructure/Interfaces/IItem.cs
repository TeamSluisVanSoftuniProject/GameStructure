namespace GameStructure.Interfaces
{
    public interface IItem
    {
        int Price
        {
            get;
        }

        ItemType ItemType
        {
            get;
            set;
        }
    }
}