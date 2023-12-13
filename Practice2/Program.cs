using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Practice2
{
    public void Main(string[] args)
    {
        string[] sentence = { "hi", "bye" };

        LinkedListNode<string> firstNode = sentence.First;
        sentence.AddLast(new LinkedListNode<string>(firstNode.Value));

    }
}