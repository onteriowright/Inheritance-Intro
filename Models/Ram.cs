using System;

namespace InheritanceIntro
{
  public class Ram : Vehicle
  { // Gas powered truck
    public double FuelCapacity { get; set; }
    public void RefuelTank() { }
    public override void Turn()
    {
      Console.Write($"The {MainColor} {Name} gently turned right! ");
    }
  }
}