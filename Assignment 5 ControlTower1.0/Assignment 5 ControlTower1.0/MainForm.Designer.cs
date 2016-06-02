namespace Assignment_5_ControlTower1._0
{
    partial class MainForm
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
            this.btn_StartFlight = new System.Windows.Forms.Button();
            this.lst_Flight_Status = new System.Windows.Forms.ListView();
            this.f_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.f_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.f_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_FlightNr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_Destination = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_StartFlight
            // 
            this.btn_StartFlight.Location = new System.Drawing.Point(343, 355);
            this.btn_StartFlight.Name = "btn_StartFlight";
            this.btn_StartFlight.Size = new System.Drawing.Size(165, 39);
            this.btn_StartFlight.TabIndex = 0;
            this.btn_StartFlight.Text = "Send Flight to Runway";
            this.btn_StartFlight.UseVisualStyleBackColor = true;
            this.btn_StartFlight.Click += new System.EventHandler(this.btn_StartFlight_Click);
            // 
            // lst_Flight_Status
            // 
            this.lst_Flight_Status.AllowColumnReorder = true;
            this.lst_Flight_Status.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.f_Number,
            this.f_Status,
            this.f_Time});
            this.lst_Flight_Status.Location = new System.Drawing.Point(28, 26);
            this.lst_Flight_Status.Name = "lst_Flight_Status";
            this.lst_Flight_Status.Size = new System.Drawing.Size(526, 280);
            this.lst_Flight_Status.TabIndex = 2;
            this.lst_Flight_Status.UseCompatibleStateImageBehavior = false;
            this.lst_Flight_Status.View = System.Windows.Forms.View.Details;
            // 
            // f_Number
            // 
            this.f_Number.Text = "Flight Number";
            this.f_Number.Width = 189;
            // 
            // f_Status
            // 
            this.f_Status.Text = "Status";
            this.f_Status.Width = 272;
            // 
            // f_Time
            // 
            this.f_Time.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Flight Number for Next Flight";
            // 
            // txtbx_FlightNr
            // 
            this.txtbx_FlightNr.Location = new System.Drawing.Point(195, 355);
            this.txtbx_FlightNr.Name = "txtbx_FlightNr";
            this.txtbx_FlightNr.Size = new System.Drawing.Size(100, 20);
            this.txtbx_FlightNr.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Destination";
            // 
            // txtBx_Destination
            // 
            this.txtBx_Destination.Location = new System.Drawing.Point(195, 379);
            this.txtBx_Destination.Name = "txtBx_Destination";
            this.txtBx_Destination.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Destination.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 426);
            this.Controls.Add(this.txtBx_Destination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_FlightNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Flight_Status);
            this.Controls.Add(this.btn_StartFlight);
            this.Name = "MainForm";
            this.Text = "ControlTower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartFlight;
        private System.Windows.Forms.ListView lst_Flight_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_FlightNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_Destination;
        private System.Windows.Forms.ColumnHeader f_Number;
        private System.Windows.Forms.ColumnHeader f_Status;
        private System.Windows.Forms.ColumnHeader f_Time;
    }
}

