namespace eShop.Domain.Orders;

public record OrderId
{
    public Guid Value { get; init; } = Guid.NewGuid();
}