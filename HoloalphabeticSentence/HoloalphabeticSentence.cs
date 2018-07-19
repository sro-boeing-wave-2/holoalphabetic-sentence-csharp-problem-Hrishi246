using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            if (input == "") return false;

            char[] data = input.ToLower().ToCharArray();
            char[] target = alphabets.ToCharArray();

            for (int i = 0; i < target.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if (data[j] == target[i]) break;
                    if (j == data.Length-1) return false;
                       
                }

            }
            return true;
        }
    }
}
