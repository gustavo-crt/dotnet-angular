using Commons_Core.DAO;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra.Entities;
using parafusoInteligente.Infra.Mapper;
using parafusoInteligente.Infra.Repository.Interfaces;
    
namespace parafusoInteligente.Infra.Repository
{
    public class ReportRepository : BaseDao<parafusoInteligenteContext, Report, ReportEntity, DefaultMapper>, IReportRepository
    {
    }
}