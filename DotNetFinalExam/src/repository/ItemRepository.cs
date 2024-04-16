public class ItemRepository
{
    public static List<String> ItemList = new List<String>
    {
        "Sunflower Seeds","Lotus","Rose Plant",
    };

    public static List<String> GetAvailableCars()
    {
        return ItemList;
    }
}