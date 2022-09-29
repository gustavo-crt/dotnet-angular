using System.Linq;
using Commons_Core.DAO;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;
using parafusoInteligente.Infra.Repository.Interfaces;

namespace parafusoInteligente.Infra.Repository
{
    public class BusinessRulesRepository : BaseDao<parafusoInteligenteContext, BusinessRules, BusinessRulesEntity, DefaultMapper>, IBusinessRulesRepository
    {
        public override IQueryable<BusinessRulesEntity> GetCustomWhere(IQueryable<BusinessRulesEntity> query, BusinessRules filter)
        {
            return query
                .Where(businessRule => filter.Rule == null || businessRule.Rule.ToLower().Contains(filter.Rule.ToLower()));
        }
    }
}