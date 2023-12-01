namespace day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");

            int sum = 0;

            foreach( string line in lines )
            {
                char first = ' ';
                char last = ' ';
                foreach(char c in line)
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
            Console.WriteLine(sum);
        }
    }
}
