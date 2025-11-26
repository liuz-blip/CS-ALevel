// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

class Program
{
    static void Main()
    {

        string[] favFood = { "fried chicken", "stewed chicken", "jollof rice", "noodles", "watermelon", "lasagne" };


        bool NaiveSearch(string[] list, string target)
        {
            bool found = false;
            foreach (string item in list)
            {
                if (item == target)
                {
                    found = true;
                    return found;
                }
            }
            return found;
        }

        bool BinarySearch(string[] list, string target)
        {
            Array.Sort(list);
            bool found = false;
            int max = list.Length - 1;
            int min = 0;
            int index = (max + min) / 2;

            Debug.Assert(max == 5, "max not max");
            Debug.Assert(index == 2, "index not start at middle");
            Debug.Assert(min == 0, "min not min");

            while (min <= max)
            {
                index = (max + min) / 2;
                if (list[index] == target)
                {
                    found = true;
                    Debug.Assert(list[index] == "fried chicken", "incorrect find");
                    return found;
                }
                else if (string.Compare(list[index], target) < 0)
                {
                    min = index + 1;
                }
                else if (string.Compare(list[index], target) > 0)
                {
                    max = index - 1;
                }
            }
            return found;
        }

        Console.WriteLine(NaiveSearch(favFood, "peaches"));
        Console.WriteLine(BinarySearch(favFood, "friend chicken"));
    }
}

