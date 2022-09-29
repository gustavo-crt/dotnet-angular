using Commons_Core.Business;
using parafusoInteligente.API.Business.Interfaces;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;
using parafusoInteligente.Infra.Repository.Interfaces;
    
namespace parafusoInteligente.API.Business
{
    public class ConsumerUnitBusiness : BaseBusiness<IConsumerUnitRepository, parafusoInteligenteContext, ConsumerUnit, ConsumerUnitEntity, DefaultMapper>, IConsumerUnitBusiness
    {
        public ConsumerUnitBusiness(IConsumerUnitRepository dao) : base(dao)
        {
        }
    }
}