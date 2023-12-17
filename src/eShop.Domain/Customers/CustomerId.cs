namespace eShop.Domain.Customers;

public record struct CustomerId
{
    public Guid Value { get; init; }

    public CustomerId(Guid value)
    {
        Value = value;
    }
}