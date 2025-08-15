using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.Observer
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.NameSurname,
                Content = "Dergi bültenimize kayıt olduğunuz için çok teşekkür ederiz. Dergilerimize web sitemizden ulaşabilirsiniz."
            });

            context.SaveChanges();
        }
    }
}
