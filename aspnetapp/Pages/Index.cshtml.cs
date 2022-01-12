using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetapp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger) => _logger = logger;

    public void OnGet()
    {
        if(_logger.IsEnabled(LogLevel.Debug))
        {
            _logger.LogDebug("IndexModel.OnGet");
        }
    }
}
