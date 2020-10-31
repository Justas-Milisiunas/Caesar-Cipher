using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    interface ITextValidator
    {
        bool IsValid(string text);
    }
}
