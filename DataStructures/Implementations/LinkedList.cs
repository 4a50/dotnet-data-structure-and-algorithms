using System;

namespace DataStructures
{
    public class LinkedList
    {

        public Node<int> Head { get; set; }
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
            Node<int> node = new Node<int>(value);
            Head = node;
        }
        //Methods

        //1st Method - While
        public string Print()
        {
            string output = "";
            Node<int> current = Head;
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
        public string PrintR(Node<int> node)
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
            Node<int> node = new Node<int>(value);
            node.Next = Head;
            Head = node;
        }
        public bool Includes(int value)
        {
            Node<int> currentNode = Head;
            while (currentNode.Next != null)
            {
                if (currentNode.Value == value) { return true; }
                currentNode = currentNode.Next;
            }
            return false;
        }
        public int Append(int value)
        {
            Node<int> currentNode;
            //If Head is null, will make this appended node the head.
            //Else use stored Head value to find end of LinkedList.
            if (Head == null)
            {
                currentNode = new Node<int>(value);
                Head = currentNode;
                return currentNode.Value;
            }
            else { currentNode = Head; }
            while (currentNode != null)
            {
                if (currentNode.Next == null)
                {
                    Node<int> newNode = new Node<int>(value);
                    currentNode.Next = newNode;
                    return newNode.Value;
                }
                currentNode = currentNode.Next;
            }

            return currentNode.Value;

        }

        public int InsertAfter(int value, int newValue)
        {
            Node<int> currentNode = Head;
            while (currentNode.Next != null)
            {
                if (currentNode.Value == value)
                {
                    Node<int> newNode = new Node<int>(newValue);
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
            Node<int> oldNode = null;
            Node<int> currentNode = Head;
            while (currentNode.Next != null)
            {
                if (currentNode.Value == value)
                {
                    Console.WriteLine($"Found {currentNode.Value}");
                    Node<int> newNode = new Node<int>(newValue);
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
        public int LocateKthNodeFromTail(int k)
        {
            Node<int> currentNode = Head;
            // Set the lengthList to one, to take into account the initial setting
            // of the Head as the currentNode
            int lengthList = 1;
            int counter = 0;
            int placeOfNode;
            int selectedNodeValue = 0;
            //If user enters a value that is less than 0
            if (k < 0) { return -1; }
            //While loop gets the length of the list and stores into lengthList
            while (currentNode.Next != null)
            {
                lengthList++;
                currentNode = currentNode.Next;
            }
            placeOfNode = lengthList - k;
            // if the position of the desire node is outside the length of the list.
            if (placeOfNode < 0) { return -2; }
            // if the place of Node at the zero position, return the HeadValue.
            currentNode = Head;
            if (placeOfNode == 0) { return currentNode.Value; }
            //while loop will iterate to the desired place of the node.
            do
            {
                counter++;
                selectedNodeValue = currentNode.Value;
                //Console.WriteLine($"==> {selectedNodeValue} {counter} {placeOfNode}");
                if (counter == placeOfNode) return selectedNodeValue;
                currentNode = currentNode.Next;
            } while (currentNode != null);
            return selectedNodeValue;

        }
    }
}
