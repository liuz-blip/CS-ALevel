// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {

        void mexicanWave(string inputStr)
        {
            string[] wave = new string[inputStr.Length];
            for (int i = 0; i < inputStr.Length; i++)
            {
                string tempStr = "";
                tempStr += inputStr.Substring(0, i);
                tempStr += char.ToUpper(inputStr[i]);
                tempStr += inputStr.Substring(i + 1, inputStr.Length - i - 1);
                wave[i] = tempStr;
            }
            Console.Write("[");
            for (int i = 0; i < wave.Length - 1; i++)
            {
                Console.Write($"\"{wave[i]}\",");
            }
            Console.WriteLine($"\"{wave[wave.Length - 1]}\"]");
        }

        mexicanWave("hello");

    }
}

