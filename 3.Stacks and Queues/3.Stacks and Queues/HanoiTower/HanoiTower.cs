namespace _3.Stacks_and_Queues.HanoiTower
{
    public class HanoiTower
    {
        public int ColumnSize { get; set; }
        public int DiscsCount { get; private set; }
        public int MovesCount { get; private set; }
        public Stack<int>? From { get; private set; }
        public Stack<int>? To { get; private set; }
        public Stack<int>? Auxiliary { get; private set; }

        public event EventHandler<EventArgs> MoveCompleted;

        public HanoiTower(int discs)
        {
            DiscsCount = discs;
            ColumnSize = Math.Max(6, GetDiscsWidth(DiscsCount) + 2);

            From = new Stack<int>();
            To = new Stack<int>();
            Auxiliary = new Stack<int>();



            for (int i = 1; i <= discs; i++) 
            {
                int size = discs - i + 1;
                From.Push(size);
            }
        }

        public void Start()
        {
            Move(DiscsCount, From, To, Auxiliary);
        }

        public void Move(int discs, Stack<int> from, Stack<int> to, Stack<int> auxiliary)
        {
            if (discs > 0)
            {
                Move(discs - 1, from, auxiliary, to);

                to.Push(from.Pop());
                MovesCount++;
                MoveCompleted?.Invoke(this, EventArgs.Empty);

                Move(discs - 1, auxiliary, to, from);
            }
        }

        public void AlgorithmVisualize(object sender, EventArgs e)
        {
            Console.Clear();

            HanoiTower algorithm = (HanoiTower)sender;
            if(algorithm.DiscsCount <= 0)
                return;
            char[][] visualization = InitializeVisualization(algorithm);
            PrepareColumn(visualization, 1, algorithm.DiscsCount, algorithm.From);
            PrepareColumn(visualization, 2, algorithm.DiscsCount, algorithm.To);
            PrepareColumn(visualization, 3, algorithm.DiscsCount, algorithm.Auxiliary);

            Console.WriteLine(Center("FROM") + Center("TO") + Center("AUXILIARY"));

            DrawVisualization(visualization);

            Console.WriteLine();
            Console.WriteLine($"Number of moves: {algorithm.MovesCount}");
            Console.WriteLine($"Number of discs: {algorithm.DiscsCount}");

            Thread.Sleep(1000);
        }

        private char[][] InitializeVisualization(HanoiTower algorithm)
        {
            char[][] visualization = new char[algorithm.DiscsCount][];

            for (int y = 0; y < visualization.Length; y++)
            {
                visualization[y] = new char[ColumnSize * 3];
                for (int x = 0; x < ColumnSize * 3; x++)
                    visualization[y][x] = ' ';
            }

            return visualization;
        }

        private void PrepareColumn(char[][] visualization, int column, int discsCount, Stack<int> stack)
        {
            int margin = ColumnSize * (column - 1);
            for (int y = 0; y < stack.Count; y++)
            {
                int size = stack.ElementAt(y);
                int row = discsCount - (stack.Count - y);
                int columnStart = margin + discsCount - size;
                int columnEnd = columnStart + GetDiscsWidth(size);
                for (int x = columnStart; x <= columnEnd; x++)
                    visualization[row][x] = '=';
            }
        }

        private static void DrawVisualization(char[][] visualization)
        {
            for (int y = 0; y < visualization.Length; y++)
            {
                Console.WriteLine(visualization[y]);
            }
        }

        private string Center(string text)
        {
            int margin = (ColumnSize - text.Length) / 2;
            return text.PadLeft(margin + text.Length).PadRight(ColumnSize);
        }

        private int GetDiscsWidth(int size) => 2 * size - 1;
    }
}
