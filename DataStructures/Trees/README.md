# Code Challenge - Binary Trees
## Traversal and Add Nodes
*Author: JP Jones*

---

### Problem Domain

Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.

Create a BinaryTree class

+ Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which returns an array of the values, ordered appropriately.

Any exceptions or errors that come from your code should be semantic, capturable errors. For example, rather than a default error thrown by your language, your code should raise/throw a custom, semantic error that describes what went wrong in calling the methods you wrote for this lab.

Create a BinarySearchTree class

+ Define a method named add that accepts a value, and adds a new node with that value in the correct location in the binary search tree.

+ Define a method named contains that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.

---

### Inputs and Expected Outputs
 Binary Tree Traversals

| Input | Expected Output |
| :----------------------- | :----------- |
| Binary Tree (PreOrder) | [A,B,D,E,C,F,G] |
| Binary Tree (InOrder) | [D,B,E,A,F,C,G] |
| Binary Tree (PostOrder) | [D,B,E,F,G,C,A ] |
| Binary Search Tree (Add) Root 50 (Val 10)| Left Side |
| Binary Search Tree (Contains) 24| True/False |


---

### Big O


| Time | Space |
| :----------- | :----------- |
Binary Tree| O(n) | O(1) |
Binary Search Tree | O(LOGn)| O(1)

---


### Whiteboard Visual

#### Binary Search Tree Whiteboard

![Binary Tree Whiteboard](./assets/BinarySearchTree.png)

#### Binary Tree Whiteboard

![Binary Tree Whiteboard](./assets/BinaryTree.png)

---
## Max Value Method Addition
*Author: JP Jones*

---

### Problem Domain

Write an instance method called find-maximum-value. Without utilizing any of the built-in methods available return the maximum value stored in the tree. 
You can assume that the values stored in the Binary Tree will be numeric.

---

### Inputs and Expected Outputs
 Binary Tree Traversals

| Input | Expected Output |
| :----------------------- | :----------- |
| Tree [123,441,212,3,5,21] | 441|

---

### Big O


| Time | Space |
| :----------- | :----------- |
O(n) | O(1)

---
### MaxValue WhiteBoard

![FindMaxValue Method](./assets/MaxValue.png)


### Change Log
1.0: Initial Submission - 29 January 2121
2.0: Addition of MaxValue method - 1 February 2021