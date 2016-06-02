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
    public partial class PlaneTypes : Form
    {
        private string plane_Type;
        private string image_File_Location;
        private string sound_File_Location;
        Plane p;
        public delegate void PlaneSelectionEventDelegate(object sender, PlaneSelectionEvent e);
        public event PlaneSelectionEventDelegate newPlaneSelected;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaneTypes"/> class.
        /// </summary>
        /// <param name="p">The p.</param>
        public PlaneTypes(Plane p)
        {
            InitializeComponent();
            this.p = p;
        }

        /// <summary>
        /// Subscribes to plane selection event.
        /// </summary>
        private void SubscribeToEvent()
        {
            newPlaneSelected += OnPlaneSelected;
        }

 
        /// <summary>
        /// Called when [plane selected]. Initializes plane selection event
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void OnPlaneSelected(object sender, PlaneSelectionEvent e)
        {
            string plane_Selected = e.GetPlaneType;
            string sound_File_Location = e.SoundGetFileLocation;
            string image_File_Location = e.ImageGetFileLocation;
        }
        
        /// <summary>
        /// Handles the Click event of the btn_OK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (radio_Btn_Airplane.Checked == true)
            {
                plane_Type = "AirPlane";
                this.Hide();
                sound_File_Location = @"airplane-fly-by-01a.wav";
                image_File_Location = @"plane.jpg";

                //ReturnPlane(plane_Type); //do not need this line of code the plane type changes without having to return the variable
            }

            else if (radio_Btn_Tie.Checked == true) 
            {
                plane_Type = "TiePlane";
                sound_File_Location = @"tieFighterMP31.wav";
                image_File_Location = @"taiFighter.jpg";
                this.Hide();
            }

            else if (radio_Btn_X.Checked == true)
            {
                plane_Type = "XWing";
                sound_File_Location = @"spaceShipSound.wav";
                image_File_Location = @"xWingFighter.jpg";
                this.Hide();
            }

            SubscribeToEvent();

            //if new plane is selected create new event
            if (newPlaneSelected != null)
                newPlaneSelected(this, new PlaneSelectionEvent(plane_Type, sound_File_Location, image_File_Location)); //this was moved from Main to the form where it is needed as it was null otherwise


            //calls the image display and sound play methods and passes filepaths
            if (e != null)
            {
                p.DisplayImage(image_File_Location);
                p.OpenSoundPlayer(sound_File_Location);
            }
        
        }
    }
}
