//Ref : https://studysection.com/blog/lazy-loading-in-c/

Customer obj =new Customer();  // when we create object for Customer . it's loading CustName & Orders. but in this case we  are not required 
                              // order details but still it's loading order details to solve this probem we can use Lazy loading method
Console.WriteLine(obj.CustName);


public class Customer
{
    private List<Order> _orders = new List<Order>();
    public string CustName;

    public Customer() {
        CustName = "abc";
        _orders = LoadOrders();
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
