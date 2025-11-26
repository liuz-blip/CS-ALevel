// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {

        int[] numList1 = { 1, 2, 3, 4, 5, 6, 7, 6, 7, 6, 7, 6, 7 };
        int[] numList2 = { 1, 2, 3, 4, 5, 6, 7 };
        int[] numList3 = { 6, 7, 6, 7, 6, 7, 6, 7, 6, 7 };




        bool SameItems(int[] list1, int[] list2)
        {
            bool same = false;

            var set1 = list1.Distinct().ToArray();  // I know that you told us not to use var but I
            var set2 = list2.Distinct().ToArray();  // don't know what else to do since I'm using sets

            if (set1.Length != set2.Length)
            {
                same = false;
                return same;
            }

            Array.Sort(set1);
            Array.Sort(set2);

            for (int i = 0; i < set1.Length; i++)
            {
                if (set1[i] != set2[i])
                {
                    same = false;
                    return same;
                }
            }
            same = true;
            return same;
        }

        Console.WriteLine(SameItems(numList1, numList2));
        Console.WriteLine(SameItems(numList1, numList3));

    }
}

