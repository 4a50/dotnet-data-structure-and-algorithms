namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter testShelter = new AnimalShelter();
            testShelter.Enqueue(new Cat());
            testShelter.Enqueue(new Cat());
            testShelter.Enqueue(new Dog());
            testShelter.Enqueue(new Cat());
            System.Console.WriteLine($"Animal Moved/Adopted: {testShelter.Dequeue("Dog")}");
            System.Console.WriteLine($"Animal Moved/Adopted: {testShelter.Dequeue("Dog")}");
            System.Console.WriteLine($"Animal Moved/Adopted: {testShelter.Dequeue("Dog")}");


        }
    }
}
