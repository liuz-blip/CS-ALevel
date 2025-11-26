// See https://aka.ms/new-console-template for more information

using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Runtime.CompilerServices;



class Program()
{
    static void Main()
    {





        // ================================================
        // 1
        // ================================================

        Console.WriteLine("===============Question 1===============");

        void compareInt(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Is Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }

        compareInt(5, 9);





        // ================================================
        // 2
        // ================================================

        Console.WriteLine("===============Question 2===============");

        void isEven(int num)
        {
            bool even;

            if (num % 2 == 0)
            {
                Console.WriteLine("Is even");
            }
            else
            {
                Console.WriteLine("Not even");
            }
        }

        isEven(11);





        // ================================================
        // 3
        // ================================================

        Console.WriteLine("===============Question 3===============");

        void isLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                Console.WriteLine("Is leap year");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }
        }

        isLeapYear(2008);





        // ================================================
        // 4
        // ================================================

        Console.WriteLine("===============Question 4===============");

        void fizzBuzz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(Convert.ToString(num));
            }
        }

        fizzBuzz(15);





        // ================================================
        // 5
        // ================================================

        Console.WriteLine("===============Question 5===============");

        void factors(int num)
        {
            int factors = 0;
            for (int i = 1; i < num + 1; i++)
            {
                if (num % i == 0)
                {
                    factors += 1;
                }
            }
            Console.WriteLine($"Factors: {factors}");
        }

        factors(18);





        // ================================================
        // 6
        // ================================================

        Console.WriteLine("===============Question 6===============");

        void isVowel(char letter)
        {
            bool vowel = false;
            string vowels = "aeiou";
            letter = Char.ToLower(letter);

            for (int i = 0; i < vowels.Length; i++)
            {
                if (letter == vowels[i])
                {
                    vowel = true;
                    break;
                }
            }
            if (vowel)
            {
                Console.WriteLine($"'{letter}' is a vowel");
            }
            else
            {
                Console.WriteLine($"'{letter}' is not a vowel");
            }
        }

        isVowel('a');





        // ================================================
        // 7
        // ================================================

        Console.WriteLine("===============Question 7===============");

        void storageBlocks(double fileSize)
        {
            const int blockSize = 512;
            fileSize *= Math.Pow(2, 10);
            double blocks = fileSize / blockSize;
            Console.WriteLine($"{blocks} blocks needed");
        }

        storageBlocks(10);





        // ================================================
        // 8
        // ================================================

        Console.WriteLine("===============Question 8===============");

        void pocketMoney()
        {
            Console.WriteLine("Pocket money per week: ");
            string weeklyIncomeStr = Console.ReadLine();
            double weeklyIncome = double.Parse(weeklyIncomeStr);
            Console.WriteLine("What percent to save");
            string percentSaveStr = Console.ReadLine();
            double percentSave = double.Parse(percentSaveStr);

            double moneySavedWeek = percentSave / 100 * weeklyIncome;
            double moneySavedYear = percentSave / 100 * weeklyIncome * 52;

            Console.WriteLine($"Save {moneySavedWeek} money per week");
            Console.WriteLine($"Saved {moneySavedYear} money per year");
        }

        pocketMoney();





        // ================================================
        // 9
        // ================================================

        Console.WriteLine("===============Question 9===============");

        void biggestInt()
        {
            Console.WriteLine("Enter an integer: ");
            string int1Str = Console.ReadLine();
            int int1 = int.Parse(int1Str);

            Console.WriteLine("Enter an integer: ");
            string int2Str = Console.ReadLine();
            int int2 = int.Parse(int2Str);

            Console.WriteLine("Enter an integer: ");
            string int3Str = Console.ReadLine();
            int int3 = int.Parse(int3Str);

            if (int1 > int3 && int1 > int2)
            {
                Console.WriteLine($"{int1} is the biggest");
            }
            else if (int2 > int1 && int2 > int3)
            {
                Console.WriteLine($"{int2} is the biggest");
            }
            else if (int3 > int1 && int3 > int2)
            {
                Console.WriteLine($"{int3} is the biggest");
            }
        }

        biggestInt();





        // ================================================
        // 10
        // ================================================

        Console.WriteLine("===============Question 10===============");

        void determineQuadrant(int x, int y)
        {
            int quadrant = 0;

            if (x > 0 && y > 0)
            {
                quadrant = 1;
            }
            else if (x < 0 && y > 0)
            {
                quadrant = 2;
            }
            else if (x < 0 && y < 0)
            {
                quadrant = 3;
            }
            else if (x > 0 && y < 0)
            {
                quadrant = 4;
            }
            Console.WriteLine($"Coordinate is in quadrant {quadrant}");
        }

        determineQuadrant(-1, 10);





        // ================================================
        // 11
        // ================================================

        Console.WriteLine("===============Question 11===============");

        void determineGrade(double quiz, double block, double final)
        {
            double sum = quiz + block + final;
            double avg = sum / 3;

            if (avg >= 0 && avg < 50)
            {
                Console.WriteLine("F");
            }
            else if (avg >= 50 && avg < 70)
            {
                Console.WriteLine("C");
            }
            else if (avg >= 70 && avg < 80)
            {
                Console.WriteLine("B");
            }
            else if (avg >= 80 && avg < 90)
            {
                Console.WriteLine("A");
            }
            else if (avg >= 90 && avg <= 100)
            {
                Console.WriteLine("A*");
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }

        determineGrade(32, 47, 43);





        // ================================================
        // 12
        // ================================================

        Console.WriteLine("===============Question 12===============");

        void ageEligibility()
        {
            Console.WriteLine("Which year were you born: ");
            string yearStr = Console.ReadLine();
            int year = int.Parse(yearStr);
            Console.WriteLine("Which month were you born: ");
            string monthStr = Console.ReadLine();
            int month = int.Parse(monthStr);
            Console.WriteLine("Which day were you born: ");
            string dayStr = Console.ReadLine();
            int day = int.Parse(dayStr);

            DateTime birthDate = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;
            int age = 0;
            Console.WriteLine($"You are {currentDate.Subtract(birthDate) / 365.25} years old");
        }

        ageEligibility();





        // ================================================
        // 13
        // ================================================

        Console.WriteLine("===============Question 13===============");

        double cosineRule(int sideA, int sideB, int sideC)
        {
            double angleC = (sideA * sideA + sideB * sideB - sideC * sideC) / (2 * sideA * sideB);
            return angleC;
        }

        void determineTriangle(int side1, int side2, int side3)
        {
            double angleA = cosineRule(side2, side3, side1);
            double angleB = cosineRule(side1, side3, side2);
            double angleC = cosineRule(side1, side2, side3);



            if ((angleA + angleB + angleC) > 180)
            {
                Console.WriteLine("Impossible");
            }
            else if (angleA < 90 && angleB < 90 && angleC < 90)
            {
                Console.WriteLine("Acute");
            }
            else if (angleA > 90 || angleB > 90 || angleC > 90)
            {
                Console.WriteLine("Obtuse");
            }
            else if (angleA == 90 || angleB == 90 || angleC == 90)
            {
                Console.WriteLine("Right Angle");
            }

            if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("Isoceles");
            }
            else if (side1 == side2 && side1 == side3)
            {
                Console.WriteLine("Equilateral");
            }
            else if ((side1 * side1 + side2 * side2) == side3 * side3 || (side2 * side2 + side3 * side3) == side1 * side1 || (side1 * side1 + side3 * side3) == side2 * side2)
            {
                Console.WriteLine("Right Angle");
            }
        }

        determineTriangle(3, 4, 5);



    }
}
