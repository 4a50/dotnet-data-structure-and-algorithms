using System;

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
        public bool Includes(int value)
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
        /// <summary>
        /// Will locate the value of the 
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public int LocateNodeFromTail(int k)
        {
            Node currentNode = Head;
            // Set the lengthList to one, to take into account the initial setting
            // of the Head as the currentNode
            int lengthList = 1;            
            int counter = 0;
            int placeOfNode;
            int selectedNodeValue = 0;
            if (k < 0) { return -1; }
            while (currentNode.Next != null)
            {
                lengthList++;
                currentNode = currentNode.Next;
            }
            if (k > lengthList) { return -2; }
            placeOfNode = lengthList - k;
            if (placeOfNode <= 1) { Console.WriteLine(placeOfNode); return -3; }
            currentNode = Head;
            //TODO: Fix the counter that is equal to the length of the list.
            while (counter <= placeOfNode)
            {
                counter++;
                selectedNodeValue = currentNode.Value;
                currentNode = currentNode.Next;
            }
            return selectedNodeValue;

        }
    }
}
