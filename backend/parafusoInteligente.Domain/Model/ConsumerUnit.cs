using System;
using System.Collections.Generic;
using Commons_Core.ViewObject;

namespace parafusoInteligente.Domain.Model
{
    public class ConsumerUnit : BaseVO
    {
        public string ConsumerGroup { get; set; }
        public string Coordinates { get; set; }
        public string Address { get; set; }
        public int MeterCode { get; set; }
        public string Screws { get; set; }
        public string Region { get; set; }
        public List<ServiceOrder> ServiceOrders { get; set; }
    }
}