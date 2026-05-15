using CafeSystem.Domain.DTOs;
using CafeSystem.Domain.Entities;
using CafeSystem.Domain.Interfaces;
using CafeSystem.Domain.Repositories;
using CafeSystem.Domain.Services;

var burger = new Food
{
    Id = 1,
    Name = "Burger",
    Price = 120,
    Weight = 300
};

var cola = new Drink
{
    Id = 2,
    Name = "Cola",
    Price = 50,
    IsCold = true
};

var order = new Order();

order.Id = 1;

var logger = new OrderLogger();

order.OrderCreated += logger.OnOrderCreated;

order.Create();

order.AddItem(burger);
order.AddItem(cola);

burger.ShowInfo();

Console.WriteLine();

cola.ShowInfo();

Console.WriteLine();

Console.WriteLine($"Сума замовлення: {order.GetTotal()} грн");

Console.WriteLine();

order.Print();

var repository = new Repository<Order>();

repository.Add(order);

Console.WriteLine();

Console.WriteLine($"Кількість замовлень: {repository.GetAll().Count}");

Console.WriteLine();

var item = MenuItemFactory.Create("food");

item.Name = "Pizza";
item.Price = 200;

item.ShowInfo();

Console.WriteLine();

IPaymentStrategy payment = new CardPayment();

payment.Pay(order.GetTotal());

Console.WriteLine();

var dto = new OrderDto
{
    Id = order.Id,
    Total = order.GetTotal(),
    CreatedAt = order.CreatedAt
};

var jsonService = new JsonService();

jsonService.Save(dto, "order.json");

Console.WriteLine("Замовлення збережено");

var loadedOrder = jsonService.Load<OrderDto>("order.json");

Console.WriteLine();

Console.WriteLine($"Завантажене замовлення: {loadedOrder?.Total} грн");

Console.WriteLine();

var discountedBurger = new DiscountDecorator(burger);

discountedBurger.ShowInfo();

try
{
    order.AddItem(null);
}
catch (Exception ex)
{
    Console.WriteLine();

    Console.WriteLine($"Помилка: {ex.Message}");
}