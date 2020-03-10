using System;

namespace InheritanceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBike = new Zero();
            myBike.MainColor = "Black";
            myBike.MaxOccupancy = 2;
            myBike.Name = "Zero";

            var myTesla = new Tesla();
            myTesla.MainColor = "Space Gray";
            myTesla.MaxOccupancy = 6;
            myTesla.Name = "Tesla";

            var myCessna = new Cessna();
            myCessna.MainColor = "Wine Berry Over Gold";
            myCessna.MaxOccupancy = 4;
            myCessna.Name = "Cessna";

            var myRam = new Ram();
            myRam.MainColor = "Majestic Blue";
            myRam.MaxOccupancy = 8;
            myRam.Name = "Ram";

            myBike.Stop();
            myBike.Turn();
            myBike.Drive();
            myTesla.Stop();
            myTesla.Turn();
            myTesla.Drive();
            myCessna.Stop();
            myCessna.Turn();
            myCessna.Drive();
            myRam.Stop();
            myRam.Turn();
            myRam.Drive();

            Console.WriteLine(myTesla);

            double price = 15.00;
            Console.WriteLine(price.ToString("C"));

        }
    }
}