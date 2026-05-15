namespace CafeSystem.Domain.Services;

public class OrderLogger
{
    public void OnOrderCreated(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}