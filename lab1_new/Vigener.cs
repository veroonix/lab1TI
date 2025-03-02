using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_new
{
    public class Vigener
    {
        static string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public static string vigenerCipher(string key, string plainText)
        {
            string cipherText = string.Empty;
            int n = alphabet.Length;
            for (int i = 0; i < plainText.Length; i++)
            {
                int m = alphabet.IndexOf(plainText[i]);
                int k = alphabet.IndexOf(key[i % key.Length]);
                int c = (m + k) % n;
                cipherText += alphabet[c];
            }
            return cipherText;
        }

        public static string vigenerDecipher(string key, string cipherText)
        {
            string plainText = "";
            int n = alphabet.Length;
            for (int i = 0; i < cipherText.Length; i++)
            {
                int c = alphabet.IndexOf(cipherText[i]);
                int k = alphabet.IndexOf(key[i % key.Length]);
                int m = (c - k + n) % n;
                plainText += alphabet[m];

            }
            return plainText;
        }
    }
}
