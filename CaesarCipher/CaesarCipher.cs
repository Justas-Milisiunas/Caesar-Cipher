using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    class CaesarCipher : ICaesarCipher
    {
        public string Encrypt(string plainText, int shift)
        {
            return CaesarCipherAlhorithm(plainText, shift);
        }

        public string Decrypt(string cipherText, int shift)
        {
            return CaesarCipherAlhorithm(cipherText, -shift);
        }

        private static string CaesarCipherAlhorithm(string text, int shift)
        {
            char[] letters = text.ToCharArray();
            StringBuilder modifiedText = new StringBuilder();

            foreach (var letter in letters)
            {
                char shiftedLetter = ShiftLetter(letter, shift);
                modifiedText.Append(shiftedLetter);
            }

            return modifiedText.ToString();
        }

        private static char ShiftLetter(char letter, int shift)
        {
            return (char)(letter + shift);
        }
    }
}
