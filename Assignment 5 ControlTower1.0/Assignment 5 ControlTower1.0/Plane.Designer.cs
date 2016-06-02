namespace Assignment_5_ControlTower1._0
{
    partial class Plane
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_Routes = new System.Windows.Forms.ComboBox();
            this.lbl_Change_Route = new System.Windows.Forms.Label();
            this.pic_Box = new System.Windows.Forms.PictureBox();
            this.btn_TakeOff = new System.Windows.Forms.Button();
            this.btn_Land = new System.Windows.Forms.Button();
            this.btn_Plane_Type = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Routes
            // 
            this.cmb_Routes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Routes.Enabled = false;
            this.cmb_Routes.FormattingEnabled = true;
            this.cmb_Routes.Location = new System.Drawing.Point(228, 255);
            this.cmb_Routes.Name = "cmb_Routes";
            this.cmb_Routes.Size = new System.Drawing.Size(131, 21);
            this.cmb_Routes.TabIndex = 0;
            this.cmb_Routes.SelectedIndexChanged += new System.EventHandler(this.cmb_Routes_SelectedIndexChanged);
            // 
            // lbl_Change_Route
            // 
            this.lbl_Change_Route.AutoSize = true;
            this.lbl_Change_Route.Location = new System.Drawing.Point(146, 258);
            this.lbl_Change_Route.Name = "lbl_Change_Route";
            this.lbl_Change_Route.Size = new System.Drawing.Size(76, 13);
            this.lbl_Change_Route.TabIndex = 1;
            this.lbl_Change_Route.Text = "Change Route";
            // 
            // pic_Box
            // 
            this.pic_Box.Location = new System.Drawing.Point(118, 36);
            this.pic_Box.Name = "pic_Box";
            this.pic_Box.Size = new System.Drawing.Size(265, 162);
            this.pic_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Box.TabIndex = 2;
            this.pic_Box.TabStop = false;
            // 
            // btn_TakeOff
            // 
            this.btn_TakeOff.Enabled = false;
            this.btn_TakeOff.Location = new System.Drawing.Point(12, 255);
            this.btn_TakeOff.Name = "btn_TakeOff";
            this.btn_TakeOff.Size = new System.Drawing.Size(75, 23);
            this.btn_TakeOff.TabIndex = 3;
            this.btn_TakeOff.Text = "Take Off";
            this.btn_TakeOff.UseVisualStyleBackColor = true;
            this.btn_TakeOff.Click += new System.EventHandler(this.btn_TakeOff_Click);
            // 
            // btn_Land
            // 
            this.btn_Land.Enabled = false;
            this.btn_Land.Location = new System.Drawing.Point(392, 255);
            this.btn_Land.Name = "btn_Land";
            this.btn_Land.Size = new System.Drawing.Size(75, 23);
            this.btn_Land.TabIndex = 4;
            this.btn_Land.Text = "Land";
            this.btn_Land.UseVisualStyleBackColor = true;
            this.btn_Land.Click += new System.EventHandler(this.btn_Land_Click);
            // 
            // btn_Plane_Type
            // 
            this.btn_Plane_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plane_Type.Location = new System.Drawing.Point(117, 36);
            this.btn_Plane_Type.Name = "btn_Plane_Type";
            this.btn_Plane_Type.Size = new System.Drawing.Size(266, 162);
            this.btn_Plane_Type.TabIndex = 5;
            this.btn_Plane_Type.Text = "Choose Plane Type";
            this.btn_Plane_Type.UseVisualStyleBackColor = true;
            this.btn_Plane_Type.Click += new System.EventHandler(this.btn_Plane_Type_Click);
            // 
            // Plane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 317);
            this.Controls.Add(this.btn_Plane_Type);
            this.Controls.Add(this.btn_Land);
            this.Controls.Add(this.btn_TakeOff);
            this.Controls.Add(this.pic_Box);
            this.Controls.Add(this.lbl_Change_Route);
            this.Controls.Add(this.cmb_Routes);
            this.Name = "Plane";
            this.Text = "Flight";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Routes;
        private System.Windows.Forms.Label lbl_Change_Route;
        private System.Windows.Forms.PictureBox pic_Box;
        private System.Windows.Forms.Button btn_TakeOff;
        private System.Windows.Forms.Button btn_Land;
        private System.Windows.Forms.Button btn_Plane_Type;
    }
}