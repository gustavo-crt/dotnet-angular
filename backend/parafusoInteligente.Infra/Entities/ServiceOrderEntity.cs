using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commons_Core.Entities;

namespace parafusoInteligente.Infra.Entities
{
    [Table("T_SERVICEORDER")]
    public class ServiceOrderEntity : BaseEntity
    {
        [Required]
        [Column(name: "OS")]
        public int Os { get; set; }

        [Column(name: "SERVICE")]
        public string Service { get; set; }

        [Column(name: "ADDRESS")]
        public string Address { get; set; }

        [Column(name: "METER")]
        public string Meter { get; set; }

        [Column(name: "CDC")]
        public string Cdc { get; set; }

        [Column(name: "ID_CONSUMER_UNIT")]
        public long IdConsumerUnit { get; set; }

        [ForeignKey("IdConsumerUnit")]
        public ConsumerUnitEntity ConsumerUnit { get; set; }

        [Column(name: "ID_WORK_TEAM")]
        public long IdWorkTeam { get; set; }

        [ForeignKey("IdWorkTeam")]
        public WorkTeamEntity WorkTeam { get; set; }
    }
}