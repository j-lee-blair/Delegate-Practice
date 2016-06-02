//Julian Blair 140815
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment_5_ControlTower1._0
{
    public enum Routes
    {
        North,
        NorthEast,
        East,
        SouthEast,
        South,
        SouthWest,
        West,
        NorthWest
    }

    public class ChangeRouteEvent
    {
        private Routes my_Route;
        private string my_Flight;
        private string status_Time;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeRouteEvent"/> class.
        /// </summary>
        /// <param name="flight">The flight.</param>
        /// <param name="route">The route.</param>
        /// <param name="stat_Time">The stat_ time.</param>
        public ChangeRouteEvent(string flight, Routes route, string stat_Time)
        {
            this.my_Route = route;
            this.status_Time = stat_Time;
            this.my_Flight = flight;
        }

        /// <summary>
        /// Gets the get flight nr.
        /// </summary>
        /// <value>
        /// The get flight nr.
        /// </value>
        public string GetFlightNr
        {
            get { return my_Flight; }
        }

        /// <summary>
        /// Gets the get route.
        /// </summary>
        /// <value>
        /// The get route.
        /// </value>
        public Routes GetRoute
        {
            get { return my_Route; }
        }

        /// <summary>
        /// Gets the get route change time.
        /// </summary>
        /// <value>
        /// The get route change time.
        /// </value>
        public string GetRouteChangeTime
        {
            get { return status_Time; }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return String.Format("Flight route adjusted ");
        }
    }
}
