namespace CafeSystem.Domain.Interfaces;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}