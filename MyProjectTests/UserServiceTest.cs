using NUnit.Framework;
using MyProject;

namespace MyProjectTests
{
    [TestFixture]
    public class UserServiceTest
    {
        private User user1;
        private UserService userService1;

        [SetUp]
        public void Setup()
        {
            user1 = new User{
                Roles = new[] { "User" },
                ManagedCountries = new[] { "Sweden" }
            };

            userService1 = new UserService(user1);
        }

        [Test]
        public void CanDeleteCountry_UserIsNotCountryManager_ReturnsFalse()
        {
            bool canDeleteCountry = userService1.CanDeleteCountry("Romania");
            Assert.IsFalse(canDeleteCountry);
        }
    }
}