using System;
namespace UnitTestsLessons
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanCancelBy(User user)
        {
            return user.IsAdmin || user == MadeBy;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
