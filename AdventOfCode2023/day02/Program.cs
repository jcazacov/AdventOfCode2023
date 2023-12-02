namespace day02
{

    internal class Program
    { 
        static void Main(string[] args)
        {
            string inputFile = "Input.txt";

            //task 1
            Dictionary<string, int> colours = new Dictionary<string, int>() {
             {"red", 12 }, {"green", 13}, {"blue", 14}
             };

            string[] lines = File.ReadAllLines(inputFile);
            int sum = 0;

            foreach (string line in lines)
            {
                bool valid = true;
                string[] parts = line.Split(':');
                string[] header = parts[0].Split(" ");
                int id = int.Parse(header[1]);
                string[] sets = parts[1].Split(';');
                foreach (string set in sets)
                {
                    string[] pairs = set.Split(',');
                    foreach (string pair in pairs)
                    {
                        string[] values = pair.Split(" ");
                        if (colours[values[2]] < Int32.Parse(values[1]))
                        {
                            valid = false;
                        }
                    }
                }
                if (valid)
                {
                    sum += id;
                }
            }
            Console.WriteLine($" task 1: {sum}");

            //task2
            

            lines = File.ReadAllLines(inputFile);
            sum = 0;

            foreach (string line in lines)
            {
                Dictionary<string, int> maxCubes = new Dictionary<string, int>() {
                {"red", 0 }, {"green", 0}, {"blue", 0}
                };
                string[] parts = line.Split(':');
                string[] header = parts[0].Split(" ");
                int id = int.Parse(header[1]);
                string[] sets = parts[1].Split(';');
                foreach (string set in sets)
                {
                    string[] pairs = set.Split(',');
                    foreach (string pair in pairs)
                    {
                        string[] values = pair.Split(" ");
                        if (maxCubes[values[2]] < Int32.Parse(values[1]))
                        {
                            maxCubes[values[2]] = Int32.Parse(values[1]);
                        }
                    }
                }
                sum += maxCubes["red"] * maxCubes["green"] * maxCubes["blue"];
            }
            Console.WriteLine($" task 2: {sum}");
        }
    }
}
