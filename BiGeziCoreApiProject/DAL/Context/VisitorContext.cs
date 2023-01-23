using BiGeziCoreApiProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiGeziCoreApiProject.DAL.Context
{
    public class VisitorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-T5U2SAE;initial catalog=BiGeziDbApi;integrated security=true;");
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
