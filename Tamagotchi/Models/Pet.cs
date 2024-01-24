using System.Collections.Generic;
using System;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private static List<Pet> _instances = new List<Pet> { };
    public string Name { get; set; }
    public int Food { get; set; } = 10;
    public int Attention { get; set; } = 10;
    public int Rest { get; set; } = 10;
    public int Id { get; }
    public Pet(string name)
    {
      Name = name;
      // Food = food;
      // Attention = attention;
      // Rest = rest;
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
      if (searchId > 0 && searchId <= _instances.Count)
      {
        return _instances[searchId - 1];
      }
      else
      {
        return null;
      }
    }

    public void Feed()
    {
      Food = Food + 1;
    }
    public void Play()
    {
      Attention = Attention + 1;
    }
    public void Sleep()
    {
      Rest = Rest + 1;
    }
  }
}