using DesignPattern.CQRS.Cqrs.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.Cqrs.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.ProductId);

            value.Name = command.Name;
            value.Price = command.Price;
            value.Stock = command.Stock;
            value.Status = true;
            value.Description = command.Description;

            _context.SaveChanges();
        }
    }
}
