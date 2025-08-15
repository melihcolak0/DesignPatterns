using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SG606F1\\SQLEXPRESS; Initial Catalog=111MY_DesignPatterns1Db; Integrated Security=true;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
