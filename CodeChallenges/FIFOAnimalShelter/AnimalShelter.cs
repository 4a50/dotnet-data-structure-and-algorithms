namespace DataStructures

{
    public abstract class Animal
    {
        public abstract string Species { get; set; }
        public abstract Animal Next { get; set; }
    }



    public class Dog : Animal
    {
        public override string Species { get; set; } = "Dog";
        public override Animal Next { get; set; }
    }

    public class Cat : Animal
    {
        public override string Species { get; set; } = "Cat";
        public override Animal Next { get; set; }
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
            if(Front == null) 
            {
                Front = animal;
                return animal;
            }
            Animal currentAnimal = Front;
            //TODO: Infinite Loop when iterating to the end of the list.

            while (currentAnimal.Next != null)
            {
                currentAnimal = currentAnimal.Next;
            }
            currentAnimal.Next = animal;
            return animal;
                        
        }
        /// <summary>
        /// Determine if it is the preference required.  If not, Enqueue the front to the rear, and pop the front
        /// </summary>
        /// <param name="pref"></param>
        /// <returns></returns>
        public Animal Dequeue(string pref)
        {
                Animal front = Front;
            if (pref == Front.Species)
            {
                Front = Front.Next;
                return front;
            }
            Enqueue(front);
            Front = Front.Next;

            return null;

        }
    }
}
