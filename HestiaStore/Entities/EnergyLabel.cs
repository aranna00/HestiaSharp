﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HestiaStore.DTO;

namespace HestiaStore.Entities
{
    [Table("energy_labels")]
    public class EnergyLabel : IEnergyLabel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Name { get; set; }
    }
}