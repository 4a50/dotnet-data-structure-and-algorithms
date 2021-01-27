namespace DataStructures

{
    public abstract class Animal {
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
        public override string Species { get; set; } = "Dog";
        public override Animal Next { get; set; }
    }

    public class AnimalShelter
    {

        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        public Queue<Animal> queue = new Queue<Animal>();
        AnimalShelter()
        {   
        }
        public Animal Enqueue(Animal animal)
        {
            //Node<T> newNode = new Node<T>(value);
            //if (Front == null) { Front = newNode; Rear = newNode; }

            //Rear.Next = newNode;
            //Rear = newNode;
            if (Front == null) { Front = animal; Rear = animal; }
            Rear = animal;
            animal.Next = Front;
            
            return Rear;
        }

        public Animal Dequeue(string pref)
        {
                Animal TempAnimal;
                Animal currentAnimal = Front;
            
            
            while (Front != null)
            {
                
                if (pref == Front.Species)
                {                                        
                    return currentAnimal;
                }
                else
                {
                    TempAnimal = Front;
                    TempAnimal.Next = Rear;
                    Rear = TempAnimal;
                    queue.Enqueue(TempAnimal);
                    Front = Front.Next;
                }

            }

            return null;

        }
    }
}
