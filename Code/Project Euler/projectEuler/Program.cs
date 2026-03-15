// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;



class Program
{
    static void Main()
    {
        // // Problem 0
        // long sums = 0;

        // for (long i = 1; i <= 745000; i += 2)
        // {
        //     sums += i * i;
        // }
        // Console.WriteLine(sums);


        // Problem 1
        int sum = 0;
        for (int i = 0; i <= 1000; i += 5)
        {
            sum += i;
        }
        for (int j = 0; j <= 1000; j += 3)
        {
            sum += j;
        }
        Console.WriteLine(sum);
    }
}

