using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int anagramCheck(string checkStr, List<string> toCheckStr)
        {
            int anagrams = 0;
            char[] mainWord = checkStr.ToCharArray();
            Array.Sort(mainWord);
            string mainWordStr = new string(mainWord);


            foreach (string word in toCheckStr)
            {
                char[] letters = word.ToCharArray();
                Array.Sort(letters);
                string sortedWordStr = new string(letters);
                
                if (mainWordStr == sortedWordStr)
                {
                    anagrams++;
                }
            }

            return anagrams;
        }

        Console.WriteLine(anagramCheck("star", new List<string> { "rats", "arts", "arc" }));
    }
}