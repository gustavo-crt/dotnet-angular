using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commons_Core.Entities;
    
namespace parafusoInteligente.Infra.Entities
{
    [Table("T_BUSINESSRULES")]
    public class BusinessRulesEntity : BaseEntity
    {
        [Column(name:"RULE")]
        public string Rule { get; set; }

        [Column(name:"GROUPS_TO_APPLY")]
        public string GroupsToApply { get; set; }

        [Column(name:"PERMISSIONS")]
        public string Permissions { get; set; }

        [Column(name:"HOUR_TO_APPLY")]
        public string HourToApply { get; set; }

        [Column(name:"REGION")]
        public string Region { get; set; }

        [Column(name:"KEYS_TO_APPLY")]
        public string KeysToApply { get; set; }

        [Column(name:"SCREWS_TO_APPLY")]
        public string ScrewsToApply { get; set; }
	}
}