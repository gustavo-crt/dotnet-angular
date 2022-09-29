using System;
using System.Collections.Generic;
using Commons_Core.ViewObject;
    
namespace parafusoInteligente.Domain.Model
{
    public class Report : BaseVO
    {
        public string Identifier { get; set; }
        public string Username { get; set; }
        public DateTime? DateTimeSync { get; set; }
        public string Action { get; set; }
        public string Region { get; set; }
	}
}