// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string[] normList = { "apple", "banana", "carrot", "dumpling" };

        string[] reverseList(string[] list)
        {
            string[] reversedList = { };
            Debug.Assert(list.Length - 1 == 3, "wrong length list");
            for (int i = list.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
                reversedList = reversedList.Append(list[i]).ToArray();
            }
            return reversedList;
        }

        string[] revList = reverseList(normList);
        Debug.Assert(normList.Length == 4, "normListLen wrong");
        foreach (string item in revList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("");
    }
}

