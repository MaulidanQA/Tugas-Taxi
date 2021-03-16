using System;

namespace taxi
{
    public class Taxi
    {
        // properties
        public string DriverName { get; set;}
        public bool OnDuty { get; set; }
        public int NumPassanger { get; set;}

        // method
        public void TaxiInfo ()
        {
            Console.WriteLine ("Driver Name : {0}", DriverName);
            
            if (OnDuty) Console.WriteLine ("On Duty : Yes");
            else Console.WriteLine ("On Duty : NO");

            Console.WriteLine ("Number of Passanger : {0}", NumPassanger);

            Console.WriteLine();
        }

        public void PickUpPassanger ()
        {
            Console.WriteLine ("{0}, sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassanger ()
        {
            Console.WriteLine ("{0}, Sudah selesai mengantar penumpang", DriverName);
        }
    }
}
