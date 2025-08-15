using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Manager : Employee
    {
        private readonly Context _context;

        public Manager(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            if (request.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = request.Name;
                customerProcess.Amount = request.Amount;
                customerProcess.EmployeeName = "Şube Müdürü - Mustafa Korkmaz";
                customerProcess.Description = "Para Çekme işlemi onaylandı! Müşteriye talep ettiği tutar ödendi.";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = request.Name;
                customerProcess.Amount = request.Amount;
                customerProcess.EmployeeName = "Şube Müdürü - Mustafa Korkmaz";
                customerProcess.Description = "Çekilmek istenen para tutarı limiti aştığı" +
                    " için işlem Bölge Müdürü'ne yönlendirildi.";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
