// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;




class Program()
{
    static void Main()
    {





        // ===========================================
        // 1
        // ===========================================

        Console.WriteLine("===================Question 1===================");

        int addNums(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        Console.WriteLine(addNums(1, 2));





        // ===========================================
        // 2
        // ===========================================

        Console.WriteLine("===================Question 2===================");

        int digitSum(int num)
        {
            int sum = 0;
            string numStr = num.ToString();

            for (int i = 0; i < numStr.Length; i++)
            {
                char digitChar = numStr[i];
                int digit = digitChar - '0';
                sum += digit;
            }
            return sum;
        }

        Console.WriteLine(digitSum(13025));





        // ===========================================
        // 3
        // ===========================================

        Console.WriteLine("===================Question 3===================");

        bool isPrime(int num)
        {
            bool prime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }

        Console.WriteLine(isPrime(97));





        // ===========================================
        // 4
        // ===========================================

        Console.WriteLine("===================Question 4===================");

        int countSpace(string givenStr)
        {
            int spaces = 0;

            foreach (char i in givenStr)
            {
                if (i == ' ')
                {
                    spaces++;
                }
            }
            return spaces;
        }

        Console.WriteLine(countSpace("The monkey stole my banana!"));





        // ===========================================
        // 5
        // ===========================================

        Console.WriteLine("===================Question 5===================");

        int int1 = 3, int2 = 6;

        void swap(int in1, int in2, out int out1, out int out2)
        {
            out1 = in2;
            out2 = in1;
        }

        swap(int1, int2, out int1, out int2);

        Console.WriteLine(int1 == 6 && int2 == 3);





        // ===========================================
        // 6
        // ===========================================

        Console.WriteLine("===================Question 6===================");

        string translate(int deneryNum, int baseVal)
        {
            string endStr = "";
            if (baseVal == 2)
            {
                endStr = Convert.ToString(deneryNum, 2);
            }
            else if (baseVal == 16)
            {
                endStr = Convert.ToString(deneryNum, 16);
            }
            return endStr;
        }

        Console.WriteLine(translate(418, 16));





        // ===========================================
        // 7
        // ===========================================

        Console.WriteLine("===================Question 7===================");

        void presentTable(int number)
        {
            for (int r = 1; r < (number * 8 + 9); r++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");

            Console.Write("|       ");
            for (int i = 1; i < number + 1; i++)
            {
                Console.Write($"| {i,5} ");
            }
            Console.WriteLine("|");

            for (int i = 1; i < number + 1; i++)
            {
                for (int r = 1; r < (number * 8 + 9); r++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("-");

                Console.Write($"| {i,5} ");
                for (int j = 1; j < number + 1; j++)
                {
                    Console.Write($"| {j * i,5} ");
                }
                Console.WriteLine("|");
            }

            for (int r = 1; r < (number * 8 + 9); r++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");
        }

        presentTable(7);



    }
}