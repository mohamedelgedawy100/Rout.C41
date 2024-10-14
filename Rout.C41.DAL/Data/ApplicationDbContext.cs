using Microsoft.EntityFrameworkCore;
using Rout.C41.DAL.Data.Configurations;
using Rout.C41.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rout.C41.DAL.Data
{

    

    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
      //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      //=> optionsBuilder.UseSqlServer("Server .;Database = MVCApplicationG02; Trusted_Conection=True ; MultipleActiveResultSets = False");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }  

        public DbSet<Department> Departments { get; set; }



    }
}
