using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DXApplication1.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<AfterPayClient> AfterPayClients { get; set; }
        public virtual DbSet<BeforePayClient> BeforePayClients { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<GroupClient> GroupClients { get; set; }
        public virtual DbSet<GroupClientAndGroupUser> GroupClientAndGroupUsers { get; set; }
        public virtual DbSet<GroupUser> GroupUsers { get; set; }
        public virtual DbSet<LoginMember> LoginMembers { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberInformation> MemberInformations { get; set; }
        public virtual DbSet<OrderCard> OrderCards { get; set; }
        public virtual DbSet<OrderDrink> OrderDrinks { get; set; }
        public virtual DbSet<OrderFood> OrderFoods { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TheCard> TheCards { get; set; }
        public virtual DbSet<TheUser> TheUsers { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AfterPayClient>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<BeforePayClient>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.AfterPayClients)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BeforePayClients)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.StatusClient)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ActiveStatusClient)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .HasMany(e => e.AfterPayClients)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.BeforePayClients)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.LoginMembers)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.OrderCards)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.OrderDrinks)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.OrderFoods)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drink>()
                .HasMany(e => e.OrderDrinks)
                .WithRequired(e => e.Drink)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.OrderFoods)
                .WithRequired(e => e.Food)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GroupClient>()
                .HasMany(e => e.Clients)
                .WithOptional(e => e.GroupClient)
                .HasForeignKey(e => e.GroupClientName);

            modelBuilder.Entity<GroupClient>()
                .HasMany(e => e.GroupClientAndGroupUsers)
                .WithRequired(e => e.GroupClient)
                .HasForeignKey(e => e.GroupClientName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GroupUser>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<GroupUser>()
                .HasMany(e => e.GroupClientAndGroupUsers)
                .WithRequired(e => e.GroupUser)
                .HasForeignKey(e => e.GroupUserName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GroupUser>()
                .HasMany(e => e.Members)
                .WithOptional(e => e.GroupUser1)
                .HasForeignKey(e => e.GroupUser);

            modelBuilder.Entity<GroupUser>()
                .HasMany(e => e.TheUsers)
                .WithOptional(e => e.GroupUser1)
                .HasForeignKey(e => e.GroupUser);

            modelBuilder.Entity<LoginMember>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .HasMany(e => e.LoginMembers)
                .WithRequired(e => e.Member)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Member>()
                .HasOptional(e => e.MemberInformation)
                .WithRequired(e => e.Member);

            modelBuilder.Entity<MemberInformation>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<MemberInformation>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCard>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDrink>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderFood>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<TheCard>()
                .HasMany(e => e.OrderCards)
                .WithRequired(e => e.TheCard)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TheUser>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<TheUser>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TheUser>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TheUser>()
                .HasMany(e => e.Bills)
                .WithOptional(e => e.TheUser)
                .HasForeignKey(e => e.FoundedUser);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.LoaiTk)
                .IsUnicode(false);
        }
    }
}
