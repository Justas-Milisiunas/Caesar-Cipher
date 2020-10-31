using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaesarCipher.Tests
{
    [TestClass]
    public class CaesarCipherUnitTests
    {
        private CaesarCipher caesarCipher;

        [TestInitialize]
        public void Startup()
        {
            caesarCipher = new CaesarCipher();
        }

        [DataRow("ABCD", 2, "CDEF", DisplayName = "Uppercase letters")]
        [DataRow("abcd", 2, "cdef", DisplayName = "Lowercase letters")]
        [DataRow("abc def", 5, "fgh ijk", DisplayName = "Whitespace ignore")]
        [DataRow("AbCd EhL", 5, "FgHi JmQ", DisplayName = "Mixed uppercase and lowercase letters with space")]
        [DataRow("xy ZA", 10, "hi JK", DisplayName = "Letters from alphabet end")]
        [DataRow("abc ABC", 26, "abc ABC", DisplayName = "High shift number")]
        [DataRow("zYx", 27, "aZy", DisplayName = "High shift number with alphabet end")]
        [TestMethod]
        public void Encryption_Test_EncryptionSuccessful(string plainText, int shift, string expectedCipherText)
        {
            string actualPlainText = caesarCipher.Encrypt(plainText, shift);

            Assert.AreEqual(expectedCipherText, actualPlainText);
        }

        [DataRow("CDEF", 2, "ABCD", DisplayName = "Uppercase letters")]
        [DataRow("cdef", 2, "abcd", DisplayName = "Lowercase letters")]
        [DataRow("fgh ijk", 5, "abc def", DisplayName = "Whitespace ignore")]
        [DataRow("FgHi JmQ", 5, "AbCd EhL", DisplayName = "Mixed uppercase and lowercase letters with space")]
        [DataRow("hi JK", 10, "xy ZA", DisplayName = "Letters from alphabet end")]
        [DataRow("abc ABC", 26, "abc ABC", DisplayName = "High shift number")]
        [DataRow("aZy", 27, "zYx", DisplayName = "High shift number with alphabet end")]
        [TestMethod]
        public void Decryption_Test_DecryptionSuccessful(string cipherText, int shift, string expectedPlainText)
        {
            string actualPlainText = caesarCipher.Decrypt(cipherText, shift);

            Assert.AreEqual(expectedPlainText, actualPlainText);
        }

    }
}
