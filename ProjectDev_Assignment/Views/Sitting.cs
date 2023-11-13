namespace ProjectDev_Assignment
{
    public class Sitting
    {
        public int SittingId { get; set; }
        public string SittingType { get; set; } // Breakfast, Lunch, Dinner, etc.
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Capacity { get; set; }
        public bool IsClosed { get; set; } // For private events
                                        
    }

}
