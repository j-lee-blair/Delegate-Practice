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
    public class LandEvent: EventArgs
    {
        private string f_Number;
        private string time;

        /// <summary>
        /// Initializes a new instance of the <see cref="LandEvent"/> class.
        /// </summary>
        /// <param name="flightNumber">The flight number.</param>
        /// <param name="time">The time.</param>
        public LandEvent(string flightNumber, string time)
        {
            this.f_Number = flightNumber;
            this.time = time;
        }

        /// <summary>
        /// Gets the get f_ number.
        /// </summary>
        /// <value>
        /// The get f_ number.
        /// </value>
        public string GetF_Number
        {
            get { return f_Number; }
        }

        /// <summary>
        /// Gets the get land status.
        /// </summary>
        /// <value>
        /// The get land status.
        /// </value>
        public string GetLandStatus
        {
            get {return time;}
        }


        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Landed");
        }
    }
}
