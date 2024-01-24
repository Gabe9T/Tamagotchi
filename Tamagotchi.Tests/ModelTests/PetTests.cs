using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.TestTools
{
  [TestClass]
  public class PetTests : IDisposable
  {
    public void Dispose()
    {
      Pet.ClearAll();
    }
    [TestMethod]
    public void PetConstructor_CreatesInstanceOfPet_Pet()
    {
      Pet newPet = new Pet(5, 5, 5);
      Assert.AreEqual(typeof(Pet), newPet.GetType());
    }

    [TestMethod]
    public void GetFood_ReturnsFood_Int()
    {
      int food = 5;
      Pet newPet = new Pet(food, 5, 5);
      int result = newPet.Food;
      Assert.AreEqual(food, result);
    }
    [TestMethod]
    public void SetFood_SetsValueOfFood_Int()
    {
      int food = 5;
      Pet newPet = new Pet(food, 5, 5);
      int updatedFood = 9;
      newPet.Food = updatedFood;
      int result = newPet.Food;
      Assert.AreEqual(updatedFood, result);
    }

    [TestMethod]

    public void GetAttention_ReturnsAttention_Int()
    {
      int attention = 5;
      Pet newPet = new Pet(3, attention, 5);
      int result = newPet.Attention;
      Assert.AreEqual(attention, result);
    }
    [TestMethod]
    public void SetAttention_SetsValueOfAttention_Int()
    {
      int attention = 5;
      Pet newPet = new Pet(4, attention, 5);
      int updatedAttention = 9;
      newPet.Attention = updatedAttention;
      int result = newPet.Attention;
      Assert.AreEqual(updatedAttention, result);
    }

    [TestMethod]
    public void getRest_ReturnsRest_Int()
    {
      int rest = 5;
      Pet newPet = new Pet(3, 5, rest);
      int result = newPet.Rest;
      Assert.AreEqual(rest, result);
    }
    [TestMethod]
    public void SetRest_SetsValueOfRest_Int()
    {
      int rest = 5;
      Pet newPet = new Pet(4, 5, rest);
      int updatedRest = 9;
      newPet.Rest = updatedRest;
      int result = newPet.Rest;
      Assert.AreEqual(updatedRest, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PetList()
    {
      List<Pet> newList = new List<Pet> { };
      List<Pet> result = Pet.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    


  }
}