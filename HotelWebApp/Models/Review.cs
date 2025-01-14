using System.ComponentModel.DataAnnotations;

namespace HotelWebApp.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int BookingId { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Message cannot exceed 250 characters.")]
        public string Comment { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

    }
}
