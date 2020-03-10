using System;

namespace InheritanceIntro
{
  public class Cessna : Vehicle
  { // Propellor light aircraft
    public double FuelCapacity { get; set; }
    public void RefuelTank() { }
    public override void Stop()
    {
      Console.WriteLine($"The Cessna rolled to a stop!");
    }
  }
}