namespace Constructors;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        Customer customer1 = new Customer { Id = 1, FirstName = "Mehmet", LastName = "Albayrak", City = "İzmir" };
        Customer customer2 = new Customer(2, "David", "Lee", "Hamburg"); // parameter usage
        Customer customer3 = new Customer();
        customer3.Id = 1;
        customer3.FirstName = "Alain";
        customer3.LastName = "Delon";
        customer3.City = "Sceaux";

        Console.WriteLine(customer2.FirstName);
    }
}

class Customer
{
    
    public Customer(int id, string firstName, string lastName, string city) // --> line 6
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public Customer() // not giving parameter --> line 5
    {
        
    }
    
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}