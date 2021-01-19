using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        public Node Head { get; set; }
        ///<summary>
        ///Empty Linked List
        ///Usage: LinkedList my List = new LinkedList();
        /// </summary>
        public LinkedList() { }

        ///<summary>
        ///Creates a linked list with a node, assigning a Head
        ///Usage: LinkedList myList = new LinkedList(4);
        /// </summary>
        /// <param name="value"></param>
        public LinkedList(int value)
        {
            Node node = new Node(value);
            Head = node;
        }
        //Methods

        //1st Method - While
        public string Print()
        {
            string output = "";
            Node current = Head;
            while (current != null)
            {
                Console.Write($"[{current.Value}] => ");
                output += $"[{current.Value}] => ";
                current = current.Next;
            }
            Console.WriteLine("Null");
            output += "Null";
            return output;
        }

        //2nd Method - Recursive
        public string PrintR(Node node)
        {
            string output = "";
            if (node == null)
            {
                Console.WriteLine("Null");
                output += "Null";
                return output;
            }
            Console.Write($"[{node.Value}] => ");
            output += $"[{node.Value}] => ";
            PrintR(node.Next);
            return output;
        }

        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }
        public bool Includes (int value)
        {
            Node currentNode = Head;
            while (currentNode.Next != null)
            {
                if (currentNode.Value == value) { return true; }
                currentNode = currentNode.Next;
            }
            return false;
        }
        public int Append(int value)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Next == null)
                {
                    Node newNode = new Node(value);
                    currentNode.Next = newNode;
                    return newNode.Value;
                }
                currentNode = currentNode.Next;
            }
            return currentNode.Value;
        
        }

        public int InsertAfter(int value, int newValue)
        {
            Node currentNode = Head;
            while (currentNode.Next != null)
            {
                if (currentNode.Value == value)
                {
                    Node newNode = new Node(newValue);
                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                    return newNode.Next.Value;
                }
                currentNode = currentNode.Next;
            }
            return -1;
        }
        public int InsertBefore(int value, int newValue)
        {
            Node oldNode = null;
            Node currentNode = Head;
            while (currentNode.Next != null)
            {
                if (currentNode.Value == value)
                {
                    Console.WriteLine($"Found {currentNode.Value}");
                    Node newNode = new Node(newValue);
                    oldNode.Next = newNode;
                    newNode.Next = currentNode;
                    return newNode.Next.Value;
                }
                oldNode = currentNode;
                currentNode = currentNode.Next;
            }
            return -1;
        }
    }
}
