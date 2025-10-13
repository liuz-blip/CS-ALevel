// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.IO;
using System.IO.Enumeration;
using System.Dynamic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Runtime.CompilerServices;



class Program
{
    static void Main()
    {
        string fileName = "stations.txt";
        string stations = File.ReadAllText(fileName);
        // Console.WriteLine(stations);
        List<string> allStations = stations.Split("\n").ToList();


        void FindWord(string wordToFind)
        {
            foreach (string station in allStations)
            {
                if (station.Trim().ToLower().Contains(wordToFind))
                {
                    Debug.Assert(station.Trim() == "Battersea Power Station, Northern", "Wrong station");
                    Console.WriteLine(station.Trim());
                }
            }
        }



        void ShareLetters(List<string> words)
        {
            HashSet<char> letterSet = new HashSet<char>();
            foreach (string w in words)
            {
                foreach (char c in w.ToLower())
                {
                    letterSet.Add(c);
                }
            }

            // HashSet<char> defoCorrectLetterSet = new HashSet<char>
            // {
            //     'm', 'a', 'c', 'k', 'e', 'r', 'l',
            //     'p', 'i', 'n', 'h',
            //     's', 't', 'u', 'g', 'o',
            //     'b'
            // };
            // Debug.Assert(letterSet.SetEquals(defoCorrectLetterSet), "Wrong set");


            List<string> stationsWithoutLetters = new List<string>();
            foreach (string station in allStations)
            {
                bool containsLetter = false;
                foreach (char c in letterSet)
                {
                    if (station.ToLower().Contains(c))
                    {
                        containsLetter = true;
                        break;
                    }
                }
                if (!containsLetter)
                {
                    stationsWithoutLetters.Add(station);
                }
            }

            // Console.WriteLine(string.Join(",", letterSet));
            Console.WriteLine("\n" + string.Join("\n", stationsWithoutLetters));
        }



        void FindAlliterationStations()
        {
            List<string> alliterationStations = new List<string>();

            foreach (string station in allStations)
            {
                if (station.Trim() == "") continue;

                List<string> tempStation = station.Trim().Split(",").ToList();
                string stationName = tempStation[0];
                List<string> nameWords = stationName.Split(' ').ToList();

                for (int i = 0; i < nameWords.Count() - 1; i++)
                {
                    if (nameWords[i][0] == nameWords[i + 1][0])
                    {
                        alliterationStations.Add(stationName);
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            Console.WriteLine(string.Join("\n", alliterationStations));
        }



        void MostStationsLine()
        {
            Dictionary<string, int> linesStations = new Dictionary<string, int>();
            HashSet<string> tubeLines = new HashSet<string>();

            foreach (string stringLine in allStations)
            {
                // Console.WriteLine(stringLine);
                List<string> tempTubeLines = stringLine.Trim().Split(",").ToList();
                for (int i = 1; i < tempTubeLines.Count() - 1; i++)
                {
                    tubeLines.Add(tempTubeLines[i].Trim());
                }
            }

            HashSet<string> allLines = new HashSet<string>
            {
            "Piccadilly","Metropolitan", "Hammersmith & City", "Circle",
            "Bakerloo","Central", "Waterloo & City", "Northern", "Jubilee",
            "District", "Victoria", "Docklands Light Railway"
            };
            // Console.WriteLine(string.Join("\n", tubeLines));
            // Console.WriteLine(string.Join("\n", allLines));
            Debug.Assert(tubeLines.SetEquals(allLines), "Lines are not correct");

            foreach (string key in tubeLines)
            {
                linesStations.Add(key, 0);
            }

            foreach (string line in tubeLines)
            {
                int count = 0;
                foreach (string stationData in allStations)
                {
                    if (stationData.Contains(line))
                    {
                        count++;
                    }
                }
                linesStations[line] = count;
            }

            int maxStations = 0;
            string maxLine = "";
            foreach (var item in linesStations)
            {
                if (item.Value > maxStations)
                {
                    maxStations = item.Value;
                    maxLine = item.Key;
                }
            }

            Console.WriteLine($"The {maxLine} line has the most stations of {maxStations}");


        }



        Console.WriteLine("====================================");
        FindWord("station");
        Console.WriteLine("====================================");
        ShareLetters(new List<string> { "a" });
        Console.WriteLine("====================================");
        FindAlliterationStations();
        Console.WriteLine("====================================");
        MostStationsLine();
        Console.WriteLine("====================================");




    }
}



