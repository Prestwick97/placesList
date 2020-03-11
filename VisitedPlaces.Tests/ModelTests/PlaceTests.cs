using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;
using System.Collections.Generic;

namespace Places.TestTools 
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreateInstanceOfPlace_Place()
    {
      Place newPlace = new Place("place");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void PlaceConstructor_ReturnNameOfCity_String()
    {
      Place newPlace = new Place("portland");
      string result = newPlace.CityName;
      Assert.AreEqual("portland", result);
    }

    [TestMethod]
    public void GetAll_ReturnsPlaces_PlaceList()
    {
      string CityName = "Portland";
      string CityName1 = "Seattle";
      Place newPlace1 = new Place(CityName);
      Place newPlace2 = new Place(CityName1);
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };

      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      string CityName = "Portland";
      string CityName1 = "Seattle";
      Place newPlace1 = new Place(CityName);
      Place newPlace2 = new Place(CityName1);

      Place result = Place.Find(2);
      Assert.AreEqual(newPlace2, result);
    }
    
  }
}