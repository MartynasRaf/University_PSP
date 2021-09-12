using LibraryProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTest
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        public void CheckEmail_ValidEmail_ReturnsTrue()
        {
            // Arrange
            string email = "goodemail@gmail.com";

            // Act
            var res = EmailValidator.Validate(email);

            // Assert
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void CheckEmail_DoesNotContainEtaEmail_ReturnsFalse()
        {
            // Arrange
            string email = "goodemailgmail.com";

            // Act
            var res = EmailValidator.Validate(email);

            // Assert
            Assert.AreEqual(false, res);
        }


        [TestMethod]
        public void CheckEmail_DomainIsIncorrectEmail_ReturnsFalse()
        {
            // Arrange
            string email = "goodemail@com";

            // Act
            var res = EmailValidator.Validate(email);

            // Assert
            Assert.AreEqual(false, res);
        }

    }
}
