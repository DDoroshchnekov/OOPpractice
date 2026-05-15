namespace CafeSystem.Domain.Repositories;

public class Repository<T>
{
    private readonly List<T> _items;

    public Repository()
    {
        _items = new List<T>();
    }

    public void Add(T item)
    {
        _items.Add(item);
    }

    public List<T> GetAll()
    {
        return _items;
    }
}