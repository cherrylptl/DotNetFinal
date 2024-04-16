using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetFinalExam.Pages;

public class IndexModel : PageModel
{
    public string StoreName { get; } = "Cherryl Patel's Plant Nursery";
    public string StoreAddress { get; } = "133, Longwood Drive , Waterloo, CANADA";
    public string StorePhone { get; } = "+1 (519)-760-1111";

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public void OnGet()
    {

    }
}
