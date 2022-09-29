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
    public class WorkTeamController : BaseRoutes<IWorkTeamBusiness, IWorkTeamRepository, parafusoInteligenteContext, WorkTeam, WorkTeamEntity, DefaultMapper>
    {
        public WorkTeamController(IWorkTeamBusiness WorkTeamBusiness,
            ILogger<WorkTeamController> logger)
            : base(WorkTeamBusiness, logger)
        {
        }
    }
}