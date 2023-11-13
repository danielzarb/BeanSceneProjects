using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Database_Assignment
{
    public class RestaurantTable
    {
        [Key]
        public int TableID { get; set; }

        public int AreaID { get; set; }

        public int TableNumber { get; set; }
    }
}
