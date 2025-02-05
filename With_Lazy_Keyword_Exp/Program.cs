//Ref : https://studysection.com/blog/lazy-loading-in-c/

Customer obj = new Customer();
Console.WriteLine(obj.CustName);
foreach (Order or in obj.Orders)  
{
    Console.WriteLine(or.Name);
}
Console.ReadLine();

public class Customer
{
    private Lazy<List<Order>> _orders = null;
    public string CustName;
    public List<Order> Orders
    {
        get
        {
            return _orders.Value;
        }
    }
    public Customer()
    {
        CustName = "abc";
        _orders = new Lazy<List<Order>>(()=>LoadOrders());
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
