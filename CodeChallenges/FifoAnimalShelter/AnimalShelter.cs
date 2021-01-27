using System.Collections.Generic;

namespace FifoAnimalShelter

{
    public abstract class Animal
    {
        public abstract string Species { get; set; }
        public abstract Animal Next { get; set; }
        public abstract int UniqueID { get; set; }
    }



    public class Dog : Animal
    {
        public override string Species { get; set; } = "Dog";
        public override Animal Next { get; set; }
        public override int UniqueID { get; set; }
        public Dog(int val)
        {
            UniqueID = val;
        }
    }

    public class Cat : Animal
    {
        public override string Species { get; set; } = "Cat";
        public override Animal Next { get; set; }
        public override int UniqueID { get; set; }
        public Cat(int val)
        {
            UniqueID = val;
        }

    }

    public class AnimalShelter
    {

        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        public Queue<Animal> queue = new Queue<Animal>();

        /// <summary>
        /// Will add the animal to the back of the queue
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Animal Enqueue(Animal animal)
        {
            if (Front == null)
            {
                Front = animal;
                Rear = animal;
            }
            Rear.Next = animal;
            Rear = animal;
            return Rear;

        }
        /// <summary>
        /// Determine if it is the preference required.  If not, Enqueue the front to the rear, and pop the front
        /// </summary>
        /// <param name="pref"></param>
        /// <returns></returns>
        public Animal Dequeue(string pref)
        {
            Animal tempAnimal = Front;
            if (pref == Front.Species)
            {
                Front = tempAnimal.Next;
                return Front;
            }
            Rear.Next = tempAnimal;
            Rear = tempAnimal;
            Front = Front.Next;

            return null;

        }
    }
}
