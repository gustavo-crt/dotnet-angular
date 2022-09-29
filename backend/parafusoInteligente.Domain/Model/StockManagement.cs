using System;
using System.Collections.Generic;
using Commons_Core.ViewObject;

namespace parafusoInteligente.Domain.Model
{
    public class StockManagement : BaseVO
    {
        public string Type { get; set; }
        public string Identifier { get; set; }
        public string Location { get; set; }
        public string LastAccess { get; set; }
        public string Status { get; set; }
        public string StockStatus { get; set; }
    }
}