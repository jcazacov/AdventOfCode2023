using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;

namespace day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "Input.txt";

            Console.WriteLine("Hello, World!");

            string[] lines = File.ReadAllLines(inputFile);
            int sumPoints = 0;
            int totalCopies = 0;
            int len = lines.Length;
            int[] counts = new int[len];
            for(int i = 0; i < len; i++)
            {
                counts[i] = 1;
            }

            for (int i = 0; i < len; i++)
            {
                string line = lines[i];

                string proc = line;
                proc = proc.Replace("  ", " ");
                proc = proc.Remove(0, 9);
                string[] groups = proc.Split(" | ");

                string[] sWins = groups[0].Split(" ");
                string[] sHave = groups[1].Split(" ");

                List<int> lWins = new List<int>();
                foreach (string sWin in sWins)
                {
                    if(sWin != "")
                    {
                        lWins.Add(Int32.Parse(sWin));
                    }                }

                int curPoints = 0;
                int matches = 0;
                foreach (string sHav in sHave)
                {
                    if (sHav != "" && lWins.Contains(Int32.Parse(sHav)))
                    {
                        matches++;
                        if(curPoints == 0) { curPoints = 1; }
                        else { curPoints = curPoints * 2; }
                    }
                }
                sumPoints += curPoints;
                int copies = counts[i];
                for (int j = 1; j <= matches; j++)
                {
                    counts[i + j] += copies;
                }
            }
            foreach(int count in counts)
            {
                totalCopies += count;
            }
            Console.WriteLine($"sum of points: {sumPoints}\ntotal copies: {totalCopies}");

        }
        
    }
}
