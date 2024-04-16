using System.ComponentModel.DataAnnotations;

public class InventoryItem
{
    public InventoryItem(int itemId, string itemName, int itemQuantity, int itemPrice)
    {
        this.ItemId = itemId;
        this.ItemName = itemName;
        this.ItemQuantityInStock = itemQuantity;
        this.ItemPricePerUnit = itemPrice;
    }
    public InventoryItem()
    {
    }

    public required int ItemId { get; set; }

    [Required(ErrorMessage = "User name is required"), StringLength(50, MinimumLength = 3, ErrorMessage = "User name has to be minimum 3 letters to maximum 20 letters")]
    public required string ItemName { get; set; }


    [Required(ErrorMessage = "Item Quantity InStock is required")]
    public required int ItemQuantityInStock { get; set; }


    [Required(ErrorMessage = "Item Price Per Unit number is required")]
    public required int ItemPricePerUnit { get; set; }
}
