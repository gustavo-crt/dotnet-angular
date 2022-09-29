using System.Linq;
using Commons_Core.DAO;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;
using parafusoInteligente.Infra.Repository.Interfaces;

namespace parafusoInteligente.Infra.Repository
{
    public class ServiceOrderRepository : BaseDao<parafusoInteligenteContext, ServiceOrder, ServiceOrderEntity, DefaultMapper>, IServiceOrderRepository
    {

        public override IQueryable<ServiceOrderEntity> GetCustomWhere(IQueryable<ServiceOrderEntity> query, ServiceOrder filter)
        {
            return query
                .Where(serviceOrder => filter.Service == null || serviceOrder.Service.ToLower().Contains(filter.Service.ToLower()));
        }
    }
}