using eShop.Domain.Customers;
using eShop.Domain.Products;

namespace eShop.Domain.Orders;

public class Order
{
    private readonly HashSet<LineItem> _lineItems = new();

    private Order()
    {
        
    }

    public OrderId Id { get; init; }

    public CustomerId CustomerId { get; private set; }

    public static Order Create(Customer customer)
    {
        var order = new Order
        {
            Id = new OrderId(),
            CustomerId = customer.Id
        };

        return order;
    }

    public void Add(Product product)
    {
        var lineItem = new LineItem(Id, product.Id, product.Price);
        _lineItems.Add(lineItem);
    }
}