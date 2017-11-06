namespace MultiLeaseManagement
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LeasingModel : DbContext
    {
        public LeasingModel()
            : base("name=LeasingModel")
        {
        }

        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Lease_Terms> Lease_Terms { get; set; }
        public virtual DbSet<Leas> Leases { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<V_Type> V_Type { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>()
                .HasMany(e => e.Vehicles)
                .WithRequired(e => e.Color)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Postal_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Leases)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lease_Terms>()
                .Property(e => e.Extra_Mileage_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Lease_Terms>()
                .HasMany(e => e.Leases)
                .WithRequired(e => e.Lease_Terms)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Leas>()
                .Property(e => e.Monthly_Payment_Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Leas>()
                .Property(e => e.Vehicle_VIN)
                .IsUnicode(false);

            modelBuilder.Entity<Leas>()
                .HasMany(e => e.Audits)
                .WithOptional(e => e.Leas)
                .HasForeignKey(e => e.Lease_ID);

            modelBuilder.Entity<Leas>()
                .HasMany(e => e.Payments)
                .WithOptional(e => e.Leas)
                .HasForeignKey(e => e.Lease_ID);

            modelBuilder.Entity<Model>()
                .HasMany(e => e.Vehicles)
                .WithRequired(e => e.Model)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<V_Type>()
                .HasMany(e => e.Vehicles)
                .WithRequired(e => e.V_Type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Vehicle_VIN)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Current_Vehicle_Val)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Vehicle>()
                .HasMany(e => e.Leases)
                .WithRequired(e => e.Vehicle)
                .WillCascadeOnDelete(false);
        }
    }
}
