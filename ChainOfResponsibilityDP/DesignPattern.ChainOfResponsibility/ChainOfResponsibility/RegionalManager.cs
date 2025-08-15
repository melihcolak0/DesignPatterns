using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class RegionalManager : Employee
    {
        private readonly Context _context;

        public RegionalManager(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = request.Name;
                customerProcess.Amount = request.Amount;
                customerProcess.EmployeeName = "Bölge Müdürü - Melih Yılmaz";
                customerProcess.Description = "Para Çekme işlemi onaylandı! Müşteriye talep ettiği tutar ödendi.";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = request.Name;
                customerProcess.Amount = request.Amount;
                customerProcess.EmployeeName = "Bölge Müdürü - Melih Yılmaz";
                customerProcess.Description = "Çekilmek istenen para tutarı limiti aştığı için işlem iptal edildi. Maksimum para çekme tutarı 400.000₺'dir";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
            }
        }
    }
}
