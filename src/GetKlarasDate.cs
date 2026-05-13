using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace src;

public class GetKlarasDate
{
    private readonly ILogger<GetKlarasDate> _logger;

    public GetKlarasDate(ILogger<GetKlarasDate> logger)
    {
        _logger = logger;
    }

    [Function("GetKlarasDate")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        
        var plannedDate = new DateTime(2026, 08, 24, 00,00,00);
        var daysLeft = plannedDate - DateTime.Now;
        _logger.LogInformation("Days left: {DaysLeft}", daysLeft);
        return new OkObjectResult($"Klara will be here in {daysLeft.Days} days ❤️");
    }
}