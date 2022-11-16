using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class ResumeContext : DbContext
    {
    


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=ResumeDb; Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>().HasData(
                new About
                {
                    Id = 1, Name = "Tolga",Surname = "Boroğlu",BirthDate = DateTime.Parse("01/01/1998"),Age = "24", Email = "tolgaboroğlu@gmail.com",
                    PhoneNumber = "05000000000",Description = "Deneme Açıklama", Status = true, CreatedDate = DateTime.Now,
                },
                new About{Id=2, Name = "Emin",Age = "23",Description = "Emin durukan hakkında sayfası",Status = true,Email = "emin@gmail.com", CreatedDate = DateTime.Now,BirthDate = DateTime.Parse("01/01/1998"),PhoneNumber = "00000000000",Surname = "Durukan"}
                );
            modelBuilder.Entity<Education>().HasData(
                
                new Education { Id=1,SchoolName = "DenemeOkulu",GraduationAverage = 78, Description = "Güzel bir okuldu",StartDate = DateTime.Parse("01/01/2020"),Status = true,CreatedDate =  DateTime.Now,EndDate = DateTime.Parse("01/01/2022") },
                new Education{Id=2,SchoolName = "Atü",GraduationAverage = 3,Description = "Hoş bir Okul",StartDate = DateTime.Parse("01/01/2020"),Status = true,CreatedDate = DateTime.Now,EndDate = DateTime.Parse("01/01/2022")}
                );
            
            modelBuilder.Entity<Experience>().HasData(
                new Experience
                {
                    Id = 1, Name = "Deneme iş Yeri", Description = "Yazılım", StartDate = DateTime.Parse("01/01/2021"),
                    EndDate = DateTime.Parse("01/01/2022"),
                    CreatedDate = DateTime.Now, Status = true
                });
            modelBuilder.Entity<Hobby>().HasData(
                new Hobby
                {
                    Id = 1, Name = "Dağcılık",Description = "Yürüyüş gezi",CreatedDate = DateTime.Now,Status = true
                });
            modelBuilder.Entity<Language>().HasData(
                new Language
                {
                    Id = 1, Name = "İngilizce", Level = "10", Status = true, Description = "Akıcı şekilde konuşuyor",
                    CreatedDate = DateTime.Now
                });
            modelBuilder.Entity<Portfolio>().HasData(
                new Portfolio
                {
                    Id=1, Name ="Cv Projesi",Description = "Web sitesi yapımı",Status = true,CreatedDate = DateTime.Now,StarDate = DateTime.Today,EndDate = DateTime.Parse("01/01/2023")
                });
            modelBuilder.Entity<Reference>().HasData(
                new Reference
                {
                    Id = 1, NameSurname = "Tolga Boroğlu", JobTitle = "Veri Bilimci", CreatedDate = DateTime.Now,
                    Status = true, Description = "iyi bir öğrenci"
                });
            modelBuilder.Entity<Social>().HasData(
                new Social
                {
                    Id = 1, Name = "Twitter", Url = "https://twitter.com/melihmerall", Description = "Twitter Adresim",
                    CreatedDate = DateTime.Now, Status = true
                });
            modelBuilder.Entity<Talent>().HasData(
                new Talent
                {
                    Id = 1, Name = "C#", Status = true, Rate = "10", Description = "orta derece bilgi sahibi",
                    CreatedDate = DateTime.Now
                });
           



        }    


        public DbSet<About> Abouts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Talent> Talents { get; set; }

    }
}
