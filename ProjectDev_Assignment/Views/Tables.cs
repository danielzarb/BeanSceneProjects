namespace ProjectDev_Assignment
{
    public class Tables
    {
        public int TableId { get; set; }
        public string Name { get; set; }
        // number of available seats on a table
        public int Seats { get; set; }
        public Boolean IsAvailable { get; set; }
        public string Area { get; set; } // Main, Outside, Balcony
    }
}
