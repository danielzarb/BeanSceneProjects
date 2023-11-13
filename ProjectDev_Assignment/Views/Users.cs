namespace ProjectDev_Assignment.Views
{
    public class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public role Role { get; set; } // Manager, Staff, Member
      
    }

    public enum role
    {
        Admin,
        Manager,
        Staff,
        Member
    }
}
