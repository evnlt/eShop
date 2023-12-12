namespace eShop.Domain.Customers;

public class Customer
{
    public CustomerId Id { get; init; } = new();
    
    public string Email { get; private set; } = string.Empty;

    public string Name { get; private set; } = string.Empty;
}