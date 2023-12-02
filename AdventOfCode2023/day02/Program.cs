namespace day02
{

    internal class Program
    { 
        static void Main(string[] args)
        {

            //task 1
            Dictionary<string, int> colours = new Dictionary<string, int>() {
             {"red", 12 }, {"green", 13}, {"blue", 14}
             };

            string[] lines = File.ReadAllLines("Input.txt");
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
            Console.WriteLine(sum);
        }
    }
}
