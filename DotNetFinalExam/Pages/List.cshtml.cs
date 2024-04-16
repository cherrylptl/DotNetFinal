using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetFinalExam.Pages;

public class ListModel : PageModel
{
    public InventoryItem? Item;
    private IItemsRepository itemsRepository = new ItemRepositoryJSON();
    public List<InventoryItem> Items { get; set; } = new List<InventoryItem>();
    private readonly ILogger<ListModel> _logger;

    public ListModel(ILogger<ListModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Items = itemsRepository.GetItems();
    }
}
