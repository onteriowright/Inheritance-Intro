using System;

namespace InheritanceIntro
{
  public class Vehicle
  {
    public string Name { get; set; }
    public string MainColor { get; set; }
    public int MaxOccupancy { get; set; }
    public virtual void Drive()
    {
      Console.WriteLine("Vroom! ");
    }
    public virtual void Stop()
    {
      Console.Write($"The {Name} hit brakes! ");
    }
    public virtual void Turn()
    {
      Console.Write($"The {Name} gently turned right! ");
    }
  }
}