using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class VigenereCipher
    {

        public VigenereCipher() { }
        
        public String EncryptText(String inputString, String key)
        {
            int tableRowSize = 26;
            int tableColumnSize = 26;

            int[,] vignereTable = new int[26,26];

            for (int rows = 0; rows < tableRowSize; rows++)
            {
                for (int columns = 0; columns < tableColumnSize; columns++)
                {
                    vignereTable[rows, columns] = (rows + columns) % 26;
                }
            }

            inputString = inputString.ToUpper();
            key = key.ToUpper();

            String cipherText = "";
            int keyIndex = 0;

            for (int instrTextIndex = 0; instrTextIndex < inputString.Length; instrTextIndex++)
            {
                char instrChar = inputString[instrTextIndex];
                int asciival = (int) instrChar;

                if (instrChar == ' ')
                {
                    cipherText += instrChar;   
                    continue;
                }
                if (Char.IsPunctuation(instrChar))
                {
                    cipherText += instrChar;
                    continue;
                }
                if (asciival == 13)
                {
                    cipherText += "\r";
                    continue;
                }
                if (asciival == 10)
                {
                    cipherText += "\n";
                    continue;
                }
                if (asciival == 9)
                {
                    cipherText += "\t";
                    continue;
                }
                if(asciival < 65 || asciival > 90)
                {
                    cipherText += instrChar;
                    continue;
                }

                int basicInputStringValue = ((int)instrChar) - 65;
                char kChar = key[keyIndex];
                int basicKeyValue = ((int)kChar) - 65;

                int tableEntry = vignereTable[basicInputStringValue,basicKeyValue];

                char cChar = (char)(tableEntry + 65);
                cipherText += cChar;
                keyIndex++;

                if (keyIndex == key.Length)
                    keyIndex = 0;

            }

            return cipherText;
        }
        public String DecryptText(String cipherText, String key)
        {
            int tableRowSize = 26;
            int tableColumnSize = 26;

            int[,] vignereTable = new int[26, 26];

            for (int rows = 0; rows < tableRowSize; rows++)
            {
                for (int columns = 0; columns < tableColumnSize; columns++)
                {
                    vignereTable[rows, columns] = (rows + columns) % 26;
                }
            }

             cipherText = cipherText.ToUpper();
             key = key.ToUpper();

            String decipherText = "";
            int keyIndex = 0;

            for (int ctextIndex = 0; ctextIndex < cipherText.Length; ctextIndex++)
            {
                char cChar = cipherText[ctextIndex];
                int asciival = (int)cChar;

                if (cChar == ' ')
                {
                    decipherText += cChar;
					continue;
                }
				if (Char.IsNumber(cChar))
				{
					decipherText += cChar;
					continue;
				}
                if (Char.IsPunctuation(cChar))
                {
                    decipherText += cChar;
                    continue;
                }
                if (asciival == 13)
                {
                    decipherText += "\r";
                    continue;
                }
                if (asciival == 10)
                {
                    decipherText += "\n";
                    continue;
                }
                if (asciival == 9)
                {
                    decipherText += "\t";
                    continue;
                }
                if (asciival < 65 || asciival > 90)
                {
                    decipherText += asciival;
                    continue;
                }

                int basicCipherTextValue = ((int)cChar) - 65;
                char kChar = key[keyIndex];
                int basicKeyValue = ((int)kChar) - 65;

                for (int dctIndex = 0; dctIndex < tableColumnSize; dctIndex++)
                {
                    if (vignereTable[basicKeyValue, dctIndex] == basicCipherTextValue)
                    {
                        char potcChar = (char)(vignereTable[basicKeyValue, dctIndex] + 65);
                        char potdChar = (char)(dctIndex + 65);

                        decipherText += potdChar;
                    }
                }
                keyIndex++;

                if (keyIndex == key.Length)
                    keyIndex = 0;
            }

            return decipherText;
        }
    }
}
