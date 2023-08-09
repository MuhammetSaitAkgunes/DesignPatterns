using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if(req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar Ali Koç";
                customerProcess.Description = "Para çekme işlemi onaylandı. Müşteriye talep ettiği tutar ödendi.";
                context.CostumerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar Ali Koç";
                customerProcess.Description = "Tutar, veznedarın günlük limitini aştığı için talep müdür yardımcısına yönlendirildi.";
                context.CostumerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
