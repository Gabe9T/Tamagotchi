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
      Pet newPet = new Pet("test name");
      Assert.AreEqual(typeof(Pet), newPet.GetType());
    }

    [TestMethod]
    public void GetFood_ReturnsFood_Int()
    {
      int food = 10;
      Pet newPet = new Pet("name");
      int result = newPet.Food;
      Assert.AreEqual(food, result);
    }
    [TestMethod]
    public void SetFood_SetsValueOfFood_Int()
    {
      Pet newPet = new Pet("name");
      int updatedFood = 9;
      newPet.Food = updatedFood;
      int result = newPet.Food;
      Assert.AreEqual(updatedFood, result);
    }

    [TestMethod]

    public void GetAttention_ReturnsAttention_Int()
    {
      int attention = 10;
      Pet newPet = new Pet("name");
      int result = newPet.Attention;
      Assert.AreEqual(attention, result);
    }
    [TestMethod]
    public void SetAttention_SetsValueOfAttention_Int()
    {
      Pet newPet = new Pet("name");
      int updatedAttention = 9;
      newPet.Attention = updatedAttention;
      int result = newPet.Attention;
      Assert.AreEqual(updatedAttention, result);
    }

    [TestMethod]
    public void getRest_ReturnsRest_Int()
    {
      int rest = 10;
      Pet newPet = new Pet("name");
      int result = newPet.Rest;
      Assert.AreEqual(rest, result);
    }
    [TestMethod]
    public void SetRest_SetsValueOfRest_Int()
    {
      Pet newPet = new Pet("name");
      int updatedRest = 9;
      newPet.Rest = updatedRest;
      int result = newPet.Rest;
      Assert.AreEqual(updatedRest, result);
    }
    [TestMethod]
    public void getName_ReturnsName_String()
    {
      string name = "name";
      Pet newPet = new Pet(name);
      string result = newPet.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void SetName_SetsValueOfName_String()
    {
      string name = "Bob";
      Pet newPet = new Pet(name);
      string updatedName = "Spike";
      newPet.Name = updatedName;
      string result = newPet.Name;
      Assert.AreEqual(updatedName, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PetList()
    {
      List<Pet> newList = new List<Pet> { };
      List<Pet> result = Pet.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]

    public void GetAll_ReturnsPets_PetsList()
    {
      Pet newPet = new Pet("name1");
      Pet newPet2 = new Pet("name2");

      List<Pet> newList = new List<Pet> { newPet, newPet2 };
      List<Pet> result = Pet.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_ItemsInstantiateWithIdAndGetterReturn_Int()
    {
      Pet newPet = new Pet("name");
      int result = newPet.Id;
      Assert.AreEqual(1, result);
    }
    public void Find_ReturnsCorrectPet_Pet()
    {
      Pet newPet = new Pet("name1");
      Pet newPet2 = new Pet("name2");
      //Act
      Pet result = Pet.Find(2);
      //Assert
      Assert.AreEqual(newPet, result);
    }
    public void Feed_UpdatesFeed_Void()
    {
      Pet newPet = new Pet("Bob");
      newPet.Feed();
      Assert.AreEqual(11, newPet.Food);
    }

  }
}