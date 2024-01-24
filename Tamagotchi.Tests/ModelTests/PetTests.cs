using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.TestTools
{
  [TestClass]
  public class PetTests
  {
    [TestMethod]
    public void PetConstructor_CreatesInstanceOfPet_Pet()
    {
      Pet newPet = new Pet(5);
      Assert.AreEqual(typeof(Pet), newPet.GetType());
    }

    [TestMethod]
    public void GetFood_ReturnsFood_Int()
    {
      int food = 5;
      Pet newPet = new Pet(food);
      int result = newPet.Food;
      Assert.AreEqual(food, result);
    }
  }
  }