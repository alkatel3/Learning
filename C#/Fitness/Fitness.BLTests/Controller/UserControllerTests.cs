using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void SetNewUserDataTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();
            var birthDate = DateTime.Now.AddYears(-18);
            var weight = 90;
            var height = 190;
            var gender = "man";
            var controller = new UserController(userName);

            //Act
            controller.SetNewUserData(gender, birthDate, weight, height);
            var controller2 =new UserController(userName);

            //Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);
            Assert.AreEqual(birthDate, controller.CurrentUser.BirthDate);
            Assert.AreEqual(weight, controller.CurrentUser.Weight);
            Assert.AreEqual(height, controller.CurrentUser.Height);
            Assert.AreEqual(gender, controller.CurrentUser.Gender.Name);

        }

        [TestMethod()]
        public void SaveTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();

            //Act
            var controller = new UserController(userName);

            //Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}