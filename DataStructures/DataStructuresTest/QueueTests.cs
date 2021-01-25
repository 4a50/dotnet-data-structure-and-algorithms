using DataStructures;
using System;
using Xunit;
namespace DataStructuresTest
{
    public class QueueTests
    {
        /// <summary>
        /// Successfully pushes a node onto a stack
        /// </summary>
        [Fact]
        public void Enqueue_To_A_Queue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("JPJ");
            Assert.Equal("JPJ", queue.Front.Value);
        }
        /// <summary>
        /// Able to enqueue multiple nodes to the Queue.  Last node encueued should equal
        /// Rear value.
        /// </summary>
        [Fact]
        public void Enqueue_Multiple_Nodes_To_Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(564);
            queue.Enqueue(15);
            Assert.Equal(15, queue.Rear.Value);
        }
        /// <summary>
        /// Dequeue a node from the Queue.  Front should change to next item in Queue
        /// </summary>
        [Fact]
        public void Dequeue_Node_From_Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(564);
            queue.Enqueue(15);
            queue.Enqueue(80);
            queue.Enqueue(34);
            queue.Dequeue();
            queue.Dequeue();

            Assert.Equal(15, queue.Front.Value);
        }
        /// <summary>
        /// Able to peek at the correct node that is at the Front of the Queue
        /// </summary>
        [Fact]
        public void Peek_At_Front_Node_In_Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(564);
            queue.Enqueue(15);
            Assert.Equal(10, queue.Peek());
        }
        /// <summary>
        /// Able to empty the queue and isEmpty return a True value and Front should be null
        /// </summary>
        [Fact]
        public void Empty_A_Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(564);
            queue.Enqueue(15);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.True(queue.IsEmpty());
            Assert.Null(queue.Front);
        }
        /// <summary>
        /// Able to create an empty queue, with no nodes
        /// </summary>
        [Fact]
        public void Instantiate_An_Empty_Queue()
        {
            Queue<int> queue = new Queue<int>();
            Assert.Null(queue.Front);
        }
        [Fact]
        public void Peek_On_An_Empty_Queue_Raises_Null_Excpetion()
        {
            Queue<int> queue = new Queue<int>();
            Assert.Throws<NullReferenceException>(() => queue.Peek());
        }
    }
}