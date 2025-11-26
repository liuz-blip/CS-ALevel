// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {

        int[] numList = { 4, 1, 3, 5, 6, 1, 4, 7, 2, 4, 1, 6, 9, 7 };

        List<int> FindDuplicates(int[] unsortedList)
        {
            List<int> duplicates = new List<int>();

            foreach (int num1 in unsortedList)
            {
                int count = 0;
                foreach (int num2 in unsortedList)
                {
                    if (num1 == num2)
                    {
                        count++;
                    }
                }

                bool alreadyAdded = false;
                foreach (int dupe in duplicates)
                {
                    if (dupe == num1)
                    {
                        alreadyAdded = true;
                        break;
                    }
                }
                if (count > 1 && !alreadyAdded)
                {
                    duplicates.Add(num1);
                }

            }
            return duplicates;
        }


        List<int> repeatedNums = FindDuplicates(numList);

        foreach (int num in repeatedNums)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("");




    }
}


