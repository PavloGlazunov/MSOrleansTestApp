using MediatR;

namespace Eshop.Core.Domain;

public interface IQuery<out T> : IRequest<T>
{

}