using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queueTime
{
    // MyQueue class: contains 3 methods- Enqueue, Dequeue, and Peek
    class MyQueue
    {
        // make the stack list with new List
        private List<int> greatQueueList = new List<int>();

        // Enqueue method: contains int parameter, adds item to end of Queue with .Add()
        public void Enqueue(int n)
        {
            greatQueueList.Add(n);
        }

        // Dequeue method: remove FRONT item from queue (LIFO), return
        public int Dequeue()
        {
            int frontItem = greatQueueList[0];
            greatQueueList.RemoveAt(0);
            return frontItem;
        }

        // Peek method: return FRONT item from queue
        public int Peek()
        {
           return greatQueueList[0];
        }
    }

    class Program
    {
        // Main: testing to see how the queue works, using every method in MyQueue
        static void Main(string[] args)
        {

            // TESTING

            MyQueue myStack = new MyQueue();

            myStack.Enqueue(30);
            myStack.Enqueue(20);
            myStack.Enqueue(10);

            // should be 30, get front with Peek method
            Console.WriteLine("Front item of queue: " +  myStack.Peek());

            myStack.Dequeue();

            // new front: 20, since 30 is dequeued
            Console.WriteLine("New front item: " + myStack.Peek());
         
        }
    }
}


