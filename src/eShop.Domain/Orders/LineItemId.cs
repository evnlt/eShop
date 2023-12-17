namespace eShop.Domain.Orders;

public record struct LineItemId
{
    public Guid Value { get; init; }

    public LineItemId(Guid value)
    {
        Value = value;
    }
}