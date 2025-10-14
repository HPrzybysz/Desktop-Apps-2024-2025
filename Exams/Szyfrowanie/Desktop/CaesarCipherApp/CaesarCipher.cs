using System;

namespace CaesarCipherApp
{
    public static class CaesarCipher
    {
        public static string Encrypt(string textToEncrypt, int key)
        {
            if (string.IsNullOrEmpty(textToEncrypt))
                return string.Empty;

            key = key % 26;
            if (key < 0)
            {
                key += 26;
            }

            char[] result = new char[textToEncrypt.Length];

            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                char currentChar = textToEncrypt[i];

                if (currentChar == ' ')
                {
                    result[i] = ' ';
                    continue;
                }

                if (currentChar >= 97 && currentChar <= 122)
                {
                    char shifted = (char)(((currentChar - 97 + key) % 26) + 97);
                    result[i] = shifted;
                }
                else
                {
                    result[i] = currentChar;
                }
            }

            return new string(result);
        }
    }
}