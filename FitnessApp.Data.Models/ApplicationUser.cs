using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static FitnessApp.Common.EntityValidationConstants.User;


namespace FitnessApp.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
        }

        [MaxLength(MaxBiographyLength)]
        public string Biography { get; set; } = null!;

        [MaxLength(MaxSpecializationsLength)]
        public string Specializations { get; set; } = null!;

        public double Rating { get; set; }

        // Navigation properties
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
        public virtual ICollection<FitnessClass> Classes { get; set; } = new List<FitnessClass>();
    }
}
