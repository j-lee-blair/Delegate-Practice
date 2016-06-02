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
    public class TakeOffEvent: EventArgs
    {
        private string f_Number;
        private string status_Time;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TakeOffEvent"/> class.
        /// </summary>
        /// <param name="flightNumber">The flight number.</param>
        /// <param name="stat_Time">The stat_ time.</param>

        public TakeOffEvent(string flightNumber, string stat_Time)
        {
            this.f_Number = flightNumber;
            this.status_Time = stat_Time;
        }

        /// <summary>
        /// Gets the get flight number.
        /// </summary>
        /// <value>
        /// The get flight number.
        /// </value>
        public string GetFlightNumber
        {
            get { return f_Number; }
        }

        /// <summary>
        /// Gets the get status time.
        /// </summary>
        /// <value>
        /// The get status time.
        /// </value>
        public string GetStatusTime
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
            return String.Format("Flight lift off");
        }
    }
}
