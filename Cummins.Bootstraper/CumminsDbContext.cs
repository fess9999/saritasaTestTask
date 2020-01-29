using Cummins.Model.Base;
using Cummins.Model.Documents;
using Cummins.Model.Elements;
using Cummins.Model.Items;
using Microsoft.EntityFrameworkCore;

namespace Cummins.Bootstrapper
{
    public class CumminsDbContext : DbContext
    {
        public DbSet<Contractor> Contractors { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Quote> Quotes { get; set; }

        public DbSet<BOM> BOMs { get; set; }

        public DbSet<ChangeOrder> ChangeOrders { get; set; }

        public DbSet<PowercomItem> PowercomItems { get; set; }

        public DbSet<UpfitItem> UpfitItems { get; set; }

        public DbSet<UpfitElement> UpfitElements { get; set; }

        public DbSet<PowercomElement> PowercomElements { get; set; }

        public DbSet<UpfitRecord> UpfitRecords { get; set; }

        public DbSet<UpfitElementBinding> UpfitElementBindings { get; set; }

        public DbSet<PowercomItemBinding> PowercomItemBindings { get; set; }

        public DbSet<UpfitItemBinding> UpfitItemBindings { get; set; }

        public DbSet<StartTestInformation> StartTestInformations { get; set; }

        public DbSet<StartUpRequirement> StartUpRequirements { get; set; }

        public DbSet<PMA> PMAs { get; set; }

        public DbSet<PMAEntry> PMAEntries { get; set; }

        public DbSet<TravelItem> TravelItems { get; set; }

        public DbSet<MaterialRequest> MaterialRequests { get; set; }

        public DbSet<UpfitMaterialRequestItem> UpfitMaterialRequestItems { get; set; }

        public DbSet<PowercomMaterialRequestItem> PowercomMaterialRequestItems { get; set; }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ChangeLogEntry> ChangeLogEntries { get; set; }

        public DbSet<ProductGroup> ProductGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseNpgsql("User ID=postgres;Password=;Host=localhost;Port=5432;Database=cummins;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>().ToTable("Documents");
            modelBuilder.Entity<DocumentItem>().ToTable("DocumentItems");
            modelBuilder.Entity<Element>().ToTable("Elements");
            modelBuilder.Entity<MaterialRequestItem>().ToTable("MaterialRequestItems");

            modelBuilder.Entity<UpfitElement>().HasIndex(element => element.UniqueId).IsUnique();

            modelBuilder.Entity<UpfitRecord>().OwnsMany(record => record.FileReferences, builder =>
            {
                builder.WithOwner().HasForeignKey(nameof(FileReference.EntityId));
                builder.ToTable("FileReferences");
            });
        }
    }
}