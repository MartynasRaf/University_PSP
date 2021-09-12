using LibraryProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTest
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void CheckPassword_ValidPassword_ReturnsTrue()
        {
            // Arrange
            string password = "GoodPassword123!";

            // Act
            var res = PasswordChecker.CheckPassword(password);

            // Assert
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void CheckPassword_ShortPassword_ReturnsFalse()
        {
            // Arrange
            string password = "Good";

            // Act
            var res = PasswordChecker.CheckPassword(password);

            // Assert
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void CheckPassword_LowercasePassword_ReturnsFalse()
        {
            // Arrange
            string password = "goodpassword123!";

            // Act
            var res = PasswordChecker.CheckPassword(password);

            // Assert
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void CheckPassword_NoSpecialSymbolPassword_ReturnsFalse()
        {
            // Arrange
            string password = "goodpassword123";

            // Act
            var res = PasswordChecker.CheckPassword(password);

            // Assert
            Assert.AreEqual(false, res);
        }
    }
}
