using Commons_Core.Business;
using parafusoInteligente.API.Business.Interfaces;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;
using parafusoInteligente.Infra.Repository.Interfaces;
    
namespace parafusoInteligente.API.Business
{
    public class ServiceOrderBusiness : BaseBusiness<IServiceOrderRepository, parafusoInteligenteContext, ServiceOrder, ServiceOrderEntity, DefaultMapper>, IServiceOrderBusiness
    {
        public ServiceOrderBusiness(IServiceOrderRepository dao) : base(dao)
        {
        }
    }
}