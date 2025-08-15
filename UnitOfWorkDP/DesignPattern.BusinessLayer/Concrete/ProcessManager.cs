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
    public class ProcessManager : IProcessService
    {
        private IProcessDal _processDal;
        private IUoWDal _uoWDal;

        public ProcessManager(IProcessDal processDal, IUoWDal uoWDal)
        {
            _processDal = processDal;
            _uoWDal = uoWDal;
        }

        public void TDelete(Process t)
        {
            _processDal.Delete(t);
            _uoWDal.Save();
        }

        public Process TGetById(int id)
        {
            return _processDal.GetById(id);
        }

        public List<Process> TGetList()
        {
            return _processDal.GetList();
        }

        public void TInsert(Process t)
        {
            _processDal.Insert(t);
            _uoWDal.Save();
        }

        public void TMultiUpdate(List<Process> t)
        {
            _processDal.MultiUpdate(t);
            _uoWDal.Save();
        }

        public void TUpdate(Process t)
        {
            _processDal.Update(t);
            _uoWDal.Save();
        }
    }
}
