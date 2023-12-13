namespace eShop.Domain.Orders;

public record struct LineItemId()
{
    public Guid Value { get; init; } = Guid.NewGuid();
}