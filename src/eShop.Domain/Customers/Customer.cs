namespace eShop.Domain.Customers;

public class Customer
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public string Email { get; private set; } = string.Empty;

    public string Name { get; private set; } = string.Empty;
}