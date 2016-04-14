using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ProblemsWK7.Flight;
namespace ProblemsWK7
{
   public class FlightList
    {
        public string destination;
        public string airline;
        public int flightNumber;
        public string day = "Friday April 16th";
        public int hour;
        public int minute;

        public FlightList(string destination, string airline, int flightNumber, int hour, int minute)
        {
            this.destination = destination;
            this.airline = airline;
            this.flightNumber = flightNumber;
            this.hour = hour;
            this.minute = minute;
        }

             public override string ToString()
        {
            return (String.Format("City:{0} Airline:{1} Flight #:{2} Time:{3}:{4}PM " + day, destination, airline, flightNumber, hour, minute, day));

        }
    }
}
