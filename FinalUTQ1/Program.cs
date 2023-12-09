using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackTime
{
    // MyStack class: contains 3 methods- Push, Pop, and Peek
    class MyStack
    {
        // make the stack list with new List
        private List<int> greatStackList = new List<int>();

        // Push method: contains int parameter, add that param to the list with .Add()
        public void Push(int n)
        {
            greatStackList.Add(n);
        }

        // Pop method: store the top value in a variable, remove that value
        public int Pop()
        {
            int topValue = greatStackList[greatStackList.Count - 1];
            greatStackList.RemoveAt(greatStackList.Count - 1);
            return topValue;
        }

        // Peek method: return top item from stack
        public int Peek()
        {
            return greatStackList[greatStackList.Count - 1];
        }
    }

    class Program
    {
        // Main: testing to see how the stack works, using every method in MyStack
        static void Main(string[] args)
        {

            // TESTING

            MyStack myStack = new MyStack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);

            Console.WriteLine("Top value: " + myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());

            myStack.Push(157);
            Console.WriteLine("New top value: " + myStack.Peek());
        }
    }
}

