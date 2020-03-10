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

            var myTesla = new Tesla();
            myTesla.MainColor = "Space Gray";
            myTesla.MaxOccupancy = 6;

            var myCessna = new Cessna();
            myCessna.MainColor = "Wine Berry Over Gold";
            myCessna.MaxOccupancy = 4;

            var myRam = new Ram();
            myRam.MainColor = "Majestic Blue";
            myRam.MaxOccupancy = 8;

            myBike.Drive();
            myBike.Stop();
            myBike.Turn();
            myTesla.Drive();
            myTesla.Stop();
            myTesla.Turn();
            myCessna.Drive();
            myCessna.Stop();
            myCessna.Turn();
            myRam.Drive();
            myRam.Stop();
            myRam.Turn();

            Console.WriteLine(myTesla);

            double price = 15.00;
            Console.WriteLine(price.ToString("C"));

        }
    }
}