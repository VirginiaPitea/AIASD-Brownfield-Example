using Microsoft.AspNetCore.Mvc;
using PostHubAPI.Services.Interfaces;

namespace PostHubAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController(ICalculatorService calculatorService) : ControllerBase
{
    [HttpGet]
    public IActionResult Calculate([FromQuery] double a, [FromQuery] double b, [FromQuery] string operation)
    {
        if (string.IsNullOrWhiteSpace(operation))
        {
            return BadRequest("Operation is required.");
        }

        try
        {
            var result = calculatorService.Calculate(a, b, operation);
            return Ok(result);
        }
        catch (ArgumentException exception)
        {
            return BadRequest(exception.Message);
        }
    }
}
