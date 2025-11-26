// See https://aka.ms/new-console-template for more information


class Program()
{
    static void Main()
    {




        Console.WriteLine("===============Question 1===============");

        void countDown(int n)
        {
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Blastoff!");
        }

        countDown(6);





        Console.WriteLine("===============Question 2===============");

        void triangleStars(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int r = 0; r < i + 1; r++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        triangleStars(7);





        Console.WriteLine("===============Question 2===============");

        void drawGrid(int rows, int cols)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c1 = 0; c1 < cols; c1++)
                {
                    Console.Write("+---");
                }
                Console.WriteLine("+");
                for (int c2 = 0; c2 < cols; c2++)
                {
                    Console.Write("|   ");
                }
                Console.WriteLine("|");
            }
            for (int c = 0; c < cols; c++)
            {
                Console.Write("+---");
            }
            Console.WriteLine("+");
        }

        drawGrid(6, 7);



    }
}

