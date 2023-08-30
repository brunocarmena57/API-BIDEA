using System.ComponentModel.DataAnnotations;

namespace HotelBookingAPI.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }

        [MinLength(2), MaxLength(50)]
        public string ClientsName { get; set; }

        [MinLength(2), MaxLength(50)]
        public string lastName { get; set; }

        [Range(18,100)]
        public int age { get; set; }
        public int startDate { get; set; }
        public int endDate { get; set; }

        [MinLength(9), MaxLength(20)]
        public string phoneNumber { get; set; }

        [MinLength(6), MaxLength(15)]
        public string houseId { get; set; }

        [MinLength(8), MaxLength(8)]
        public string discountCode { get; set; }

    }
}
