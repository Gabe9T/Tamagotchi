namespace Tamagotchi.Models
{
  public class Pet
  {
    public int Food { get; set; }
    public int Attention {get;}
  public Pet(int food, int attention)
  {
    Food = food;
    Attention = attention;
    // Rest = rest;
    

  }
}
}