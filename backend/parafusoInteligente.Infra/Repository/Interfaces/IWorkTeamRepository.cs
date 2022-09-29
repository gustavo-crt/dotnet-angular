using Commons_Core.DAO.Interfaces;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;

namespace parafusoInteligente.Infra.Repository.Interfaces
{
    public interface IWorkTeamRepository : IBaseDao<parafusoInteligenteContext, WorkTeam, WorkTeamEntity, DefaultMapper>
    {
    }
}