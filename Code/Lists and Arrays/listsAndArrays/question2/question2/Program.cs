// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {

        string[] ballerList = { "Chef", "Uncle Drew", "Slim Reaper", "Black Mamba", "King", "Big Fella" };

        void printList()
        {
            Console.Write("[");
            for (int i = 0; i < ballerList.Length; i++)
            {
                string baller = ballerList[i];
                Console.Write($"\"{baller}\"");
                if (i < ballerList.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
        }

        printList();

    }
}





