namespace FifoAnimalShelter
{
  public abstract class Animal
  {

    public abstract string Species { get; set; }
    public abstract Animal Next { get; set; }
    public abstract int UniqueID { get; set; }



  }
}
