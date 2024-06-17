using System;

namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new CallQueue();

            // Enqueue some callers
            queue.Enqueue("Alice");
            queue.Enqueue("Bob");
            queue.Enqueue("Charlie");

            // Dequeue and print callers
            Console.WriteLine("Dequeued callers:");
            while (true)
            {
                var caller = queue.Dequeue();
                if (caller == "Queue is empty.")
                    break;
                Console.WriteLine(caller);
            }
        }
    }

    // Define a custom class for the queue node
    class CallNode
    {
        public string CallerName { get; set; }
        public CallNode Next { get; set; }

        public CallNode(string name)
        {
            CallerName = name;
            Next = null;
        }
    }

    // Custom queue using linked list
    class CallQueue
    {
        private CallNode front;
        private CallNode rear;

        public CallQueue()
        {
            front = null;
            rear = null;
        }

        // Enqueue a caller
        public void Enqueue(string callerName)
        {
            var newNode = new CallNode(callerName);
            if (rear == null)
            {
                // Queue is empty, set both front and rear to the new node
                front = rear = newNode;
            }
            else
            {
                // Add the new node after the rear and update rear
                rear.Next = newNode;
                rear = newNode;
            }
        }

        // Dequeue a caller
        public string Dequeue()
        {
            if (front == null)
            {
                // Queue is empty
                return "Queue is empty.";
            }

            var dequeuedName = front.CallerName;
            front = front.Next;

            if (front == null)
            {
                // Queue became empty after dequeue
                rear = null;
            }

            return dequeuedName;
        }
    }
}
