namespace day03
{
    public class Label
    {
        protected int row;
        protected int col;

        public Label(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public int getRow() { return row; }
        public int getCol() { return col; }
    }

    public class Symbol : Label
    {
        char sym;
        public Symbol(int row, int col, char sym) : base(row, col)
        {
            this.sym = sym;
        }

        public char getSym() { return sym;}
    }

    public class Number : Label
    {
        int len;
        int val;

        public Number(int row, int col, int len, int val) :base(row, col)
        {
            this.len = len;
            this.val = val;
        }

        public bool isNeighbour(Label other)
        {
            if(other.getRow() >= row - 1 && other.getRow() <= row + 1)
            {
                if (other.getCol() >= col - 1 && other.getCol() <= col + len)
                {
                    return true;
                }
            }
            return false;
        }

        public int getValue() { return val; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "Input.txt";

            Console.WriteLine("Hello, World!");

            string[] lines = File.ReadAllLines(inputFile);
            int sum1 = 0;

            List<Number> numbers = new List<Number>();
            List<Symbol> symbols = new List<Symbol>();

            for(int curRow = 0; curRow < lines.Length; curRow++)
            {
                int curLen = 0;
                for(int curCol = 0; curCol < lines[curRow].Length; curCol++)
                {
                    if (lines[curRow][curCol] == '.')
                    {
                        if(curLen != 0)
                        {
                            int curNum = Int32.Parse(lines[curRow].Substring(curCol - curLen, curLen));
                            numbers.Add(new Number(curRow, curCol - curLen, curLen, curNum));
                            curLen = 0;
                        }
                        continue;
                    }
                    else if (Char.IsDigit(lines[curRow][curCol])){
                        curLen++;
                    }
                    else
                    {
                        if (curLen != 0)
                        {
                            int curNum = Int32.Parse(lines[curRow].Substring(curCol - curLen, curLen));
                            numbers.Add(new Number(curRow, curCol - curLen, curLen, curNum));
                            curLen = 0;
                        }
                        symbols.Add(new Symbol(curRow, curCol, lines[curRow][curCol]));
                        
                    }
                }
                if (curLen != 0)
                {
                    int curNum = Int32.Parse(lines[curRow].Substring(lines[curRow].Length - curLen, curLen));
                    numbers.Add(new Number(curRow, lines[curRow].Length - curLen, curLen, curNum));
                }
            }
            foreach(Number number in numbers)
            {
                foreach(Symbol symbol in symbols)
                {
                    if (number.isNeighbour(symbol))
                    {
                        sum1 += number.getValue();
                        break;
                    }
                }
            }

            int sum2 = 0;

            foreach (Symbol symbol in symbols)
            {
                if(symbol.getSym() != '*')
                {
                    continue;
                }
                int neighbours = 0;
                int ratio = 1;
                foreach (Number number in numbers)
                {
                    if (number.isNeighbour(symbol))
                    {
                        if(neighbours < 2)
                        {
                            neighbours++;
                            ratio *= number.getValue();
                        }
                        else
                        {
                            neighbours++;
                            break;
                        }
                    }
                }
                if(neighbours == 2)
                {
                    sum2 += ratio;
                }
            }

            Console.WriteLine($"task 1: {sum1}");
            Console.WriteLine($"task 2: {sum2}");
        }
    }
}
