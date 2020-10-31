using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    interface ICaesarCipher
    {
        string Encrypt(string plainText, int shift);
        string Decrypt(string cipherText, int shift);
    }
}
