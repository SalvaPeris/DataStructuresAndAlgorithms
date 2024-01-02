namespace _3.Stacks_and_Queues.HanoiTower
{
    public class HanoiTower
    {
        public int DiscsCount { get; private set; }
        public int MovesCount { get; private set; }
        public Stack<int>? From { get; private set; }
        public Stack<int>? To { get; private set; }
        public Stack<int?>? Auxiliary { get; private set; }

        public event EventHandler<EventArgs>? MoveCompleted;
    }
}
