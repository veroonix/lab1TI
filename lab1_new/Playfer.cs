using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_new
{
    public class Playfer
    {
        public static string alphabetString = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        public static List<char[,]> initKeys(string key1, string key2, string key3, string key4)
        {
            char[,] m1 = new char[5, 5];
            char[,] m2 = new char[5, 5];
            char[,] m3 = new char[5, 5];
            char[,] m4 = new char[5, 5];
            List<char[,]> keyList = new List<char[,]>();
            key1 = generateKey(key1, alphabetString);
            key2 = generateKey(key2, alphabetString);
            key3 = generateKey(key3, alphabetString);
            key4 = Playfer.generateKey(key4, alphabetString);
            m1 = Playfer.generateTable(key1);
            m2 = Playfer.generateTable(key2);
            m3 = Playfer.generateTable(key3);
            m4 = Playfer.generateTable(key4);
            keyList = Playfer.makeKeyList(m1, m2, m3, m4);
            return keyList;
        }
        public static string generateKey(string keyInput, string alphabet)
        {
            //исключить повторяющиеся символы ключа
            HashSet<char> uniqueChars = new HashSet<char>();
            List<char> keyList = new List<char>();

            int startInd = 0;
            for (int i = 0; i < keyInput.Length; i++)
            {
                char currentChar = keyInput[i];
                if (currentChar == 'J')
                {
                    currentChar = 'I';
                }
                if (!uniqueChars.Contains(currentChar))
                {
                    keyList.Add(currentChar);
                    uniqueChars.Add(currentChar);
                    startInd++;
                }
            }

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (!uniqueChars.Contains(alphabet[i]))
                {
                    keyList.Add(alphabet[i]);
                    uniqueChars.Add(alphabet[i]);
                }
            }

            return new string(keyList.ToArray()); ;
        }

        public static char[,] generateTable(string key)
        {
            int idx = 0;
            char[,] matrix = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = key[idx];
                    idx++;
                }
            }

            return matrix;
        }

        public static void findInx(char[,] matrix, char letter, ref int rowIdx, ref int colInd)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == letter)
                    {
                        rowIdx = i;
                        colInd = j;
                    }
                }
            }
        }

        public static List<char[,]> makeKeyList(char[,] key1, char[,] key2, char[,] key3, char[,] key4)
        {
            List<char[,]> keyList = new List<char[,]>();
            keyList.Add(key1);
            keyList.Add(key2);
            keyList.Add(key3);
            keyList.Add(key4);
            return keyList;
        }
        public static string playferCipher(List<char[,]> key, string plainText, string alphabet)
        {
            string cipherText = string.Empty;
            if ((plainText.Length % 2) != 0)
            {
                plainText += 'X';
            }

            int pos = 0;

            while (pos < plainText.Length)
            {
                char m1 = plainText[pos];
                if (m1 == 'J')
                {
                    m1 = 'I';
                }
                char m2 = plainText[pos + 1];
                if (m2 == 'J')
                {
                    m2 = 'I';
                }
                pos += 2;

                int i2 = 0;
                int j2 = 0;
                int i3 = 0;
                int j3 = 0;
                findInx(key[0], m1, ref i2, ref j3);
                findInx(key[3], m2, ref i3, ref j2);
                char c1 = key[1][i2, j2];
                char c2 = key[2][i3, j3];
                cipherText += c1;
                cipherText += c2;
            }

            return cipherText;
        }
        public static string playferDecipher(List<char[,]> key, string cipherText, string alphabet)
        {
            string plainText = string.Empty;

            int pos = 0;

            while (pos < cipherText.Length)
            {
                char m1 = cipherText[pos];
                char m2 = cipherText[pos + 1];
                pos += 2;
                int i1 = 0;
                int i4 = 0;
                int j1 = 0;
                int j4 = 0;
                findInx(key[1], m1, ref i1, ref j4);
                findInx(key[2], m2, ref i4, ref j1);
                char c1 = key[0][i1, j1];
                char c2 = key[3][i4, j4];
                plainText += c1;
                plainText += c2;
            }
            return plainText;
        }
    }
}
