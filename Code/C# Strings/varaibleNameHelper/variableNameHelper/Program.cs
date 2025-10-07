// See https://aka.ms/new-console-template for more information
using System;


class Program
{
    static void Main()
    {

        string camelCase(List<string> toConvStr)
        {
            string convedStr = "";
            convedStr += toConvStr[0].ToLower();

            for (int i = 1; i < toConvStr.Count(); i++)
            {
                string word = toConvStr[i].ToLower();
                string newWord = "";
                newWord += char.ToUpper(word[0]);
                newWord += word.Substring(1, word.Length - 1);
                convedStr += newWord;
            }
            return convedStr;
        }


        string PascalCase(List<string> toConvStr)
        {
            string convedStr = "";

            foreach (string unprocessedWord in toConvStr)
            {
                string newWord = "";
                string word = unprocessedWord.ToLower();
                newWord += char.ToUpper(word[0]);
                newWord += word.Substring(1, word.Length - 1);
                convedStr += newWord;
            }
            return convedStr;
        }


        string snake_case(List<string> toConvStr)
        {
            string convedStr = "";

            for (int i = 0; i < toConvStr.Count - 1; i++)
            {
                string word = toConvStr[i];
                convedStr += word.ToLower() + "_";
            }
            convedStr += toConvStr[toConvStr.Count() - 1].ToLower();

            return convedStr;
        }


        string VariableNameHelper(string toConvertStr, int choice)
        {
            // Choices are:
            //     1. camelCase
            //     2. PascalCase
            //     3. snake_case

            string convertedStr = "";
            List<string> toConvert = new List<string>(toConvertStr.Split(" "));

            switch (choice)
            {
                case 1:
                    convertedStr = camelCase(toConvert);
                    break;
                case 2:
                    convertedStr = PascalCase(toConvert);
                    break;
                case 3:
                    convertedStr = snake_case(toConvert);
                    break;

            }

            return convertedStr;
        }

        Console.WriteLine(VariableNameHelper("nEw fuNcTiOn", 2));


    }
}