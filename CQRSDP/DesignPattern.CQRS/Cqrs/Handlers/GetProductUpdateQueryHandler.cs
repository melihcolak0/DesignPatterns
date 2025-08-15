using DesignPattern.CQRS.Cqrs.Queries;
using DesignPattern.CQRS.Cqrs.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.Cqrs.Handlers
{
    public class GetProductUpdateQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateQuery query)
        {
            var value = _context.Products.Find(query.Id);

            return new GetProductUpdateQueryResult
            {
                ProductId = value.ProductId,
                Name = value.Name,
                Price = value.Price,
                Stock = value.Stock,
                Description = value.Description
            };
        }
    }
}
