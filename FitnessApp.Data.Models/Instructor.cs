﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessApp.Common.EntityValidationConstants.Instructor;

namespace FitnessApp.Data.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [MaxLength(MaxBiographyLength)]
        public string Biography { get; set; } = null!;

        [Required]
        [MaxLength(MaxSpecializationsLength)]
        public string Specializations { get; set; } = null!;

        [Required]
        public double Rating { get; set; }
        public List<FitnessClass> Classes { get; set; } = new List<FitnessClass> { };

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;
    }
}
