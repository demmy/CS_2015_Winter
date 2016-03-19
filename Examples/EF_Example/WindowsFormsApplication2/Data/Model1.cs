namespace WindowsFormsApplication2.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ContosoContext")
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<ContactInfo> ContactInfoes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Good> Goods { get; set; }
        public virtual DbSet<GoodsRow> GoodsRows { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PersonalInfo> PersonalInfoes { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactInfo>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.ContactInfo)
                .HasForeignKey(e => e.Contacts_Id);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Comments)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.Customer_Id);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.Customer_Id);

            modelBuilder.Entity<Good>()
                .HasMany(e => e.Comments)
                .WithOptional(e => e.Good)
                .HasForeignKey(e => e.Goods_Id);

            modelBuilder.Entity<Good>()
                .HasMany(e => e.GoodsRows)
                .WithOptional(e => e.Good)
                .HasForeignKey(e => e.Goods_Id);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Comments)
                .WithOptional(e => e.Order)
                .HasForeignKey(e => e.Order_Id);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.GoodsRows)
                .WithOptional(e => e.Order)
                .HasForeignKey(e => e.Order_Id);

            modelBuilder.Entity<OrderStatu>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.OrderStatu)
                .HasForeignKey(e => e.Status_Id);

            modelBuilder.Entity<Permission>()
                .HasMany(e => e.Roles)
                .WithMany(e => e.Permissions)
                .Map(m => m.ToTable("RolePermissions"));

            modelBuilder.Entity<PersonalInfo>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.PersonalInfo)
                .HasForeignKey(e => e.PersonalInfo_Id);

            modelBuilder.Entity<PersonalInfo>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.PersonalInfo)
                .HasForeignKey(e => e.PersonalInfo_Id);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.Goods)
                .WithOptional(e => e.ProductCategory)
                .HasForeignKey(e => e.Category_Id);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.Role_Id);
        }
    }
}
