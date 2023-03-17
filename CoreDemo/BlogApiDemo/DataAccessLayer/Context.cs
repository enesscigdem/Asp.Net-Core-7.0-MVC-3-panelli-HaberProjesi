using System;
using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
	public class Context : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // bağlantı stringimizi tanımlayacağız
            optionsBuilder.UseSqlServer("server=localhost;uid=sa;password=reallyStrongPwd123;database=CoreBlogApiDb;TrustServerCertificate=true;");
        }
        public DbSet<Employee> Employees{ get; set; }
    }
}

