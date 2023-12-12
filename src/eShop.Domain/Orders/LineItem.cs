using eShop.Domain.Products;

namespace eShop.Domain.Orders;

internal class LineItem
{
    public LineItem(OrderId orderId, ProductId productId, Price price)
    {
        Id = new LineItemId();
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }

    public LineItemId Id { get; init; } 

    public OrderId OrderId { get; private set; }

    public ProductId ProductId { get; private set; }

    public Price Price { get; private set; }
}