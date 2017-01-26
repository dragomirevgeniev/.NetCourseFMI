using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranspositionCipher
{
    public class Encryption
    {
        private int key;
        public Encryption(string keyString)
        {
            key = keyString.Length;
        }

        public string Encrypt(string plainText)
        {
            string encryptedText = "";
            char[] plainChars;  // the chars of the plaintext
            char[,] encodingMatrix;  // the matrix used to encrypt
            char[] encryptedChars;  // the chars of the cipher text
            int rows;
            int cols;
            int counter;  //counts currently read chars          

            plainChars = new char[plainText.Length];
            cols = key;
            rows = (int)Math.Ceiling((double)plainText.Length / key);
            encodingMatrix = new char[rows,cols];
            encryptedChars = new char[rows * cols];

            // write rows
            counter = 0;
            plainChars = plainText.ToCharArray();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (counter < plainText.Length)
                    {
                        encodingMatrix[i, j] = plainChars[counter++];
                    }
                    else
                    {
                        encodingMatrix[i, j] = ' ';
                    }
                }
            }

            // read by cols 
            counter = 0;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    encryptedChars[counter++] = encodingMatrix[j, i];
                }
            }

            return encryptedText = new string(encryptedChars);
        }

        public string Decrypt(string cipherText)
        {
            string decryptedText = "";
            char[] cipherChars;  // the chars of the cipher text
            char[,] decodingMatrix;  // the matrix used to decrypt
            char[] decryptedChars;  // the chars of the plain text
            int rows;
            int cols;
            int counter;  //counts currently read chars          

            cipherChars = new char[cipherText.Length];
            cols = (int)Math.Ceiling((double)cipherText.Length / key);
            rows = key;
            decodingMatrix = new char[rows, cols];
            decryptedChars = new char[rows * cols];

            // write rows
            counter = 0;
            cipherChars = cipherText.ToCharArray();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (counter < cipherText.Length)
                    {
                        decodingMatrix[i, j] = cipherChars[counter++];
                    }
                    else
                    {
                        decodingMatrix[i, j] = ' ';
                    }
                }
            }

            // read by cols 
            counter = 0;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    decryptedChars[counter++] = decodingMatrix[j, i];
                }
            }

            return decryptedText = new string(decryptedChars);
        }
    }
}
