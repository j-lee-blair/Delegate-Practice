//Julian Blair 140815
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5_ControlTower1._0
{

    public partial class MainForm : Form
    {
        private FlightManager f;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI(); //this can be removed when the program is finished
        }



        /// <summary>
        /// Handles the Click event of the btn_StartFlight control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_StartFlight_Click(object sender, EventArgs e)
        {
            //basic validation
            if ((txtbx_FlightNr.Text != string.Empty) && (txtBx_Destination.Text != string.Empty))
            {
                f = new FlightManager(txtbx_FlightNr.Text, txtBx_Destination.Text, DateTime.Now.ToShortTimeString());
                f.SetupObjects();

                Plane p = f.ReturnPlaneObject; //grants access to current plane object
                p.newTakeOff += OnTakeOff; //subsription to the publisher object
                p.quitTakeOff += OnLand; //subscription to the publiser object
                p.newRouteChange += OnRouteChange; //subscription to the publisher object
            }

            else MessageBox.Show("Enter Flight Nr and Destination!");
        }



        /// <summary>
        /// Initializes the GUI.
        /// </summary>
        private void InitializeGUI()
        {
            txtbx_FlightNr.Text = "SK1124";
            txtBx_Destination.Text = "GER, Hamburg";
        }


        /// <summary>
        /// Updates the GUI.
        /// </summary>
        private void UpdateGUI()
        {
            txtbx_FlightNr.Text = String.Empty;
            txtBx_Destination.Text = String.Empty;
        }


        /// <summary>
        /// Called when [take off]. displays info in desired format in MainForm
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        public void OnTakeOff(object sender, TakeOffEvent e) //No need to create an instance of Plane again as the information is stored in the event and returned via the delegate!
        {
            string[] row1 = { e.ToString(), e.GetStatusTime }; 
            lst_Flight_Status.Items.Add(e.GetFlightNumber).SubItems.AddRange(row1);
        }


        /// <summary>
        /// Called when [land]. Displays info in desired format in MainForm
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        public void OnLand(object sender, LandEvent e)
        {
            string[] row1 = { e.ToString(), e.GetLandStatus }; //the same here
            lst_Flight_Status.Items.Add(e.GetF_Number).SubItems.AddRange(row1);
            UpdateGUI();
        }

        /// <summary>
        /// Called when [route change]. Displays info in desired format in MainForm
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        public void OnRouteChange(object sender, ChangeRouteEvent e)
        {
            Routes currentRoute = e.GetRoute;

            string[] row1 = { e.ToString() + currentRoute.ToString(), e.GetRouteChangeTime }; //the same here
            lst_Flight_Status.Items.Add(e.GetFlightNr).SubItems.AddRange(row1);
        }
    }
}
