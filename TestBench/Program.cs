using FifoAnimalShelter;
namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter testShelter = new AnimalShelter();
            testShelter.Enqueue(new Cat(1));
            testShelter.Enqueue(new Cat(2));
            testShelter.Enqueue(new Dog(1));
            testShelter.Enqueue(new Cat(3));
            System.Console.WriteLine($"Animal Moved/Adopted: {testShelter.Dequeue("Dog")}");
            System.Console.WriteLine($"Animal Moved/Adopted: {testShelter.Dequeue("Dog")}");
            System.Console.WriteLine($"Animal Moved/Adopted: {testShelter.Dequeue("Dog")}");


        }
    }
}
