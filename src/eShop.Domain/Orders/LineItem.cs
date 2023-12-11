using eShop.Domain.Products;

namespace eShop.Domain.Orders;

internal class LineItem
{
    public LineItem(Guid orderId, Guid productId, Price price)
    {
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }
    
    public Guid Id { get; init; } = Guid.NewGuid();

    public Guid OrderId { get; private set; }

    public Guid ProductId { get; private set; }

    public Price Price { get; private set; }
}