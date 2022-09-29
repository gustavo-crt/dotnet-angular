using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commons_Core.Entities;

namespace parafusoInteligente.Infra.Entities
{
    [Table("T_WORK_TEAM")]
    public class WorkTeamEntity : BaseEntity
    {
        [Required]
        [Column(name: "TEAM")]
        public string Team { get; set; }

        [Required]
        [Column(name: "USERS")]
        public string Users { get; set; }

        [Required]
        [Column(name: "SCREWS")]
        public string Screws { get; set; }

        public List<ServiceOrderEntity> ServiceOrders { get; set; }
    }
}