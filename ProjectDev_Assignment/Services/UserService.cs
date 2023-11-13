using ProjectDev_Assignment.Views;
using ProjectDev_Assignment.Controllers;
using System.Linq;

namespace ProjectDev_Assignment.Services
{
    public class UserService
    {
        Users[] _users;



        public Users Authenticate(string UserName,
                                  string PasswordHash)
        {
            var user = _users.SingleOrDefault(user => user.UserName == UserName && user.PasswordHash == PasswordHash);

            if (user == null)
                return null;
            //Needs to be modified
            return user; //user.WithoutPasswordHash;  // Exclude password before returning
        }
        public bool Authorize(string Role)
        {
            return true;
            // Check if user has the required role
            // Implementation depends on your user roles structure
            // You might want to use a claims-based system or roles in the database
            // Return true if authorized, false otherwise
        }
    }

}
