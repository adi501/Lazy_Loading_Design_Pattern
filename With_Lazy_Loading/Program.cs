
Customer obj = new Customer();
Console.WriteLine(obj.CustName);
foreach (Order or in obj.orders())  // by using Lazy loading method we are abale to load data when we required
{
    Console.WriteLine(or.Name);
}
Console.ReadLine();

public class Customer
{
    private List<Order> _orders = null;
    public string CustName;
    public Customer()
    {
        CustName = "abc";
    }
    public List<Order> orders()
    {
        if (_orders == null)
        {
            _orders = LoadOrders();
        }
        return _orders;

    }
    private List<Order> LoadOrders()
    {
        List<Order> orders = new List<Order>();
        orders.Add(new Order { Id = 1, Name = "Order1" });
        orders.Add(new Order { Id = 2, Name = "Order2" });
        orders.Add(new Order { Id = 3, Name = "Order3" });
        orders.Add(new Order { Id = 4, Name = "Order4" });
        return orders;
    }
}
public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
}
