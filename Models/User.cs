using System;

namespace csone.Models
{

  public class User
  {
    //Properties
    public string Name { get; set; }
    public string Mood { get; set; }

    //Field
    private bool _isAlive;

    public void greet()
    {
      Console.WriteLine($"Hello my name is {Name} and I am feeling {Mood}");
    }

    public bool IsAlive()
    {
      if (_isAlive)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    //Constructor
    public User(string name, string mood)
    {
      Name = name;
      Mood = mood;
      _isAlive = true;
    }

  }

}