using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.Observer
{
    public class CreateDiscount : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscount(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "DERGIMART",
                DiscountAmount = 35,
                DiscountCodeStatus = true
            });

            context.SaveChanges();
        }

    }
}
