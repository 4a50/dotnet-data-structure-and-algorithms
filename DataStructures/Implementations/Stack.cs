using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Stack
    {
        public Node Top { get; set; }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Top;
            Top = newNode;            
        }
        public void Pop()
        {
            Node tempNode = Top.Next;
            Top = tempNode;            
        }
        
        public int Peek()
        {
            return Top.Value;
        }

        public bool isEmpty()
        {
            if (Top != null) return false;
            return true;
        }
    }
}
