using System;

namespace InheritanceIntro
{
  public class Tesla : Vehicle
  { // Electric car
    public double BatteryKWh { get; set; }
    public void ChargeBattery() { }
    public override void Drive()
    {
      Console.WriteLine("Rumble Rumble! ");
    }
    public override void Stop()
    {
      Console.Write($"The {Name} silently stops as it never moved! ");
    }
    public override void Turn()
    {
      Console.Write($"The {Name} squeezed a right turn! ");
    }
    public override string ToString()
    {
      return "This is my telsa";
    }
  }
}