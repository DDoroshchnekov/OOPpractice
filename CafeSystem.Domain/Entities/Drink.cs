namespace CafeSystem.Domain.Entities;

public class Drink : MenuItem
{
    public bool IsCold { get; set; }

    public override void ShowInfo()
    {
        base.ShowInfo();

        Console.WriteLine(IsCold
            ? "Холодний напій"
            : "Гарячий напій");
    }
}