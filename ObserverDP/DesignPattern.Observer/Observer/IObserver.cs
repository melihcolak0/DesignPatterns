using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.Observer
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
