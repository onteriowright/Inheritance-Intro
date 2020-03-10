using System;

namespace InheritanceIntro
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public int MaxOccupancy { get; set; }
    public virtual void Drive()
    {
      Console.WriteLine("Vroom!");
    }
    public virtual void Stop()
    {
      Console.WriteLine("The vehicle hit brakes!");
    }
    public virtual void Turn()
    {
      Console.WriteLine("The vehicle gently turned right!");
    }
  }
}