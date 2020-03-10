using System;

namespace InheritanceIntro
{
  public class Cessna : Vehicle
  { // Propellor light aircraft
    public double FuelCapacity { get; set; }
    public void RefuelTank() { }
    public override void Stop()
    {
      Console.Write($"The {Name} rolled to a stop! ");
    }
    public override void Turn()
    {
      Console.Write($"The {Name} gently turned right! ");
    }
  }
}