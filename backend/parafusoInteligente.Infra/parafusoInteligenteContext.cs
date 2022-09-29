using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using parafusoInteligente.Infra.Entities;

namespace parafusoInteligente.Infra
{
    public partial class parafusoInteligenteContext : DbContext
    {
        private IConfiguration _configuration;
        public parafusoInteligenteContext()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _configuration = builder.Build();
        }

        public virtual DbSet<BusinessRulesEntity> BusinessRules { get; set; }

        public virtual DbSet<ReportEntity> Report { get; set; }

        public virtual DbSet<ServiceOrderEntity> ServiceOrder { get; set; }

        public virtual DbSet<ConsumerUnitEntity> ConsumerUnit { get; set; }

        public virtual DbSet<StockManagementEntity> StockManagement { get; set; }

        public virtual DbSet<WorkTeamEntity> WorkTeam { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"), o => o.SetPostgresVersion(9, 6));
            }
        }
    }
}