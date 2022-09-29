using System;
using System.Collections.Generic;
using Commons_Core.ViewObject;

namespace parafusoInteligente.Domain.Model
{
    public class WorkTeam : BaseVO
    {
        public string Team { get; set; }
        public string Users { get; set; }
        public string Screws { get; set; }
        public List<ServiceOrder> ServiceOrders { get; set; }
    }
}