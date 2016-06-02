//Julian Blair 140815
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_ControlTower1._0
{
    public class PlaneSelectionEvent: EventArgs
    {
        private string m_Plane_Type;
        private string m_Image_File_Location;
        private string m_Sound_File_Location;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaneSelectionEvent"/> class.
        /// </summary>
        /// <param name="p_Type">Type of the p_.</param>
        /// <param name="sound_F_Loc">The sound_ f_ loc.</param>
        /// <param name="image_F_Loc">The image_ f_ loc.</param>
        public PlaneSelectionEvent(string p_Type, string sound_F_Loc, string image_F_Loc)
        {
            this.m_Plane_Type = p_Type;
            this.m_Image_File_Location = image_F_Loc;
            this.m_Sound_File_Location = sound_F_Loc;
        }

        /// <summary>
        /// Gets the type of the get plane.
        /// </summary>
        /// <value>
        /// The type of the get plane.
        /// </value>
        public string GetPlaneType
        {
            get { return m_Plane_Type; }
        }

        /// <summary>
        /// Gets the image get file location.
        /// </summary>
        /// <value>
        /// The image get file location.
        /// </value>
        public string ImageGetFileLocation
        {
            get { return m_Image_File_Location; }
        }

        /// <summary>
        /// Gets the sound get file location.
        /// </summary>
        /// <value>
        /// The sound get file location.
        /// </value>
        public string SoundGetFileLocation
        {
            get { return m_Sound_File_Location; }
        }
    }
}
