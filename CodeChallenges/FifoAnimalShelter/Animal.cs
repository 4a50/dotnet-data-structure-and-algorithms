namespace FifoAnimalShelter
{
  public class Animal
  {
    public string Species { get; set; }
    public Animal Next { get; set; }

    public Animal(string species)
    {
      Species = species;
    }
  }
}
