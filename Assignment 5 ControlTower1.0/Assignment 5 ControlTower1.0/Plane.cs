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
using System.Media;

namespace Assignment_5_ControlTower1._0
{
    public partial class Plane : Form
    {
        private FlightInfo flight = null;
        private string status_Time;
        private string destination;
        private string flightNumber;
        private Routes currentRoute;
        public delegate void TakeOffDeligate(object sender, TakeOffEvent e);
        public event TakeOffDeligate newTakeOff;
        public delegate void LandDelegate(object sender, LandEvent e);
        public event LandDelegate quitTakeOff;
        public delegate void ChangeRouteDelegate(object sender, ChangeRouteEvent e);
        public event ChangeRouteDelegate newRouteChange;


        public Plane(FlightInfo flights)
        {
            InitializeComponent();
            this.flight = flights;
            this.status_Time = flight.GetStatusTime;
            flightNumber = flight.GetFlightNr;
            destination = flight.GetFlightDestination;

            InitializeGUI();
        }

        /// <summary>
        /// Initializes the GUI.
        /// </summary>
        public void InitializeGUI()
        {
            cmb_Routes.DataSource = Enum.GetNames(typeof(Routes));
            this.Text = "Flight " + flightNumber + " - " + destination;
        }


        /// <summary>
        /// Handles the Click event of the btn_TakeOff control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void btn_TakeOff_Click(object sender, EventArgs e)
        {
            //validation
            if (btn_Land.Enabled == false)
            {
                btn_Land.Enabled = true;
                cmb_Routes.Enabled = true;
                btn_TakeOff.Enabled = false;
            }
                if (newTakeOff != null)
                    newTakeOff(this, new TakeOffEvent(flightNumber, DateTime.Now.ToShortTimeString()));
        }
        

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmb_Routes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmb_Routes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentRoute = (Routes)cmb_Routes.SelectedIndex;

            if (newRouteChange != null)
                newRouteChange(this, new ChangeRouteEvent(flightNumber, currentRoute, DateTime.Now.ToShortTimeString()));
        }



        /// <summary>
        /// Handles the Click event of the btn_Land control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Land_Click(object sender, EventArgs e)
        {
            if (quitTakeOff != null)
                quitTakeOff(this, new LandEvent(flightNumber, DateTime.Now.ToShortTimeString()));
            this.Close();
        }


        /// <summary>
        /// Handles the Click event of the btn_Plane_Type control. Shows PlaneTypes Form and disbles button
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Plane_Type_Click(object sender, EventArgs e)
        {
            PlaneTypes p = new PlaneTypes(this);
            p.Show();
            this.btn_Plane_Type.Visible = false;

            if (btn_Plane_Type.Visible == false)
            {
                btn_TakeOff.Enabled = true;
            }
        }

        /// <summary>
        /// Opens the sound player.
        /// </summary>
        /// <param name="sFile">The s file.</param>
        public void OpenSoundPlayer(string sFile)
        {
            SoundPlayer player = new SoundPlayer(sFile);
            player.Play();
        }

        /// <summary>
        /// Displays the image.
        /// </summary>
        /// <param name="iFile">The i file.</param>
        public void DisplayImage(string iFile)
        {
            pic_Box.ImageLocation = iFile;
            pic_Box.Show();
        }
    }
}
