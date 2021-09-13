using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Password
    {
        public static void MakePassword()
        {
            string[] passWords = { "aX2#", "sed2T", "*v3X", "Ae234&B", "fg234", "g1HL", "#1$23", "5a7%" };

            foreach (string passWord in passWords)
            {
                bool b = ValidatePassword(passWord);
                Console.WriteLine("'{0}' is{1} a valid password", passWord, b ? "" : "n't");
            }
            Console.ReadKey();
        }
        
        static bool ValidatePassword(string passWord)
        {
            int validConditions = 0;
            
            foreach(char c in passWord)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }

            foreach(char c in passWord)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }

            if (validConditions == 0) return false;
            foreach(char c in passWord)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }

            if (validConditions == 1) return false;
            if (validConditions == 2)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' };
                if (passWord.IndexOfAny(special) == -1) return false;
            }

            return true;
        }
    }
}
