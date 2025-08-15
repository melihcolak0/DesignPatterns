using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Queries;
using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.Id);

            return new GetProductByIdQueryResult
            {
                ProductId = value.ProductId,
                ProductName = value.ProductName,
                ProductCategory = value.ProductCategory,
                ProductPrice = value.ProductPrice,
                ProductStock = value.ProductStock,
                ProductStockType = value.ProductStockType
            };
        }
    }
}
