namespace eShop.Domain.Customers;

public record struct CustomerId()
{
    public Guid Value { get; init; } = Guid.NewGuid();
}