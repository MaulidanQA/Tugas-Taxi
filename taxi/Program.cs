using System;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek Taxi
            Taxi mobil1 = new Taxi();

            // Pemberian nilai properties
            mobil1.DriverName = "Jono";
            mobil1.OnDuty = true;
            mobil1.NumPassanger = 10;

            // Pemanggilan Method
            mobil1.TaxiInfo();
            mobil1.PickUpPassanger();
            mobil1.DropOffPassanger();

            Console.ReadKey();
        }
    }
}
