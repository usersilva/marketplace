using Microsoft.EntityFrameworkCore;

    public class MarketplaceDbContext : DbContext
    {
      public MarketplaceDbContext(DbContextOptions<MarketplaceDbContext> options) : base(options) { }

      //// ���������� ���� DbSet ��� ���������
      //public DbSet<User> Users { get; set; }
      //public DbSet<Asset> Assets { get; set; }
      //public DbSet<Transaction> Transactions { get; set; }
      //public DbSet<Review> Reviews { get; set; }

      //// �������������� ��������� ����� ������� �����
      //protected override void OnModelCreating(ModelBuilder modelBuilder)
      //{
      //  // ��������� �������
      //}
    }
