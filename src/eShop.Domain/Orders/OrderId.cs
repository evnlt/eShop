namespace eShop.Domain.Orders;

public record struct OrderId
{
    public Guid Value { get; init; }

    public OrderId(Guid value)
    {
        Value = value;
    }
}