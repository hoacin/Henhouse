using Henhouse.Logic.Manipulations.Implementations.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Henhouse.Logic.Manipulations.Implementations.EFCore
{
    public class HenhouseDBContext : DbContext
    {
        private readonly string? _connectionString = null;

        public DbSet<ChickenModel> Chickens => Set<ChickenModel>();
        public DbSet<EggModel> Eggs => Set<EggModel>();

        public HenhouseDBContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public HenhouseDBContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionString is null)
                _ = optionsBuilder.UseSqlServer();
            else
                _ = optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
