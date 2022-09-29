using System;
using System.Collections.Generic;
using Commons_Core.ViewObject;
    
namespace parafusoInteligente.Domain.Model
{
    public class BusinessRules : BaseVO
    {
        public string Rule { get; set; }
        public string GroupsToApply { get; set; }
        public string Permissions { get; set; }
        public string HourToApply { get; set; }
        public string Region { get; set; }
        public string KeysToApply { get; set; }
        public string ScrewsToApply { get; set; }
	}
}