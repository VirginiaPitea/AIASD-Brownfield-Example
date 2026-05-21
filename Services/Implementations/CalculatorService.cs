using PostHubAPI.Services.Interfaces;

namespace PostHubAPI.Services.Implementations;

public class CalculatorService : ICalculatorService
{
    public double Calculate(double first, double second, string operation)
    {
        var normalizedOperation = operation.Trim().ToLowerInvariant();

        return normalizedOperation switch
        {
            "add" or "+" => first + second,
            "subtract" or "-" => first - second,
            "multiply" or "*" => first * second,
            "divide" or "/" when second != 0 => first / second,
            "divide" or "/" => throw new ArgumentException("Division by zero is not allowed."),
            _ => throw new ArgumentException("Unsupported operation. Use add, subtract, multiply, divide, +, -, *, or /.")
        };
    }
}
