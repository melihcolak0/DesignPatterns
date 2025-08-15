using DesignPattern.CQRS.Cqrs.Results;
using DesignPattern.CQRS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRS.Cqrs.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                Id = x.ProductId,
                ProductName = x.Name,
                Price = x.Price,
                Stock = x.Stock
            }).ToList();

            return values;
        }
    }
}
