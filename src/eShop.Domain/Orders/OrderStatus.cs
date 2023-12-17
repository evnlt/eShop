namespace eShop.Domain.Orders;

public enum OrderStatus : byte
{
    Pending,
    Completed,
    Cancelled
}