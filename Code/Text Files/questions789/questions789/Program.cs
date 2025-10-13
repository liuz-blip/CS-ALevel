// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {
        string fileName = "thirty-nine-steps.txt";
        string book = File.ReadAllText(fileName);

        void nonAlphaChar()
        {
            List<char> notLetter = new List<char>();
            foreach (char c in book)
            {
                if (!char.IsLetter(c))
                {
                    notLetter.Add(c);
                }
            }
            Console.WriteLine(string.Join(", ", notLetter));
        }
        
        nonAlphaChar();
    }
}



