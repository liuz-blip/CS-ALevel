// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        int[] numList = { -41, 67, -6, -7, -21, 4 };

        int sum()
        {
            int total = 0;
            foreach (int num in numList)
            {
                total += num;
            }
            return total;
        }

        int max()
        {
            int greatest = numList[0];
            foreach (int num in numList)
            {
                if (num > greatest)
                {
                    greatest = num;
                }
            }
            return greatest;
        }

        int min()
        {
            int smallest = numList[0];
            foreach (int num in numList)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            return smallest;
        }

        Console.WriteLine(sum());
        Console.WriteLine(max());
        Console.WriteLine(min());

    }
}

