using CafeSystem.Domain.Entities;

namespace CafeSystem.Domain.Services;

public class DiscountDecorator : MenuItemDecorator
{
    public DiscountDecorator(MenuItem item)
        : base(item)
    {
    }

    public override void ShowInfo()
    {
        base.ShowInfo();

        Console.WriteLine("Знижка застосована!");
    }
}