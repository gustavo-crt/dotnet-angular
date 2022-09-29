using System;
using System.Collections.Generic;
using Commons_Core.ViewObject;

namespace parafusoInteligente.Domain.Model
{
    public class ServiceOrder : BaseVO
    {
        public int Os { get; set; }
        public string Service { get; set; }
        public string Address { get; set; }
        public string Meter { get; set; }
        public string Cdc { get; set; }
        public long IdConsumerUnit { get; set; }
        public ConsumerUnit ConsumerUnit { get; set; }
        public long IdWorkTeam { get; set; }
        public WorkTeam WorkTeam { get; set; }
    }
}