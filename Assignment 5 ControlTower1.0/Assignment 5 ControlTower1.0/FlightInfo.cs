//Julian Blair 140815
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_ControlTower1._0
{
    public class FlightInfo: EventArgs
    {
        private string flight_Nr;
        private string stat_Time;
        private string flight_Destination;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlightInfo"/> class.
        /// </summary>
        /// <param name="flight">The flight.</param>
        /// <param name="status_Time">The status_ time.</param>
        /// <param name="flightDestination">The flight destination.</param>
        public FlightInfo(string flight, string status_Time, string flightDestination)
        {
            this.flight_Nr = flight;
            this.stat_Time = status_Time;
            this.flight_Destination = flightDestination;
        }

        /// <summary>
        /// Gets the get flight nr.
        /// </summary>
        /// <value>
        /// The get flight nr.
        /// </value>
        public string GetFlightNr
        {
            get { return flight_Nr; }
        }

        /// <summary>
        /// Gets the get status time.
        /// </summary>
        /// <value>
        /// The get status time.
        /// </value>
        public string GetStatusTime
        {
            get { return stat_Time; }
        }

        /// <summary>
        /// Gets the get flight destination.
        /// </summary>
        /// <value>
        /// The get flight destination.
        /// </value>
        public string GetFlightDestination
        {
            get { return flight_Destination; }
        }
    }  
}
