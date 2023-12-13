namespace eShop.Domain.Orders;

public record struct OrderId()
{
    public Guid Value { get; init; } = Guid.NewGuid();
}