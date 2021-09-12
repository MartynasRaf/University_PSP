using LibraryProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTest
{
    [TestClass]
    public class PhoneTests
    {

        [TestMethod]
        public void CheckPhoneNumber_ValidPhoneNumber_ReturnsTrue()
        {
            // Arrange
            string phoneNumber = "+37062030741";

            // Act
            var res = PhoneValidator.CheckPhoneNumber(phoneNumber);

            // Assert
            Assert.AreEqual("+37062030741", res);
        }

        [TestMethod]
        public void CheckPhoneNumber_OtherSymbolsPresentPhoneNumber_ReturnsFalse()
        {
            // Arrange
            string phoneNumber = "862030741abc";

            // Act
            var res = PhoneValidator.CheckPhoneNumber(phoneNumber);

            // Assert
            Assert.AreNotEqual("+37062030741", res);
        }

        [TestMethod]
        public void CheckPhoneNumber_StartsWith8PhoneNumber_ReturnsFalse()
        {
            // Arrange
            string phoneNumber = "862030741";

            // Act
            var res = PhoneValidator.CheckPhoneNumber(phoneNumber);

            // Assert
            Assert.AreNotEqual("+37062030741", res);
        }

    }
}
