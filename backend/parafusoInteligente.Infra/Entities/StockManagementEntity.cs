using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commons_Core.Entities;

namespace parafusoInteligente.Infra.Entities
{
    [Table("T_STOCKMANAGEMENT")]
    public class StockManagementEntity : BaseEntity
    {
        [Required]
        [Column(name: "TYPE")]
        public string Type { get; set; }

        [Required]
        [Column(name: "IDENTIFIER")]
        public string Identifier { get; set; }

        [Required]
        [Column(name: "LOCATION")]
        public string Location { get; set; }

        [Required]
        [Column(name: "LAST_ACCESS")]
        public string LastAccess { get; set; }

        [Required]
        [Column(name: "STATUS")]
        public string Status { get; set; }

        [Required]
        [Column(name: "STOCK_STATUS")]
        public string StockStatus { get; set; }
    }
}