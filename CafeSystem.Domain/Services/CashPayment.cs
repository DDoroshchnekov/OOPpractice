using CafeSystem.Domain.Interfaces;

namespace CafeSystem.Domain.Services;

public class CashPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата готівкою: {amount} грн");
    }
}