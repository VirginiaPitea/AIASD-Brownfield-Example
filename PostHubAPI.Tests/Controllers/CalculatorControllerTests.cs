using Microsoft.AspNetCore.Mvc;
using PostHubAPI.Controllers;
using PostHubAPI.Services.Interfaces;

namespace PostHubAPI.Tests.Controllers;

public class CalculatorControllerTests
{
    [Fact]
    public void Calculate_ReturnsOkWithResult_WhenOperationIsValid()
    {
        var controller = new CalculatorController(new CalculatorServiceStub());

        var result = controller.Calculate(10, 5, "add");

        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(200, okResult.StatusCode);
        Assert.Equal(15d, Assert.IsType<double>(okResult.Value));
    }

    [Fact]
    public void Calculate_ReturnsBadRequest_WhenOperationIsMissing()
    {
        var controller = new CalculatorController(new CalculatorServiceStub());

        var result = controller.Calculate(10, 5, "");

        var badRequest = Assert.IsType<BadRequestObjectResult>(result);
        Assert.Equal(400, badRequest.StatusCode);
        Assert.Equal("Operation is required.", badRequest.Value);
    }

    [Fact]
    public void Calculate_ReturnsBadRequest_WhenServiceThrowsArgumentException()
    {
        var controller = new CalculatorController(new CalculatorServiceStub
        {
            Handler = (_, _, _) => throw new ArgumentException("Division by zero is not allowed.")
        });

        var result = controller.Calculate(10, 0, "divide");

        var badRequest = Assert.IsType<BadRequestObjectResult>(result);
        Assert.Equal(400, badRequest.StatusCode);
        Assert.Equal("Division by zero is not allowed.", badRequest.Value);
    }

    private sealed class CalculatorServiceStub : ICalculatorService
    {
        public Func<double, double, string, double> Handler { get; init; } = (a, b, _) => a + b;

        public double Calculate(double first, double second, string operation) => Handler(first, second, operation);
    }
}
