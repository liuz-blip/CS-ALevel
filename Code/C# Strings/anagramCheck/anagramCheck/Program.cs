// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {
        
        int anagramCheck(string checkStr, List<string> toCheckStr)
        {
            int anagrams = 0;

            foreach (string word in toCheckStr)
            {
                List<char> letters = new List<char>();
                foreach (char c in word)
                {
                    letters.Add(c);
                }
            }

            return anagrams;
        }


    }
}


