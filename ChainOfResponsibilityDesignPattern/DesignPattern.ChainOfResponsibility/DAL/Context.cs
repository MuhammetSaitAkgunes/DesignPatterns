using Microsoft.EntityFrameworkCore;
using DesignPattern.ChainOfResponsibility.DAL;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MUHAMMETNB;initial catalog=DesignPattern1;integrated security=true;");
        }
        public DbSet<CustomerProcess> CostumerProcesses { get; set; }
    }
}
