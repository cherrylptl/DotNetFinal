using Newtonsoft.Json;

public class ItemRepositoryJSON : IItemsRepository
{
    public static readonly string JSON = "data/inventory.json";

    public void AddItem(InventoryItem item)
    {
        List<InventoryItem> items = GetItems();
        items.Add(item);

        string itemText = JsonConvert.SerializeObject(items);
        File.WriteAllText(JSON, itemText);
    }

    public List<InventoryItem> GetItems()
    {
        if (File.Exists(JSON))
        {
            string itemsText = File.ReadAllText(JSON);
            if (!String.IsNullOrEmpty(itemsText))
            {
                List<InventoryItem> items = JsonConvert.DeserializeObject<List<InventoryItem>>(itemsText)!;
                return items;
            }
        }
        return new List<InventoryItem>();
    }


}