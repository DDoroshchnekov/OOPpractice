namespace CafeSystem.Domain.Entities;

public class Food : MenuItem
{
    public int Weight { get; set; }

    public override void ShowInfo()
    {
        base.ShowInfo();

        Console.WriteLine($"Вага: {Weight} г");
    }
}