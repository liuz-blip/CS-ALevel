// See https://aka.ms/new-console-template for more information
using System;
using System.Buffers;

class Program
{
    static void Main()
    {
        int[] bigList = { 1, 4, 5, 2, 6, 7, 9, 3, 8 };
        int[] littleList = { 6, 7 };


        bool isSublist(int[] list1, int[] list2)
        {
            bool match = true;
            for (int i = 0; i <= list1.Length - list2.Length; i++)
            {
                for (int r = 0; r < list2.Length; r++)
                {
                    if (list1[i + r] != list2[r])
                    {
                        match = false;
                        break;
                    }
                }
            }
            return match;
        }

        Console.WriteLine(isSublist(bigList, littleList));


    }
}

