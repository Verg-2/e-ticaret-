using ECommerceAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Data
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
        public DbSet<Product>Products{get;set;}
         public DbSet<ApplicationUser>ApplicationUser{get;set;}
          public DbSet<Cartİtem>Cartİtems{get;set;}


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>().HasData(
            new Product
{
    Id = 1,
    Name = "Kablosuz Kulak Üstü Kulaklık",
    Description = "Aktif gürültü engelleme (ANC) özellikli, 30 saat pil ömrü sunan yüksek çözünürlüklü kablosuz kulaklık.",
    Price = 2499.99M,
    Image = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?q=80&w=800&auto=format&fit=crop",
    Category = "Elektronik",
    Stock = 45,
    Rating = 4.8
},
new Product
{
    Id = 2,
    Name = "Akıllı Saat v2",
    Description = "Nabız takibi, GPS ve spora özel modlar içeren Su geçirmez alüminyum kasa akıllı saat.",
    Price = 1850.00M,
    Image = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?q=80&w=800&auto=format&fit=crop",
    Category = "Elektronik",
    Stock = 120,
    Rating = 4.6
},
new Product
{
    Id = 3,
    Name = "Ergonomik Çalışma Koltuğu",
    Description = "Bel ve boyun destekli, nefes alabilir file kumaşlı uzun süreli kullanıma uygun ofis koltuğu.",
    Price = 4200.50M,
    Image = "https://images.unsplash.com/photo-1580481072645-022f9a6d1270?q=80&w=800&auto=format&fit=crop",
    Category = "Mobilya",
    Stock = 15,
    Rating = 4.4
},
new Product
{
    Id = 4,
    Name = "Paslanmaz Çelik Termos (750ml)",
    Description = "Çift katmanlı vakum izolasyonu sayesinde 12 saat sıcak, 24 saat soğuk tutan mat termos.",
    Price = 649.90M,
    Image = "https://images.unsplash.com/photo-1602143407151-7111542de6e8?q=80&w=800&auto=format&fit=crop",
    Category = "Mutfak & Yaşam",
    Stock = 85,
    Rating = 4.9
},
new Product
{
    Id = 5,
    Name = "Mekanik RGB Klavye",
    Description = "Red switch tuş anahtarları, özelleştirilebilir RGB aydınlatma ve alüminyum gövdeli oyuncu klavyesi.",
    Price = 1299.00M,
    Image = "https://images.unsplash.com/photo-1587829741301-dc798b83add3?q=80&w=800&auto=format&fit=crop",
    Category = "Aksesuar",
    Stock = 60,
    Rating = 4.7
}
            );
        }
    }
}