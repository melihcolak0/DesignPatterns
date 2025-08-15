using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUoWDal _uoWDal;

        public CustomerManager(ICustomerDal customerDal, IUoWDal uoWDal)
        {
            _customerDal = customerDal;
            _uoWDal = uoWDal;
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
            _uoWDal.Save();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
            _uoWDal.Save();
        }

        public void TMultiUpdate(List<Customer> t)
        {
            _customerDal.MultiUpdate(t);
            _uoWDal.Save();
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
            _uoWDal.Save();
        }
    }
}
