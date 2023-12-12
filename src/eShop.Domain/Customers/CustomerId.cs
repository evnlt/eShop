namespace eShop.Domain.Customers;

public record CustomerId
{
    public Guid Value { get; init; } = Guid.NewGuid();
}