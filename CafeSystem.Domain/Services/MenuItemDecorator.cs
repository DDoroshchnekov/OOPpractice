using CafeSystem.Domain.Entities;

namespace CafeSystem.Domain.Services;

public abstract class MenuItemDecorator : MenuItem
{
    protected MenuItem _menuItem;

    protected MenuItemDecorator(MenuItem menuItem)
    {
        _menuItem = menuItem;
    }

    public override void ShowInfo()
    {
        _menuItem.ShowInfo();
    }
}