// See https://aka.ms/new-console-template for more information



using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {

        Console.WriteLine("==============19==============");
        // Get the rightmost bit of any input
        void Nineteen(object input)
        {
            if (input is string)
            {
                string numStr = Convert.ToString(input);
                uint numUInt = Convert.ToUInt32(numStr, 2) & 0b1;
                Console.WriteLine(numUInt);
            }
            else if (input is int)
            {
                uint numUInt = Convert.ToUInt32(input) & 0b1;
                string numStr = Convert.ToString(numUInt, 2);
                Debug.Assert(numStr == "1", "Wrong conversion");
                Console.WriteLine(numStr);
            }
        }
        Nineteen("10011");


        Console.WriteLine("==============20==============");
        // Get the 3 rightmost bits of any input
        void Twenty(object input)
        {
            if (input is string)
            {
                string numStr = Convert.ToString(input);
                uint numUInt = Convert.ToUInt32(numStr, 2) & 0b111;
                Console.WriteLine(numUInt);
            }
            else if (input is int)
            {
                uint numUInt = Convert.ToUInt32(input) & 0b111;
                string numStr = Convert.ToString(numUInt, 2);
                Debug.Assert(numStr == "100", "Wrong conversion");
                Console.WriteLine(numStr);
            }
        }
        Twenty(20);


        Console.WriteLine("==============21==============");
        // Get the leftmost bit of any input
        void TwentyOne(object input)
        {
            if (input is string)
            {
                string numStr = Convert.ToString(input);
                uint numUInt = Convert.ToUInt32(numStr, 2) >> (numStr.Length - 1);
                Debug.Assert(numUInt == 1, "Wrong conversion");
                Console.WriteLine(numUInt);
            }
            else if (input is int)
            {
                uint numUInt = Convert.ToUInt32(input);
                string numStr = Convert.ToString(numUInt, 2);
                numUInt = numUInt >> (numStr.Length - 1);
                Console.WriteLine(numUInt);
            }
        }
        TwentyOne("10101");


        Console.WriteLine("==============22==============");
        // Get the 3 leftmost bits of any input
        void TwentyTwo(object input)
        {
            if (input is string)
            {
                string numStr = Convert.ToString(input); ;
                Console.WriteLine(numStr.Substring(0, 3));
            }
            else if (input is int)
            {
                uint numUInt = Convert.ToUInt32(input);
                string numStr = Convert.ToString(numUInt, 2);
                string returnStr = Convert.ToString(numUInt >> (numStr.Length - 3), 2);
                Debug.Assert(returnStr == "101", "Wrong conversion");
                Console.WriteLine(returnStr);
            }
        }
        TwentyTwo(22);


        Console.WriteLine("==============23==============");
        // Remove the rightmost bit of any input
        void TwentyThree(object input)
        {
            if (input is string)
            {
                string numStr = Convert.ToString(input);
                Debug.Assert(numStr == "10111", "Conversion Error");
                Console.WriteLine(numStr.Substring(0, numStr.Length - 1));
            }
            else if (input is int)
            {
                uint numUInt = Convert.ToUInt32(input);
                string numStr = Convert.ToString(numUInt >> 1, 2);
                Debug.Assert(numStr == "1011", "Wrong conversion");
                Console.WriteLine(numStr);

            }
        }
        TwentyThree("10111");


        Console.WriteLine("==============24==============");
        // Remove the rightmost 3 bits of any input
        void TwentyFour(object input)
        {
            if (input is string)
            {
                string numStr = Convert.ToString(input);
                Debug.Assert(numStr == "11000", "Conversion Error");
                Console.WriteLine(numStr.Substring(0, numStr.Length - 3));
            }
            else if (input is int)
            {
                uint numUInt = Convert.ToUInt32(input);
                string numStr = Convert.ToString(numUInt >> 3, 2);
                Debug.Assert(numStr == "11", "Wrong conversion");
                Console.WriteLine(numStr);
            }
        }
        TwentyFour(24);


        Console.WriteLine("==============25==============");
        // Remove the leftmost bit of any input
        void TwentyFive(object input)
        {
            if (input is string)
            {
                string numStr = Convert.ToString(input);
                Debug.Assert(numStr == "11001", "Conversion Error");
                Console.WriteLine(numStr.Substring(1, numStr.Length - 1));
            }
            else if (input is int)
            {
                uint numUInt = Convert.ToUInt32(input);
                string returnStr = Convert.ToString(numUInt << 1, 2);
                Debug.Assert(returnStr == "1001", "Wrong bitwise");
                Console.WriteLine(returnStr);
            }
        }
        TwentyFive("11001");


Console.WriteLine("==============26==============");
        // Remove the 3 leftmost bits of any input
        void TwentySix(object input)
        {
            if (input is string)
            {
                string numStr = Convert.ToString(input);
                Debug.Assert(numStr == "11010", "Conversion Error");
                Console.WriteLine(numStr.Substring(3, numStr.Length-3));
            }
            else if (input is int)
            {
                uint numUInt = Convert.ToUInt32(input);
                string returnStr = Convert.ToString(numUInt & 0b111, 2);
                Debug.Assert(returnStr == "10", "Wrong bitwise");
                Console.WriteLine(returnStr);
            }
        }
        TwentySix(26);
    }
}


