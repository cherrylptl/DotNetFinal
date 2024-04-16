public interface IItemsRepository
{
    public void AddItem(InventoryItem item);
    public List<InventoryItem> GetItems();
}