using DesignPattern.CQRS.Cqrs.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.Cqrs.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price,
                Status = true,
                Stock = command.Stock,                
            });
            _context.SaveChanges();
        }
    }
}
