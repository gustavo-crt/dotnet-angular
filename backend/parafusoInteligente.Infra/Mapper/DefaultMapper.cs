using AutoMapper;
using parafusoInteligente.Domain.Model;
using parafusoInteligente.Infra.Entities;

namespace parafusoInteligente.Infra.Mapper
{
    public class DefaultMapper : Profile
    {
        public DefaultMapper()
        {
            CreateMap<BusinessRulesEntity, BusinessRules>()
                .ReverseMap()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<ReportEntity, Report>()
                .ReverseMap()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<ServiceOrderEntity, ServiceOrder>()
                .ReverseMap()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<ConsumerUnitEntity, ConsumerUnit>()
                .ReverseMap()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<WorkTeamEntity, WorkTeam>()
                .ReverseMap()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<StockManagementEntity, StockManagement>()
                .ReverseMap()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}