using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    public string CityName {get; set;}
    public string StayTime { get; set; }
    public string WithWhom {get; set; }
    public string Entry { get; set; }
    public string PhotoUrl {get; set;}
    public int Id {get;}
    private static List<Place> _instances = new List<Place> {};

    public Place(string cityName, string stayTime, string withWhom, string entry, string photoUrl)
    {
      CityName = cityName;
      StayTime = stayTime;
      WithWhom = withWhom;
      Entry = entry;
      PhotoUrl = photoUrl;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}