namespace _3.Stacks_and_Queues.CallCenter
{
    public class CallCenter
    {
        private int _counter = 0;
        public Queue<IncomingCall> Calls { get; private set; }

        public CallCenter()
        {
            Calls = new Queue<IncomingCall>();
        }

        public void Call(int clientId)
        {
            IncomingCall call = new IncomingCall()
            {
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.UtcNow,
            };

            Calls.Enqueue(call);
        }

        public IncomingCall? Answer(string consultant)
        {
            if (Calls.Count > 0)
            {
                IncomingCall call = Calls.Dequeue();
                call.Consultant = consultant;
                call.StartTime = DateTime.UtcNow;
                return call;
            }

            return null;
        }

        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.UtcNow;
        }

        public bool AreWaitingCalls()
        {
            return Calls.Count > 0;
        }
    }
}
