using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEfCodeFirts
{
    public class EjemploEfCodeFirstContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ITPROE15;Initial Catalog=EjemploEfCodeFirst;User Id=sa;Password=P@$$w0rd");          
            }
        }


        public DbSet<Product> Products { get; set; } = null;
    }
}
