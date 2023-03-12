using MediatR;

namespace Core;

public interface IQuery<out T> : IRequest<T>
{
    
}