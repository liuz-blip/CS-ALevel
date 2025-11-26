// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {
        string[] random1 = { "apple", "banana", "cucumber", "dominos pizza", "egg", "fried chicken" };
        string[] random2 = { "apple", "banana", "cucumber", "dominos pizza", "egg", "fried chicken" };
        string[] random3 = { "bad tech company", "monkey food", "green stick", "rip-off italian food", "chicken spawn", "kfc" };

        bool SameList(string[] list1, string[] list2)
        {
            bool same = false;
            if (list1.Length == list2.Length)
            {
                for (int i = 0; i < list1.Length; i++)
                {
                    if (list1[i] != list2[i])
                    {
                        same = false;
                        break;
                    }
                    same = true;
                }
            }
            return same;
        }

        Console.WriteLine(SameList(random1,random2));
        Console.WriteLine(SameList(random1,random3));

    }
}



