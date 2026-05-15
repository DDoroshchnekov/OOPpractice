using CafeSystem.Domain.Entities;

namespace CafeSystem.Domain.Services;

public static class MenuItemFactory
{
    public static MenuItem Create(string type)
    {
        return type.ToLower() switch
        {
            "food" => new Food(),
            "drink" => new Drink(),
            _ => throw new Exception("Невідомий тип")
        };
    }
}