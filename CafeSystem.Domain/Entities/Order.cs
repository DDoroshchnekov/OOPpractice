using CafeSystem.Domain.Exceptions;
using CafeSystem.Domain.Interfaces;
using System.Linq;

namespace CafeSystem.Domain.Entities;

public class Order : IPrintable
{
    public int Id { get; set; }

    public List<MenuItem> Items { get; set; }

    public DateTime CreatedAt { get; set; }

    public event Action<string>? OrderCreated;

    public Order()
    {
        Items = new List<MenuItem>();
        CreatedAt = DateTime.Now;
    }

    public void Create()
    {
        OrderCreated?.Invoke("Замовлення створено");
    }

    public void AddItem(MenuItem? item)
    {
        if (item == null)
        {
            throw new InvalidOrderException("Страва не може бути null");
        }

        Items.Add(item);
    }

    public decimal GetTotal()
    {
        return Items.Sum(x => x.Price);
    }

    public void Print()
    {
        Console.WriteLine($"Замовлення #{Id}");

        foreach (var item in Items)
        {
            Console.WriteLine($"{item.Name} - {item.Price} грн");
        }

        Console.WriteLine($"Загальна сума: {GetTotal()} грн");
    }
}