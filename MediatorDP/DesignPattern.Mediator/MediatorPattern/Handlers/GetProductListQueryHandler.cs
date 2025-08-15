using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Queries;
using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, List<GetProductListQueryResult>>
    {
        private readonly Context _context;

        public GetProductListQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetProductListQueryResult>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetProductListQueryResult
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductCategory = x.ProductCategory,
                ProductStock = x.ProductStock,
                ProductStockType = x.ProductStockType
            }).AsNoTracking().ToListAsync();
        }
    }
}
