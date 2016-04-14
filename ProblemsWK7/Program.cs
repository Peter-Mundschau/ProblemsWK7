using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ProblemsWK7;

namespace ProblemsWK7

{
    public class Program
    {
        static void Main(string[] args)
        {
            AirportIterator GetTheFlight = new AirportIterator();
            GetTheFlight.addFlights();
            GetTheFlight.theFlight();
            Console.ReadKey();

            Person Info = new Person();
            Info.EnterBirthdate();

        }
    }
}
