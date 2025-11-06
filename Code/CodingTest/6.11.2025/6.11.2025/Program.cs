using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Numerics;

// ==============================
// Task 1
// ==============================

/* Fix me */
List<string> listOfStrings = new List<string> { "13", "Candy", "Mike Myers", "True", "#FF5F1F", "1978" };





// ==============================
// Task 2
// ==============================

Debug.Assert(NextOnAThursday() == 2031);
int NextOnAThursday()
{
    bool found = false;
    int year = 2025;

    while (!found)
    {
        year++;
        int currentDay = (int)new DateTime(year, 11, 6).DayOfWeek;
        if (currentDay == 4)
        {
            found = true;
        }
    }
    return year;
}





// ==============================
// Task 3
// ==============================

int CuttingChocolate(int cuts)
{
    int hCuts = 0;  // number of horizontal cuts
    int vCuts = 0;  // number of vertical cuts

    for (int i = 0; i < cuts; i++)  // gives hCuts and vCuts +1 alternatingly
    {
        if (i % 2 == 0)
        {
            hCuts++;
        }
        else
        {
            vCuts++;
        }
    }
    int pieces = hCuts * vCuts;

    return pieces;
}
Debug.Assert(CuttingChocolate(5) == 6);
Debug.Assert(CuttingChocolate(6) == 9);
Debug.Assert(CuttingChocolate(7) == 12);
Debug.Assert(CuttingChocolate(8) == 16);





// ==============================
// Task 4
// ==============================

List<int> pileSizes = new List<int> { 4, 9, 11, 17 };
int numHours = 8;

int EatingSweets(List<int> pileSizes, int numHours)
{
    int totalSweets = 0;
    foreach (int pile in pileSizes)
    {
        totalSweets += pile;
    }
    Debug.Assert(totalSweets == 41, "Wrong total sweets");

    int sph = 1;
    while (true)
    {
        int hoursPassed = 0;
        foreach (int pile in pileSizes)
        {
            if (pile % sph != 0)
            {
                hoursPassed += pile / sph + 1;
            }
            else
            {
                hoursPassed += pile / sph;
            }
        }

        if (hoursPassed > numHours)
        {
            sph++;
        }
        else
        {
            return sph;
        }
    }
}
Debug.Assert(EatingSweets(pileSizes, numHours) == 6);





// ==============================
// Task 4
// ==============================

bool ValidatePassword(string candidate)
{
    bool nextTest = false;
    // Test 1
    if (candidate.Length >= 8 && candidate.Length <= 32)
    {
        nextTest = true;
    }
    else
    {
        nextTest = false;
        return nextTest;
    }

    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    // Test 2
    foreach (char letter in alphabet)
    {
        if (candidate.Contains(letter.ToString().ToLower()) && candidate.Contains(letter.ToString().ToUpper()))
        {
            nextTest = true;
            continue;
        }
        nextTest = false;
        return nextTest;
    }
}


// Note the exclamation marks showing not, so False 
Debug.Assert(!ValidatePassword("ABCdef")); // too short
Debug.Assert(!ValidatePassword("ABCABC12!")); // duplicates, doesn't divide by 11
Debug.Assert(!ValidatePassword("ABCabcde!")); // no digit 
Debug.Assert(!ValidatePassword("ABCdef12!")); // doesn't divide by 11 
Debug.Assert(ValidatePassword("ABCdef12&")); // should succeed 

