using MediatR;

namespace Core;

public interface ICommand<out T> : IRequest<T>
{
    
}