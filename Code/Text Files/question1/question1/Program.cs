// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using System.Text;



class Program
{
    static void Main()
    {

        void ReadSentences(string fileName)
        {
            string sentence = "_";

            if (File.Exists(fileName))
            {
                Console.WriteLine($"File already exists. Appending to {fileName}");
                while (sentence != "")
                {
                    Console.WriteLine("Please enter a sentence:");
                    sentence = Console.ReadLine();
                    File.AppendAllText(fileName, sentence + "\n");
                }
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine($"File doesn't exist. Creating new file called {fileName}");
                File.Create(fileName).Close();
                while (sentence != "")
                {
                    Console.WriteLine("Please enter a sentence:");
                    sentence = Console.ReadLine();
                    File.AppendAllText(fileName, sentence + "\n");
                }
            }
        }

        ReadSentences("sentences.txt");


    }
}

