using eShop.Domain.Customers;
using MediatR;
using eShop.Domain.Orders;

namespace eShop.Application.Orders;

public sealed record CreateOrderCommand(CustomerId CustomerId) : IRequest;

/*public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
{
    public CreateOrderCommandHandler(Application)
    {
        
    }
    
    public Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        Order.Create()
        throw new NotImplementedException();
    }
}*/