using DataStructures;
using Xunit;

namespace CodeChallengeTests
{
    public class CodeChallengeUnitTest
    {
        /// <summary>
        /// If the returned Node is the proper Head, indicating a properly zipped Linked List
        /// </summary>
        [Fact]
        public void Zipped_Linked_List_Returns_Expected_Head_Node()
        {
            LinkedList aList = new LinkedList();
            aList.Insert(10);
            aList.Insert(8);
            aList.Insert(6);
            aList.Insert(4);
            aList.Insert(2);
            LinkedList bList = new LinkedList();
            bList.Insert(9);
            bList.Insert(7);
            bList.Insert(5);
            bList.Insert(3);
            bList.Insert(1);
            Assert.Equal(9, DataStructures.Program.ZipLists(aList, bList).Value);
        }
        [Fact]
        public void Zipped_Linked_List_Does_Not_Return_A_Previous_Node()
        {
            LinkedList aList = new LinkedList();
            aList.Insert(10);
            aList.Insert(8);
            aList.Insert(6);
            aList.Insert(4);
            aList.Insert(2);
            LinkedList bList = new LinkedList();
            bList.Insert(9);
            bList.Insert(7);
            bList.Insert(5);
            bList.Insert(3);
            bList.Insert(1);
            Assert.NotEqual(10, DataStructures.Program.ZipLists(aList, bList).Value);
        }
    }
}
