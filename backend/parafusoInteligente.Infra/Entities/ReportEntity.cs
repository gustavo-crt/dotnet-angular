using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commons_Core.Entities;
    
namespace parafusoInteligente.Infra.Entities
{
    [Table("T_REPORT")]
    public class ReportEntity : BaseEntity
    {
        [Column(name:"IDENTIFIER")]
        public string Identifier { get; set; }

        [Column(name:"USERNAME")]
        public string Username { get; set; }

        [Column(name:"DATE_TIME_SYNC")]
        public DateTime DateTimeSync { get; set; }

        [Column(name:"ACTION")]
        public string Action { get; set; }

        [Column(name:"REGION")]
        public string Region { get; set; }
	}
}