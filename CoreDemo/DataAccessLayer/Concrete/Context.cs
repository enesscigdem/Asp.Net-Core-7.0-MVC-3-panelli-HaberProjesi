using System;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
	// Dbcontext sınıfından miras alarak microsoft.entityframeworkcore'u import ediyoruz.
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// bağlantı stringimizi tanımlayacağız
			optionsBuilder.UseSqlServer("server=localhost;uid=sa;password=reallyStrongPwd123;database=CoreBlogDb;TrustServerCertificate=true;");
		}
		public DbSet<About> Abouts { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
    }
}

