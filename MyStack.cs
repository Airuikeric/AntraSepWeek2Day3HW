namespace Week2Day3HW;

public class MyStack<T>
{
    private List<T> _items = new List<T>();

    // Returns the number of items in the stack
    public int Count()
    {
        return _items.Count;
    }

    // Removes and returns the top item from the stack
    public T Pop()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("Stack is empty");

        // Retrieve and remove the last item in the list
        T item = _items[_items.Count - 1];
        _items.RemoveAt(_items.Count - 1);
        return item;
    }

    // Adds an item to the top of the stack
    public void Push(T item)
    {
        _items.Add(item);
    }
}