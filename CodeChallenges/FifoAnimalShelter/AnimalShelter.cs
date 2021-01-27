using System.Collections.Generic;

namespace FifoAnimalShelter
{
    
    public class AnimalShelter
    {

        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        public Queue<Dog> Queue { get; set; }
        public Queue<Cat> Queue { get; set; }
        public AnimalShelter()
        {           
        }
        
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
            if (pref == "Dog")
            {
                Dog.Q
            }
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
