using System.Linq;
using Commons_Core.DAO;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;
using parafusoInteligente.Infra.Repository.Interfaces;

namespace parafusoInteligente.Infra.Repository
{
    public class WorkTeamRepository : BaseDao<parafusoInteligenteContext, WorkTeam, WorkTeamEntity, DefaultMapper>, IWorkTeamRepository
    {
        public override IQueryable<WorkTeamEntity> GetCustomWhere(IQueryable<WorkTeamEntity> query, WorkTeam filter)
        {
            return query
                .Where(workTeam => filter.Team == null || workTeam.Team.ToLower().Contains(filter.Team.ToLower()));
        }
    }
}