namespace Week2Day3HW;

public class MyList<T>
{
    private List<T> _items = new List<T>();

    // Adds an element to the list
    public void Add(T element)
    {
        _items.Add(element);
    }

    // Removes an element at the specified index and returns it
    public T Remove(int index)
    {
        if (index < 0 || index >= _items.Count)
            throw new ArgumentOutOfRangeException("Index is out of range");

        T element = _items[index];
        _items.RemoveAt(index);
        return element;
    }

    // Checks if the list contains a specified element
    public bool Contains(T element)
    {
        return _items.Contains(element);
    }

    // Clears all elements from the list
    public void Clear()
    {
        _items.Clear();
    }

    // Inserts an element at a specified index
    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > _items.Count)
            throw new ArgumentOutOfRangeException("Index is out of range");

        _items.Insert(index, element);
    }

    // Deletes an element at the specified index
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= _items.Count)
            throw new ArgumentOutOfRangeException("Index is out of range");

        _items.RemoveAt(index);
    }

    // Finds and returns the element at the specified index
    public T Find(int index)
    {
        if (index < 0 || index >= _items.Count)
            throw new ArgumentOutOfRangeException("Index is out of range");

        return _items[index];
    }
}