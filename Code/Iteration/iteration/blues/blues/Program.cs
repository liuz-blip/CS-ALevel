// See https://aka.ms/new-console-template for more information


using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.Numerics;

class Program()
{
    static void Main()
    {

        Console.WriteLine("===============Question 6===============");

        void ask(int n)
        {
            double numN = 0;
            double sumN = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter a real number: ");
                string numStr = Console.ReadLine();
                double num = double.Parse(numStr);
                numN++;
                sumN += num;
            }
            double meanN = sumN / numN;
            Console.WriteLine($"The sum of your numbers were {sumN}");
            Console.WriteLine($"The mean of your numbers were {meanN}");
        }

        ask(6);





        Console.WriteLine("===============Question 7===============");

        bool isPrime(int n)
        {
            bool prime = true;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }

        bool isPerfect(int n)
        {
            bool perfect = false;
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (6 % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                perfect = true;
            }
            return perfect;
        }

        bool isAbundant(int n)
        {
            bool abundant = false;
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum > n)
            {
                abundant = true;
            }
            return abundant;
        }

        bool isFriendly(int n, int p)
        {
            bool friendly = false;
            int sumN = 0;
            int sumP = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sumN += i;
                }
            }
            for (int r = 1; r <= p; r++)
            {
                if (p % r == 0)
                {
                    sumP += r;
                }
            }
            if (sumN / n == sumP / p)
            {
                friendly = true;
            }

            return friendly;
        }

        Console.WriteLine($"Prime: {isPrime(6)}");
        Console.WriteLine($"Perfect: {isPerfect(7)}");
        Console.WriteLine($"Abundant: {isAbundant(67)}");
        Console.WriteLine($"Friendly: {isFriendly(30, 140)}");





        Console.WriteLine("===============Question 9===============");

        void guessNum()
        {
            bool found = false;
            Console.WriteLine("Think of a nubmer between 1 and 100");
            Console.WriteLine("Is your number 50, or is it bigger or smaller?");
            string check = Console.ReadLine();
            int mid = 50;
            int max = 100;
            int min = 1;

            while (!found)
            {
                if (check == Convert.ToString(mid))
                {
                    Console.WriteLine("Found");
                    found = true;
                    break;
                }
                else if (check == "bigger")
                {
                    min = mid + 1;
                    mid = (max + min) / 2;
                }
                else if (check == "smaller")
                {
                    max = mid - 1;
                    mid = (max + min) / 2;
                }
                Console.WriteLine($"Is your number {mid}, or is it bigger or smaller?");
                check = Console.ReadLine();
            }
        }

        guessNum();





        Console.WriteLine("===============Question 11===============");

        string reverseWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            string newSentence = "";

            // foreach (string word in words)
            // {
            //     newSentence += word + " ";
            // }
            // newSentence.Trim();

            newSentence = string.Join(" ", words);

            return newSentence;
        }

        Console.WriteLine(reverseWord("I went to bed"));





        Console.WriteLine("===============Question 12===============");

        BigInteger doubleOnReverseInt()
        {
            BigInteger num = 105263157894730000; // Otherwise it takes too long

            while (true)
            {
                string numStr = num.ToString();
                string numStrInverse = numStr[numStr.Length - 1] + numStr.Substring(0, numStr.Length - 1);
                BigInteger numInverse = BigInteger.Parse(numStrInverse);
                if (numInverse == 2 * num)
                {
                    return num;
                }
                num++;
            }
        }

        Console.WriteLine(doubleOnReverseInt() + " is the number");


    }
}

