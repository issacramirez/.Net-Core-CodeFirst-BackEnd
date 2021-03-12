using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst_BackEnd.DataAccess
{
    public class FCFMDbContext : DbContext
    {
        public FCFMDbContext() { }

        // crea la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-L6I4UKE\\SQLEXPRESS;Database=FCFM_DB;Trusted_Connection=True;");
            }
        }

        // atributos de datacontext (tablas)
        public DbSet<Students> Students { get; set; }
        public DbSet<Carreer> Carreers { get; set; }



    }
}
