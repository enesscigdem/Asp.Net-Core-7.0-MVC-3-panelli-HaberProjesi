using System;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
	// Dbcontext sınıfından miras alarak microsoft.entityframeworkcore'u import ediyoruz.
	public class Context:IdentityDbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// bağlantı stringimizi tanımlayacağız
			optionsBuilder.UseSqlServer("server=localhost;uid=sa;password=reallyStrongPwd123;database=CoreBlogDb;TrustServerCertificate=true;");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder) // Bir tablonun 2 farklı ilişkisini oluşturmak için kullandık
		{
			modelBuilder.Entity<Match>()
				.HasOne(x => x.HomeTeam)
				.WithMany(y => y.HomeMatches)
				.HasForeignKey(z => z.HomeTeamID)
				.OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Match>()
                .HasOne(x => x.GuestTeam)
                .WithMany(y => y.AwayMatches)
                .HasForeignKey(z => z.GuestTeamID )
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                  .HasOne(x => x.SenderUser)
                  .WithMany(y => y.WriterSender)
                  .HasForeignKey(z => z.SenderID)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(y => y.WriterReceiver)
                .HasForeignKey(z => z.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);
            //HomeMatches-->WriterSender
            //AwayMatches-->WriterReceiver
            //HomeTeam-->SenderUser
            //GuestTeam-->ReceiverUser
        }
        public DbSet<About> Abouts { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Message2> Message2s { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}

