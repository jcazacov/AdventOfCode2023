using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace day01
{
    

    public class Searcher
    {
        static Dictionary<int, string> digits = new Dictionary<int, string>()
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" }
        };

         int firstPos = int.MaxValue;
         string firstDigit = " ";
         int lastPos = int.MinValue;
         string lastDigit = " ";
         public void searchFirst(int i, string line)
        {
            if(i < 1 || i > 9)
            {
                throw new Exception("searching for invalid digit");
            }
            else
            {
                int index = line.IndexOf(i.ToString());
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = i.ToString();
                }
                index = line.IndexOf(digits[i]);
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = i.ToString();
                }
            }
        }

         public void searchLast(int i, string line)
        {
            if (i < 1 || i > 9)
            {
                throw new Exception("searching for invalid digit");
            }
            else
            {
                int index = line.LastIndexOf(i.ToString());
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = i.ToString();
                }
                index = line.LastIndexOf(digits[i]);
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = i.ToString();
                }
            }
        }

        public int getValue()
        {
            return (Int32.Parse(firstDigit + lastDigit));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //task1

            string[] lines = File.ReadAllLines("Input.txt");

            int sum = 0;

            foreach (string line in lines)
            {
                char first = ' ';
                char last = ' ';
                foreach (char c in line)
                {
                    if (char.IsDigit(c))
                    {
                        if (first == ' ')
                        {
                            first = c;
                        }
                        last = c;
                    }

                }
                string number = $"{first}{last}";
                sum += Int32.Parse(number);
            }
            Console.WriteLine($"task 1 : {sum}");

            //task2 version 1

            lines = File.ReadAllLines("Input.txt");

            sum = 0;


            foreach (string line in lines)
            {
                int firstPos = int.MaxValue;
                char firstDigit = ' ';
                int lastPos = int.MinValue;
                char lastDigit = ' ';


                //firstDigit
                int index = 0;

                //1
                index = line.IndexOf("1");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '1';
                }
                index = line.IndexOf("one");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '1';
                }

                //2
                index = line.IndexOf("2");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '2';
                }
                index = line.IndexOf("two");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '2';
                }

                //three
                index = line.IndexOf("3");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '3';
                }
                index = line.IndexOf("three");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '3';
                }

                //4
                index = line.IndexOf("4");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '4';
                }
                index = line.IndexOf("four");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '4';
                }

                //5
                index = line.IndexOf("5");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '5';
                }
                index = line.IndexOf("five");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '5';
                }

                //6
                index = line.IndexOf("6");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '6';
                }
                index = line.IndexOf("six");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '6';
                }

                //7
                index = line.IndexOf("7");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '7';
                }
                index = line.IndexOf("seven");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '7';
                }

                //8
                index = line.IndexOf("8");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '8';
                }
                index = line.IndexOf("eight");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '8';
                }

                //9
                index = line.IndexOf("9");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '9';
                }
                index = line.IndexOf("nine");
                if (index != -1 && index < firstPos)
                {
                    firstPos = index;
                    firstDigit = '9';
                }


                //lastDigit
                index = 0;

                //1
                index = line.LastIndexOf("1");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '1';
                }
                index = line.LastIndexOf("one");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '1';
                }

                //2
                index = line.LastIndexOf("2");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '2';
                }
                index = line.LastIndexOf("two");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '2';
                }

                //3
                index = line.LastIndexOf("3");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '3';
                }
                index = line.LastIndexOf("three");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '3';
                }

                //4
                index = line.LastIndexOf("4");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '4';
                }
                index = line.LastIndexOf("four");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '4';
                }

                //5
                index = line.LastIndexOf("5");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '5';
                }
                index = line.LastIndexOf("five");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '5';
                }

                //6
                index = line.LastIndexOf("6");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '6';
                }
                index = line.LastIndexOf("six");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '6';
                }

                //7
                index = line.LastIndexOf("7");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '7';
                }
                index = line.LastIndexOf("seven");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '7';
                }

                //8
                index = line.LastIndexOf("8");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '8';
                }
                index = line.LastIndexOf("eight");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '8';
                }

                //9
                index = line.LastIndexOf("9");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '9';
                }
                index = line.LastIndexOf("nine");
                if (index != -1 && index > lastPos)
                {
                    lastPos = index;
                    lastDigit = '9';
                }


                string number = $"{firstDigit}{lastDigit}";
                sum += Int32.Parse(number);
            }
            Console.WriteLine($"task 2 version 1: {sum}");


            //task 2 version 2

            lines = File.ReadAllLines("Input.txt");

            sum = 0;

            foreach (string line in lines)
            {
                var s1 = new Searcher();
                for (int i = 1; i < 10; i++)
                {
                    s1.searchFirst(i, line);
                    s1.searchLast(i, line);
                }
                sum += s1.getValue();
            }
            Console.WriteLine($"task 2 version 2: {sum}");
        }
    }
}
