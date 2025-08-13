using Microsoft.EntityFrameworkCore;
using Portofolio.DAL.Entities;

namespace Portofolio.DAL.Context;

public class PortofolioContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=5432;Database=PortofolioDatabase;Username=postgres;Password=mamady1427");
    }
    
    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Messages> Messages { get; set; }
    public DbSet<Project> Portofolios { get; set; }
    public DbSet<Skills> Skills { get; set; }
    public DbSet<SocialMedia> SocialMediae { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}