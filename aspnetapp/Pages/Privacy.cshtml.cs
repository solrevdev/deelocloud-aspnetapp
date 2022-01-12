using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetapp.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger) => _logger = logger;

    public void OnGet()
    {
        if (_logger.IsEnabled(LogLevel.Debug))
        {
            _logger.LogDebug("PrivacyModel.OnGet");
        }
    }
}

