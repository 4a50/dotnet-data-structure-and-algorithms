using System;
using Xunit;
using DataStructures;
namespace DataStructuresTest
{
    public class LinkListTests
    {
        [Fact]
        public void Linked_List_Created_With_A_Value_Has_Correct_Head()
        {
            int value = 2;

            LinkedList testList = new LinkedList(value);

            Assert.Equal(testList.Head.Value, value);

        }

        [Fact]
        public void After_Insert_New_Node_Is_Head()
        {
            LinkedList testList = new LinkedList(1);
            // H(2) -> (1)
            testList.Insert(2);

            Assert.Equal(2, testList.Head.Value);
        }

        [Fact]
        public void After_Insert_New_Head_Next_is_Old_Head()
        {
            // H(1)
            LinkedList testList = new LinkedList(1);
            Node oldHead = testList.Head;

            // H(2) -> (1)
            testList.Insert(2);

            Assert.Equal(oldHead, testList.Head.Next);
        }
        //Start My Own
        [Fact]
        public void Find_Value_In_The_Linked_List()
        {
            LinkedList testList = new LinkedList(4);            
            testList.Insert(23);
            Assert.True(testList.Includes(23));            
            
        }
        [Fact]
        public void Does_Not_Find_Value_In_Linked_List()
        {
            LinkedList testList = new LinkedList(4);
            testList.Insert(23);
            testList.Insert(500);
            Assert.False(testList.Includes(66));
        }
        [Fact]
        public void Properly_Insert_Multiple_Nodes()
        {
            LinkedList testList = new LinkedList(4);
            testList.Insert(2);
            testList.Insert(22);
            testList.Insert(81);
            testList.Insert(20);
            Assert.Equal(20, testList.Head.Value);
        }
        [Fact]
        public void Properly_Returns_All_Values_In_List()
        {
            LinkedList testList = new LinkedList(34);
            string testStr = "[490] => [162] => [34] => Null";            
            testList.Insert(162);
            testList.Insert(490);
            Assert.Equal(testStr, testList.Print());
        }
        [Fact]
        public void Create_An_Empty_List()
        {
            LinkedList testList = new LinkedList();
            Assert.Null(testList.Head);
        }
    }
}
