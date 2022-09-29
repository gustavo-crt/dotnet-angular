using Commons_Core.Business;
using parafusoInteligente.API.Business.Interfaces;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;
using parafusoInteligente.Infra.Repository.Interfaces;

namespace parafusoInteligente.API.Business
{
    public class WorkTeamBusiness : BaseBusiness<IWorkTeamRepository, parafusoInteligenteContext, WorkTeam, WorkTeamEntity, DefaultMapper>, IWorkTeamBusiness
    {
        public WorkTeamBusiness(IWorkTeamRepository dao) : base(dao)
        {
        }
    }
}