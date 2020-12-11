using NUnit.Framework;
using UnitTestsLessons;

namespace UnitTestsLessonsTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanCancelBy_UserIsAdmin_ReturnTrue()
        {
            Reservation reservation = new Reservation();

            bool result = reservation.CanCancelBy(new User { IsAdmin = true });

            Assert.IsTrue(result);
        }

        [Test]
        public void CanCancelBy_MadeByUser_ReturnTrue()
        {
            User user = new User();
            Reservation reservation = new Reservation { MadeBy = user };

            bool result = reservation.CanCancelBy(user);

            Assert.IsTrue(result);
        }

        [Test]
        public void CanCancelBy_AnyUser_ReturnFalse()
        {
            Reservation reservation = new Reservation { MadeBy = new User() };

            bool result = reservation.CanCancelBy(new User());

            Assert.IsFalse(result);
        }
    }
}
