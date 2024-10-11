using Week2Day3HW;

MyStack<int> intStack = new MyStack<int>();
intStack.Push(10);
intStack.Push(20);
intStack.Push(30);

Console.WriteLine("Stack count: " + intStack.Count()); // Output: 3
Console.WriteLine("Popped item: " + intStack.Pop());   // Output: 30
Console.WriteLine("Stack count after pop: " + intStack.Count()); // Output: 2

MyStack<string> stringStack = new MyStack<string>();
stringStack.Push("Hello");
stringStack.Push("World");

Console.WriteLine("Stack count: " + stringStack.Count()); // Output: 2
Console.WriteLine("Popped item: " + stringStack.Pop());   // Output: World

MyList<int> myList = new MyList<int>();
        
myList.Add(10);
myList.Add(20);
myList.Add(30);

Console.WriteLine("List contains 20: " + myList.Contains(20)); // True
Console.WriteLine("Item at index 1: " + myList.Find(1));       // 20

myList.InsertAt(25, 1);
Console.WriteLine("Item at index 1 after insertion: " + myList.Find(1)); // 25

Console.WriteLine("Removing item at index 2: " + myList.Remove(2));       // 20
Console.WriteLine("Deleting item at index 1");
myList.DeleteAt(1); // Removes the element at index 1

Console.WriteLine("Clearing all items.");
myList.Clear();

// Create a repository for Customer entities
var customerRepository = new GenericRepository<Customer>();

// Add customers to the repository
var customer1 = new Customer { Id = 1, Name = "John Doe", Email = "john@example.com" };
var customer2 = new Customer { Id = 2, Name = "Jane Smith", Email = "jane@example.com" };

customerRepository.Add(customer1);
customerRepository.Add(customer2);

// Retrieve all customers
Console.WriteLine("All customers:");
foreach (var customer in customerRepository.GetAll())
{
    Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}");
}

// Retrieve a customer by ID
var retrievedCustomer = customerRepository.GetById(1);
Console.WriteLine($"\nRetrieved customer: ID: {retrievedCustomer.Id}, Name: {retrievedCustomer.Name}");

// Remove a customer
customerRepository.Remove(customer1);
        
Console.WriteLine("\nCustomers after removal:");
foreach (var customer in customerRepository.GetAll())
{
    Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}");
}

// Save changes (just a simulated action in this case)
customerRepository.Save();