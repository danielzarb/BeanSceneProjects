using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database_Assignment
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        public int GuestID { get; set; }

        public int SittingID { get; set; }

        public string Status { get; set; }

        public DateTime StartDateTime { get; set; }

        public int DurationMinutes { get; set; }

        public string Source { get; set; }

        public string Notes { get; set; }

        [ForeignKey("GuestID")]
        public Guest Guest { get; set; }

        [ForeignKey("SittingID")]
        public Sitting Sitting { get; set; }
    }
}
