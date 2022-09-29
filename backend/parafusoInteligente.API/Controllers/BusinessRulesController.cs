using Commons_Core.API;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using parafusoInteligente.API.Business.Interfaces;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;
using parafusoInteligente.Infra.Repository.Interfaces;
    
namespace parafusoInteligente.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessRulesController : BaseRoutes<IBusinessRulesBusiness, IBusinessRulesRepository, parafusoInteligenteContext, BusinessRules, BusinessRulesEntity, DefaultMapper>
    {
        public BusinessRulesController(IBusinessRulesBusiness BusinessRulesBusiness,
            ILogger<BusinessRulesController> logger)
            :base(BusinessRulesBusiness, logger)
        {
        }
    }
}