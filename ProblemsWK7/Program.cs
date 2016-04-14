using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProblemsWK7.Flight

{
    class Program
    {
        static void Main(string[] args)
        {
            AirportIterator GetTheFlight = new AirportIterator();
            GetTheFlight.addFlights();
            GetTheFlight.theFlight();
            Console.ReadKey();

        }
    }
}
