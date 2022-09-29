using Commons_Core.Business.Interfaces;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;
using parafusoInteligente.Infra.Repository.Interfaces;
    
namespace parafusoInteligente.API.Business.Interfaces
{
    public interface IBusinessRulesBusiness : IBaseBusiness<IBusinessRulesRepository, parafusoInteligenteContext, BusinessRules, BusinessRulesEntity, DefaultMapper>
    {
    }
}