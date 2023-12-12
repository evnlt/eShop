namespace eShop.Domain.Orders;

public record LineItemId
{
    public Guid Value { get; init; } = Guid.NewGuid();
}