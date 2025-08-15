using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SG606F1\\SQLEXPRESS; Initial Catalog=111MY_DesignPatterns8Db; Integrated Security=true;");
        }
        
        public DbSet<Product> Products { get; set; }
    }
}
