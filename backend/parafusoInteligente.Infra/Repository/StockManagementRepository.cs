using System.Linq;
using Commons_Core.DAO;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;
using parafusoInteligente.Infra.Repository.Interfaces;

namespace parafusoInteligente.Infra.Repository
{
    public class StockManagementRepository : BaseDao<parafusoInteligenteContext, StockManagement, StockManagementEntity, DefaultMapper>, IStockManagementRepository
    {

        public override IQueryable<StockManagementEntity> GetCustomWhere(IQueryable<StockManagementEntity> query, StockManagement filter)
        {
            return query
                .Where(stockManagement => filter.Type == null || stockManagement.Type.ToLower().Contains(filter.Type.ToLower()));
        }
    }
}