using CVCore.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVCore.DataAccsess.Concrete
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS ; Database=CVCoreDB ; Trusted_Connection=true;");
        }

        DbSet<About> Abouts { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Experience> Experiences  { get; set; }
        DbSet<Feature> Features { get; set; }
        DbSet<Message> Messages  { get; set; }
        DbSet<Portfolio> Portfolios  { get; set; }
        DbSet<Service> Services  { get; set; }
        DbSet<Skill> Skills  { get; set; }
        DbSet<SocialMedia> SocialMedias  { get; set; }
        DbSet<Testimonial> Testimonials  { get; set; }

    }
}
