using DataStructures;

namespace FifoAnimalShelter
{

  public class AnimalShelter
  {
    public Queue<Animal> animalQueue = new Queue<Animal>();

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
      Stack<Animal> searchStack = new Stack<Animal>();
        tempAnimal = animalQueue.Front.Value;
      // Searched the Animal Queue for the preferred animal
        while (animalQueue.Front != null)
        {
          tempAnimal = animalQueue.Front.Value;
          if (tempAnimal.Species == pref)
          {
            animalQueue.Dequeue();
            break;
          }
          searchStack.Push(tempAnimal);
          animalQueue.Dequeue();
        }
      //If it does not find that animal set temp to null
      tempAnimal = null;
      //Enqueues the stack to the animalQueue
        while (searchStack.Top != null)
      {
        animalQueue.Enqueue(searchStack.Top.Value);
        searchStack.Pop();
      }
      
      return tempAnimal;
      }
      
    
  }
}
