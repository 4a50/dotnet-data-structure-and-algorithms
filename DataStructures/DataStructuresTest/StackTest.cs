using DataStructures;
using System;
using Xunit;
namespace DataStructuresTest
{
    public class StackTest
    {
        /// <summary>
        /// Successfully pushes a node onto a stack
        /// </summary>
        [Fact]
        public void Push_Node_Onto_A_Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);            
            Assert.Equal(5, stack.Peek());
        }
        /// <summary>
        /// Successfully pushes multiple Nodes onto the Stack.
        /// </summary>
        [Fact]
        public void Push_Multiple_Nodes_From_A_Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            Assert.Equal(7, stack.Top.Value);
        }
        /// <summary>
        /// Successfully removes a Node from the Top of the Stack
        /// </summary>
        [Fact]
        public void Remove_Node_From_Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Pop();
            Assert.Equal(5, stack.Top.Value);

        }
        /// <summary>
        /// Remove all nodes from a stack
        /// </summary>
        [Fact]
        public void Pop_All_Nodes_From_A_Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Assert.True(stack.IsEmpty());
        }
        /// <summary>
        /// Return expected value for node on top of stack
        /// </summary>
        [Fact]
        public void Peek_At_Node_On_Top_Of_Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            Assert.Equal(7, stack.Peek());
        }
        /// <summary>
        /// Create an empty stack that does not contain any nodes.
        /// </summary>
        [Fact]
        public void Instantiate_An_Empty_Stack()
        {
            Stack<int> stack = new Stack<int>();            
            Assert.True(stack.IsEmpty());
        }
        [Fact]
        public void Using_Pop_On_An_Empty_Stack_Raises_Null_Excpetion()
        {
            Stack<int> stack = new Stack<int>();            
            Assert.Throws<NullReferenceException>(()=>stack.Pop());

        }
    }
}
