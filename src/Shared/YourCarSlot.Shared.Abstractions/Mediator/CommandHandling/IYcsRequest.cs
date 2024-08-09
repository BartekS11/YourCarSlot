using MediatR;

namespace YourCarSlot.Shared.Abstractions.Mediator.CommandHandling;

public interface IYcsRequest : IRequest
{
    
}

public interface IYcsRequest<T> : IRequest<T>
{

}
