using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commons_Core.Entities;

namespace parafusoInteligente.Infra.Entities
{
    [Table("T_CONSUMERUNIT")]
    public class ConsumerUnitEntity : BaseEntity
    {
        [Column(name: "CONSUMER_GROUP")]
        public string ConsumerGroup { get; set; }

        [Column(name: "COORDINATES")]
        public string Coordinates { get; set; }

        [Column(name: "ADDRESS")]
        public string Address { get; set; }

        [Column(name: "METER_CODE")]
        public int MeterCode { get; set; }

        [Column(name: "SCREWS")]
        public string Screws { get; set; }

        [Column(name: "REGION")]
        public string Region { get; set; }

        public List<ServiceOrderEntity> ServiceOrders { get; set; }
    }
}