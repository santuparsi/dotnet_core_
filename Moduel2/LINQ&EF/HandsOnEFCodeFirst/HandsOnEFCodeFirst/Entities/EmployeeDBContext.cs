using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCodeFirst.Entities
{
    class EmployeeDBContext:DbContext
    {
        //Entity set
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //set the connection string
            optionsBuilder.UseSqlServer(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=EmployeeDB;Integrated Security=True");
        }
    }
}
