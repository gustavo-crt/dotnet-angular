using System.Linq;
using Commons_Core.DAO;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;
using parafusoInteligente.Infra.Repository.Interfaces;

namespace parafusoInteligente.Infra.Repository
{
    public class ConsumerUnitRepository : BaseDao<parafusoInteligenteContext, ConsumerUnit, ConsumerUnitEntity, DefaultMapper>, IConsumerUnitRepository
    {

        public override IQueryable<ConsumerUnitEntity> GetCustomWhere(IQueryable<ConsumerUnitEntity> query, ConsumerUnit filter)
        {
            return query
                .Where(consumerUnit => filter.ConsumerGroup == null || consumerUnit.ConsumerGroup.ToLower().Contains(filter.ConsumerGroup.ToLower()));
        }
    }
}