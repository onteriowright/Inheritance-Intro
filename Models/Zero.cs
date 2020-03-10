using System;

namespace InheritanceIntro
{
  public class Zero : Vehicle
  { // Electric motorcycle
    public double BatteryKWh { get; set; }
    public void ChargeBattery() { }
    public override void Turn()
    {
      Console.Write($"The {MainColor} {Name} gently turned right! ");
    }
  }

}