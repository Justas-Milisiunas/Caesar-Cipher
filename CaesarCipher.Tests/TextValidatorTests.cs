using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher.Tests
{
    [TestClass]
    public class TextValidatorTests
    {
        private TextValidator textValidator;

        [TestInitialize]
        public void Startup()
        {
            textValidator = new TextValidator();
        }

        [DataRow("abcxyz", DisplayName = "Lowercase letters")]
        [DataRow("ABCXYZ", DisplayName = "Uppercase letters")]
        [DataRow("AbCyYz", DisplayName = "Mixed case letters")]
        [DataRow(" ", DisplayName = "Whitespace")]
        [DataRow("AbCyYz AbCyYz", DisplayName = "Mixed case letters with whitespaces")]
        [TestMethod]
        public void Validation_Test_Valid(string text)
        {
            bool isValid = textValidator.IsValid(text);

            Assert.IsTrue(isValid);
        }

        [DataRow("123", DisplayName = "Number")]
        [DataRow("123 456 798", DisplayName = "Numbers split by whitespace")]
        [DataRow("!@#$%^&*()-+=_", DisplayName = "Mixed symbols")]
        [DataRow("! @ # $ % ^ & * ( ) _ = + _", DisplayName = "Mixed symbols split by whitespace")]
        [DataRow("abioh9asd", DisplayName = "Letters with one digit")]
        [DataRow("AS3N das8", DisplayName = "Mixed letters with numbers split by whitespace")]
        [TestMethod]
        public void Validation_Test_Invalid(string text)
        {
            bool isValid = textValidator.IsValid(text);

            Assert.IsFalse(isValid);
        }
    }
}
