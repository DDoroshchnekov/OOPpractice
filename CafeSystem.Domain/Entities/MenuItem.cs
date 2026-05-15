namespace CafeSystem.Domain.Entities;

public class MenuItem
{
    private decimal _price;

    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Ціна не може бути менше 0");
            }

            _price = value;
        }
    }

    public MenuItem()
    {
    }

    public MenuItem(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"{Name} - {Price} грн");
    }
}