using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetapp.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class ErrorModel : PageModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    private readonly ILogger<ErrorModel> _logger;

    public ErrorModel(ILogger<ErrorModel> logger) => _logger = logger;

    public void OnGet()
    {
        if (_logger.IsEnabled(LogLevel.Debug))
        {
            _logger.LogDebug("ErrorModel.OnGet");
        }

        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
    }
}

