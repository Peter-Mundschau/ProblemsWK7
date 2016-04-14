using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsWK7.Flight

{
    public class AirportIterator : IEnumerable
    {
        List<FlightList> theFlights = new List<FlightList>();

        public AirportIterator()
        {

        }

        public IEnumerator GetEnumerator()
        {
            foreach (FlightList flight in theFlights)
            {
                if (flight.destination.Equals("Los Angeles"))
                {
                    yield return flight;
                }
            }
            throw new NotImplementedException();
        }

        public void theFlight()
        {

            foreach (FlightList flight in this)
            {
                Console.WriteLine(flight);
            }

        }

        public void addFlights()
        {
            theFlights.Add(new FlightList("Denver", "United", 5161, 3, 00));
            theFlights.Add(new FlightList("Fort Myers", "Southwest", 1783, 3, 00));
            theFlights.Add(new FlightList("Los Angeles", "Southwest", 3259, 3, 10));
            theFlights.Add(new FlightList("Minneapolis", "Delta", 1944, 3, 14));
            theFlights.Add(new FlightList("Minneapolis", "WestJet", 6941, 3, 14));
            theFlights.Add(new FlightList("Chicago", "United", 5049, 3, 15));
            theFlights.Add(new FlightList("Chicago", "Copa Airlines", 1982, 3, 15));
            theFlights.Add(new FlightList("Cleveland", "United", 4401, 3, 39));
            theFlights.Add(new FlightList("Orlando", "Southwest", 3874, 3, 40));
            theFlights.Add(new FlightList("San Francisco", "Southwest", 679, 3, 50));
            theFlights.Add(new FlightList("Seattle", "Alaska Airlines", 3423, 4, 00));
            theFlights.Add(new FlightList("New York", "Southwest", 1988, 4, 20));
            theFlights.Add(new FlightList("Philadelphia", "American Airlines", 3984, 4, 20));
            theFlights.Add(new FlightList("Charlotte", "American Airlines", 5098, 4, 20));
            theFlights.Add(new FlightList("Houston", "United", 4052, 4, 27));
            theFlights.Add(new FlightList("Chicago", "United", 5009, 4, 29));
            theFlights.Add(new FlightList("Chicago", "Copa Airlines", 1309, 4, 29));
            theFlights.Add(new FlightList("Chicago", "Aer Lingus", 6641, 4, 29));
            theFlights.Add(new FlightList("Detroit", "Delta", 333, 4, 35));
            theFlights.Add(new FlightList("Detroit", "Virgin Atlantic", 4583, 4, 35));
            theFlights.Add(new FlightList("Detroit,", "WestJet", 6634, 4, 35));
            theFlights.Add(new FlightList("Chicago", "Britsh AirWays", 1901, 4, 37));
            theFlights.Add(new FlightList("Chicago", "Qatar Airways", 5255, 4, 37));



        }
    }

}
