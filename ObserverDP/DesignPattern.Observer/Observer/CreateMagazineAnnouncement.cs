using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.Observer
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.NameSurname,
                Content = "Bilim dergimizim mart sayısı 1 Mart 2025 tarihinde evinize ulaşacaktır. Konular, Jüpiter ve Mars Gezegeni olacaktır."
            });

            context.SaveChanges();
        }
    }
}
