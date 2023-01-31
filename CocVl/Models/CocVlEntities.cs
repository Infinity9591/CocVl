using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CocVl.Models
{
    public class CocVlEntities : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-24T1NPF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            );
        }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Students> Students { get; set; }
    }
}