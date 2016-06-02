//Julian Blair 140815
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5_ControlTower1._0
{
    public class FlightManager
    {
        private string flight_Nr;
        private string flight_Destination;
        private string status_Time;
        private FlightInfo my_Current_Flight;
        private Plane new_Plane;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlightManager"/> class.
        /// </summary>
        /// <param name="f_Number">The f_ number.</param>
        /// <param name="f_Destination">The f_ destination.</param>
        /// <param name="time_STime_String">The time_ s time_ string.</param>
        public FlightManager(string f_Number, string f_Destination, string time_STime_String)
        {
            this.flight_Nr = f_Number;
            this.flight_Destination = f_Destination;
            this.status_Time = time_STime_String;
        }

        /// <summary>
        /// Gets the return plane object.
        /// </summary>
        /// <value>
        /// The return plane object.
        /// </value>
        public Plane ReturnPlaneObject
        {
            get { return new_Plane; }
        }

        /// <summary>
        /// setups up obj of plane and flight, also opens the Plane Window and Init the Plane GUI
        /// </summary>
        public void SetupObjects()
        {
            FlightInfo flight = SetupCurrentFlightObject();
            new_Plane = new Plane(my_Current_Flight);

            new_Plane.InitializeGUI();
            new_Plane.Show();
        }

        
        /// <summary>
        /// Called when [new take off]. Returns the current object of plane when a TakeOffEvent has been fired
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        /// <returns></returns>
        public Plane OnNewTakeOff(object sender, TakeOffEvent e)
        {
            return new_Plane;
        }

        /// <summary>
        /// Setups the current flight object and returns the current flight
        /// </summary>
        /// <returns></returns>
        public FlightInfo SetupCurrentFlightObject()
        {
            my_Current_Flight = new FlightInfo(flight_Nr, status_Time, flight_Destination);
            return my_Current_Flight;
        }
    }
}
