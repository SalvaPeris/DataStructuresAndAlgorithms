namespace _3.Stacks_and_Queues.HanoiTower
{
    public class HanoiTower
    {
        public int DiscsCount { get; private set; }
        public int MovesCount { get; private set; }
        public Stack<int>? From { get; private set; }
        public Stack<int>? To { get; private set; }
        public Stack<int>? Auxiliary { get; private set; }

        public event EventHandler<EventArgs>? MoveCompleted;

        public HanoiTower(int discs)
        {
            DiscsCount = discs;
            From = new Stack<int>();
            To = new Stack<int>();
            Auxiliary = new Stack<int>();

            for(int i = 1; i <= discs; i++) 
            {
                int size = discs - 1 + 1;
                From.Push(size);
            }
        }
    }
}
