using EStoreAdminModel.Brands;
using Microsoft.EntityFrameworkCore;

namespace EStoreAdminRepository
{
    public class BrandRepository : DbContext
    {

        public BrandRepository(DbContextOptions<BrandRepository> options)
            : base(options)
        {
            
        }

        public DbSet<BrandModel> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //we will try to create a Table using ToTable Method
            modelBuilder.Entity<BrandModel>().ToTable("Brands");


        }
    }
}
