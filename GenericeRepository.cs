namespace Week2Day3HW;
using System;
using System.Collections.Generic;
using System.Linq;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private List<T> _items = new List<T>();

    // Adds an item to the repository
    public void Add(T item)
    {
        _items.Add(item);
    }

    // Removes an item from the repository
    public void Remove(T item)
    {
        _items.Remove(item);
    }

    // Saves changes (no implementation needed for in-memory storage)
    public void Save()
    {
        // In a real application, this would save changes to the database
        Console.WriteLine("Changes saved to the database.");
    }

    // Retrieves all items from the repository
    public IEnumerable<T> GetAll()
    {
        return _items;
    }

    // Retrieves an item by its Id
    public T GetById(int id)
    {
        return _items.FirstOrDefault(item => item.Id == id);
    }
}