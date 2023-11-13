namespace ProjectDev_Assignment.Views
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }  // Pending, Confirmed, Canceled, Seated, Completed
        public int UserId { get; set; } // Guest details
        public int NumGuests { get; set; } // Number of Guests
        public int TableId { get; set; }

    }
}
