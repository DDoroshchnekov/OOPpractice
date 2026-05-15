using CafeSystem.Domain.Interfaces;

namespace CafeSystem.Domain.Services;

public class CardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата картою: {amount} грн");
    }
}