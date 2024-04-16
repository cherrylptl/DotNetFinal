using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ErrorModel : PageModel
{
    public List<String> errors { get; set; } = new List<String>();
    public InventoryItem? item;

    private readonly ILogger<ErrorModel> _logger;

    public ErrorModel(ILogger<ErrorModel> logger)
    {
        _logger = logger;
    }


    public void OnGet(InventoryItem _item)

    {
        item = _item;

        if (item.ItemPricePerUnit <= 0)
        {
            errors.Add("Item Price Per Unit should be greater than 0.");
        }

        if (item.ItemQuantityInStock <= 0)
        {
            errors.Add("Item Quantity In Stock should be greater than 0.");
        }

    }
}

