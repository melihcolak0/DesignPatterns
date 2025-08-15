using DesignPattern.CQRS.Cqrs.Queries;
using DesignPattern.CQRS.Cqrs.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.Cqrs.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var value = _context.Set<Product>().Find(query.Id);

            return new GetProductByIdQueryResult
            {
                ProductId = value.ProductId,
                Name = value.Name,
                Price = value.Price,
                Stock = value.Stock
            };
        }
    }
}
