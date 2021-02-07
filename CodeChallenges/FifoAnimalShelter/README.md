# Code Challenge 12 - FIFO Animal Shelter

## Using Queues and Stacks
**Author**: JP Jones

---

### Problem Domain
Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
Implement the following methods:
+ enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
+ dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.

---

### Inputs and Expected Outputs

Original Queue: [Cat, Dog, Cat]
|Method| Input |Arguments|Expected Output   |
|: ---------| :----------- | :----------- |
|Enqueue| ["Dog"] | 25 |F[Dog, Cat, Dog, Cat]R| 
|Dequeue| ["Cat] |  | F[Dog, Cat, Dog]R

---

### Big O


| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |


---


### Whiteboard Visual
Original WhiteBoard
![Code Challenge 12 Whiteboard](./assets/Code-Challenge-12.png)


---

### Change Log

1.0: *Initial submission* - 26 Jan 21

1.1: Restructured The Queue System, added a temp Stack - 30 Jan 21

1.2: Added Tests - 30 Jan 21

2.0: *ReSubmit* - 30 Jan 21

---