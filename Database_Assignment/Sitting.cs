using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Database_Assignment
{
    public class Sitting
    {
        [Key]
        public int SittingID { get; set; }

        public string SittingType { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public int Capacity { get; set; }

        public bool IsClosed { get; set; }
    }
}
