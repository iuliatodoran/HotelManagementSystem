using System.ComponentModel.DataAnnotations;

namespace HotelAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
        public int RoomId { get; set; }

        public Room Room { get; set; }
    }
}
