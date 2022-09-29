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
    public class ConsumerUnitController : BaseRoutes<IConsumerUnitBusiness, IConsumerUnitRepository, parafusoInteligenteContext, ConsumerUnit, ConsumerUnitEntity, DefaultMapper>
    {
        public ConsumerUnitController(IConsumerUnitBusiness ConsumerUnitBusiness,
            ILogger<ConsumerUnitController> logger)
            :base(ConsumerUnitBusiness, logger)
        {
        }
    }
}