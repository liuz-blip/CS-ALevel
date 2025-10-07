// See https://aka.ms/new-console-template for more information
using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Text;


class Program
{
    static void Main()
    {



        List<int> ConvCharCode(string convStr)
        {
            List<int> codes = new List<int>();
            foreach (char c in convStr)
            {
                codes.Add((int)c);
            }
            return codes;
        }

        List<int> helloCodes = ConvCharCode("hello");
        Debug.Assert(string.Join(" ", helloCodes) == "104 101 108 108 111", "wrong codes");
        Console.WriteLine("hello codes: " + string.Join(" ", helloCodes));

        List<int> nihaoCodes = ConvCharCode("nihao");
        Debug.Assert(string.Join(" ", nihaoCodes) == "110 105 104 97 111", "wrong codes");
        Console.WriteLine("nihao codes: " + string.Join(" ", nihaoCodes));

        List<int> cnihaoCodes = ConvCharCode("你好");
        Debug.Assert(string.Join(" ", cnihaoCodes) == "20320 22909", "wrong codes");
        Console.WriteLine("你好 codes: " + string.Join(" ", cnihaoCodes));





        List<string> ConvCodeString(List<int> convCode)
        {
            List<string> chars = new List<string>();
            foreach (int code in convCode)
            {
                chars.Add(((char)code).ToString());
            }
            return chars;
        }

        List<string> hello = ConvCodeString(helloCodes);
        Debug.Assert(string.Join("", hello) == "hello", "wrong codes");
        Console.WriteLine(string.Join("", hello));

        List<string> nihao = ConvCodeString(nihaoCodes);
        Debug.Assert(string.Join("", nihao) == "nihao", "wrong codes");
        Console.WriteLine(string.Join("", nihao));

        List<string> cnihao = ConvCodeString(cnihaoCodes);
        Debug.Assert(string.Join("", cnihao) == "你好", "wrong codes");
        Console.WriteLine(string.Join("", cnihao));

        List<string> gcode = ConvCodeString([206, 188, 206, 174, 206, 187, 206, 191]);
        Console.WriteLine(string.Join(" ", gcode));


    }
}


