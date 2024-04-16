using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetFinalExam.Pages;

public class AddModel : PageModel
{
    public InventoryItem? Item;
    public List<string> ItemList = ItemRepository.ItemList;
    private IItemsRepository itemsRepository = new ItemRepositoryJSON();

    private readonly ILogger<AddModel> _logger;

    public AddModel(ILogger<AddModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    public IActionResult OnPost(InventoryItem item)
    {

        if (!ModelState.IsValid || item.ItemPricePerUnit <= 0 || item.ItemQuantityInStock <= 0)

        {
            Console.WriteLine(ModelState.ErrorCount);
            foreach (var entry in ModelState)
            {
                foreach (var error in entry.Value.Errors)
                {
                    Console.WriteLine($"Error in property '{entry.Key}': {error.ErrorMessage}");
                }
            }
            return RedirectToPage("Error", item);
        }

        if (ModelState.IsValid && item.ItemPricePerUnit > 0 && item.ItemQuantityInStock > 0)
        {
            item.ItemId = itemsRepository.GetItems().Count + 1;
            itemsRepository.AddItem(item);
            return RedirectToPage();
        }
        return RedirectToPage();
    }
}
