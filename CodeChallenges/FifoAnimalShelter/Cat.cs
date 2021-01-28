namespace FifoAnimalShelter
{
  public class Cat : Animal
  {
    public override string Species { get; set; } = "Cat";
    public override Animal Next { get; set; }
    public override int UniqueID { get; set; }
    public Cat()
    {
      //Queue = new Queue<Animal>();
    }
  }
}
