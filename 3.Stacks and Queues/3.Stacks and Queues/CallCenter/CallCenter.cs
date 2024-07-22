using Priority_Queue;
using System.Collections.Concurrent;

namespace _3.Stacks_and_Queues.CallCenter
{
    public class CallCenter
    {
        private int _counter = 0;
        public SimplePriorityQueue<IncomingCall> Calls { get; private set; }
        //public ConcurrentQueue<IncomingCall> Calls { get; private set; }
        //public Queue<IncomingCall> Calls { get; private set; }

        public CallCenter()
        {
            Calls = new SimplePriorityQueue<IncomingCall>();
            //Calls = new ConcurrentQueue<IncomingCall>();
            //Calls = new Queue<IncomingCall>();
        }

        public int Call(int clientId, bool isPriority = false)
        {
            IncomingCall call = new IncomingCall()
            {
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.UtcNow,
                IsPriority = isPriority
            };

            Calls.Enqueue(call, isPriority ? 0 : 1);
            return Calls.Count;
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
