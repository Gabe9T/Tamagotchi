namespace Tamagotchi.Models
{
  public class Pet
  {
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
    public Pet(int food, int attention, int rest)
    {
      Food = food;
      Attention = attention;
      Rest = rest;


    }
  }
}