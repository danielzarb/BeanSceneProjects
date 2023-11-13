using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Assignment
{
    public class GuestRepository
    {
        private RestaurantDbContext context;

        public GuestRepository()
        {
            context = new RestaurantDbContext();
        }

        public void AddGuest(Guest newGuest)
        {
            context.Guests.Add(newGuest);
            context.SaveChanges();
        }

        // Other methods for CRUD operations, queries, etc.
    }

    {
        var newGuest = new Guest
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "johndoe@example.com",
            PhoneNumber = "555-123-4567"
        };

        var guestRepository = new GuestRepository();
        guestRepository.AddGuest(newGuest);

    }
}
