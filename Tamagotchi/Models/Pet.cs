using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private static List<Pet> _instances = new List<Pet> { };
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
    public int Id { get; }
    public Pet(int food, int attention, int rest)
    {
      Food = food;
      Attention = attention;
      Rest = rest;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Pet> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

     public static Pet Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}