using MediatR;

namespace Eshop.Core;

public interface IQuery<out T> : IRequest<T>
{
    
}