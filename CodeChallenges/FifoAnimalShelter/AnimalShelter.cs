using DataStructures;

namespace FifoAnimalShelter
{

  public class AnimalShelter
  {
    Queue<Animal> animalQueue = new Queue<Animal>();

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
      animalQueue.Enqueue(animal);

      return animal;

    }
    /// <summary>
    /// Determine if it is the preference required.  If not, Enqueue the front to the rear, and pop the front
    /// </summary>
    /// <param name="pref"></param>
    /// <returns></returns>
    public Animal Dequeue(string pref)
    {
      Animal tempAnimal;
      if (animalQueue != null)
      {
        tempAnimal = animalQueue.Peek();
        if (tempAnimal.Species == pref)
        {
          animalQueue.Dequeue();
          return tempAnimal;
        }
        else
        {
          //Do logic to dequeue 
        }
      }
      return new Animal("Dog");
    }
  }
}
