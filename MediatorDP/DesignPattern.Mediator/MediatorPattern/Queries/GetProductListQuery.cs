using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductListQuery : IRequest<List<GetProductListQueryResult>>
    {
    }
}
