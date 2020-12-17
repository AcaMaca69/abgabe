
namespace SBB
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.rdbArrival = new System.Windows.Forms.RadioButton();
            this.rdbDeparture = new System.Windows.Forms.RadioButton();
            this.chbSpecifyTime = new System.Windows.Forms.CheckBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.grbLocation = new System.Windows.Forms.GroupBox();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.lblDestinationLocation = new System.Windows.Forms.Label();
            this.cmbStartLocation = new System.Windows.Forms.ComboBox();
            this.cmbDestinationLocation = new System.Windows.Forms.ComboBox();
            this.ltvConnections = new System.Windows.Forms.ListView();
            this.clmStartStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDestinationStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDelay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbTime.SuspendLayout();
            this.grbLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(713, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Station in der Nähe: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(908, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 72);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(542, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 199);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Verbindungen Suchen";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grbTime
            // 
            this.grbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTime.Controls.Add(this.rdbArrival);
            this.grbTime.Controls.Add(this.rdbDeparture);
            this.grbTime.Controls.Add(this.chbSpecifyTime);
            this.grbTime.Controls.Add(this.dtpTime);
            this.grbTime.ForeColor = System.Drawing.Color.Blue;
            this.grbTime.Location = new System.Drawing.Point(54, 134);
            this.grbTime.Margin = new System.Windows.Forms.Padding(2);
            this.grbTime.Name = "grbTime";
            this.grbTime.Padding = new System.Windows.Forms.Padding(2);
            this.grbTime.Size = new System.Drawing.Size(483, 98);
            this.grbTime.TabIndex = 12;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "Zeit // Datum";
            // 
            // rdbArrival
            // 
            this.rdbArrival.AutoSize = true;
            this.rdbArrival.Location = new System.Drawing.Point(96, 54);
            this.rdbArrival.Margin = new System.Windows.Forms.Padding(2);
            this.rdbArrival.Name = "rdbArrival";
            this.rdbArrival.Size = new System.Drawing.Size(62, 17);
            this.rdbArrival.TabIndex = 5;
            this.rdbArrival.TabStop = true;
            this.rdbArrival.Text = "Ankunft";
            this.rdbArrival.UseVisualStyleBackColor = true;
            // 
            // rdbDeparture
            // 
            this.rdbDeparture.AutoSize = true;
            this.rdbDeparture.Checked = true;
            this.rdbDeparture.Location = new System.Drawing.Point(9, 54);
            this.rdbDeparture.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDeparture.Name = "rdbDeparture";
            this.rdbDeparture.Size = new System.Drawing.Size(59, 17);
            this.rdbDeparture.TabIndex = 4;
            this.rdbDeparture.TabStop = true;
            this.rdbDeparture.Text = "Abfahrt";
            this.rdbDeparture.UseVisualStyleBackColor = true;
            // 
            // chbSpecifyTime
            // 
            this.chbSpecifyTime.AutoSize = true;
            this.chbSpecifyTime.Location = new System.Drawing.Point(9, 25);
            this.chbSpecifyTime.Margin = new System.Windows.Forms.Padding(2);
            this.chbSpecifyTime.Name = "chbSpecifyTime";
            this.chbSpecifyTime.Size = new System.Drawing.Size(90, 17);
            this.chbSpecifyTime.TabIndex = 2;
            this.chbSpecifyTime.Text = "Specify &Time:";
            this.chbSpecifyTime.UseVisualStyleBackColor = true;
            this.chbSpecifyTime.CheckedChanged += new System.EventHandler(this.chbSpecifyTime_CheckedChanged);
            // 
            // dtpTime
            // 
            this.dtpTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTime.CustomFormat = "HH:mm / yyyy-MM-dd";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(110, 25);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(357, 20);
            this.dtpTime.TabIndex = 3;
            // 
            // grbLocation
            // 
            this.grbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLocation.Controls.Add(this.lblStartLocation);
            this.grbLocation.Controls.Add(this.lblDestinationLocation);
            this.grbLocation.Controls.Add(this.cmbStartLocation);
            this.grbLocation.Controls.Add(this.cmbDestinationLocation);
            this.grbLocation.ForeColor = System.Drawing.Color.Blue;
            this.grbLocation.Location = new System.Drawing.Point(54, 32);
            this.grbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.grbLocation.Name = "grbLocation";
            this.grbLocation.Padding = new System.Windows.Forms.Padding(2);
            this.grbLocation.Size = new System.Drawing.Size(483, 98);
            this.grbLocation.TabIndex = 11;
            this.grbLocation.TabStop = false;
            this.grbLocation.Text = "Orts Angaben";
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.ForeColor = System.Drawing.Color.Blue;
            this.lblStartLocation.Location = new System.Drawing.Point(4, 26);
            this.lblStartLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(109, 14);
            this.lblStartLocation.TabIndex = 0;
            this.lblStartLocation.Text = "Startort:";
            // 
            // lblDestinationLocation
            // 
            this.lblDestinationLocation.ForeColor = System.Drawing.Color.Blue;
            this.lblDestinationLocation.Location = new System.Drawing.Point(4, 54);
            this.lblDestinationLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinationLocation.Name = "lblDestinationLocation";
            this.lblDestinationLocation.Size = new System.Drawing.Size(122, 14);
            this.lblDestinationLocation.TabIndex = 0;
            this.lblDestinationLocation.Text = "Ankunftsstation:";
            // 
            // cmbStartLocation
            // 
            this.cmbStartLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStartLocation.FormattingEnabled = true;
            this.cmbStartLocation.Location = new System.Drawing.Point(130, 26);
            this.cmbStartLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStartLocation.Name = "cmbStartLocation";
            this.cmbStartLocation.Size = new System.Drawing.Size(333, 21);
            this.cmbStartLocation.TabIndex = 0;
            this.cmbStartLocation.TextUpdate += new System.EventHandler(this.cmbStartLocation_TextUpdate);
            // 
            // cmbDestinationLocation
            // 
            this.cmbDestinationLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDestinationLocation.FormattingEnabled = true;
            this.cmbDestinationLocation.Location = new System.Drawing.Point(130, 51);
            this.cmbDestinationLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestinationLocation.Name = "cmbDestinationLocation";
            this.cmbDestinationLocation.Size = new System.Drawing.Size(333, 21);
            this.cmbDestinationLocation.TabIndex = 1;
            this.cmbDestinationLocation.TextUpdate += new System.EventHandler(this.cmbDestinationLocation_TextUpdate);
            // 
            // ltvConnections
            // 
            this.ltvConnections.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ltvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStartStation,
            this.clmDepartureTime,
            this.clmDestinationStation,
            this.clmArrivalTime,
            this.clmDuration,
            this.clmDelay});
            this.ltvConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltvConnections.ForeColor = System.Drawing.Color.Blue;
            this.ltvConnections.FullRowSelect = true;
            this.ltvConnections.GridLines = true;
            this.ltvConnections.HideSelection = false;
            this.ltvConnections.Location = new System.Drawing.Point(54, 236);
            this.ltvConnections.Margin = new System.Windows.Forms.Padding(2);
            this.ltvConnections.Name = "ltvConnections";
            this.ltvConnections.Size = new System.Drawing.Size(916, 331);
            this.ltvConnections.TabIndex = 13;
            this.ltvConnections.UseCompatibleStateImageBehavior = false;
            this.ltvConnections.View = System.Windows.Forms.View.Details;
            this.ltvConnections.SelectedIndexChanged += new System.EventHandler(this.ltvConnections_SelectedIndexChanged);
            // 
            // clmStartStation
            // 
            this.clmStartStation.Text = "Startstation";
            this.clmStartStation.Width = 150;
            // 
            // clmDepartureTime
            // 
            this.clmDepartureTime.Text = "Abfahrtsuhrzeit";
            this.clmDepartureTime.Width = 150;
            // 
            // clmDestinationStation
            // 
            this.clmDestinationStation.Text = "Ankunftsstation";
            this.clmDestinationStation.Width = 150;
            // 
            // clmArrivalTime
            // 
            this.clmArrivalTime.Text = "Ankunftsuhrzeit";
            this.clmArrivalTime.Width = 150;
            // 
            // clmDuration
            // 
            this.clmDuration.Text = "Reisezeit";
            this.clmDuration.Width = 150;
            // 
            // clmDelay
            // 
            this.clmDelay.Text = "Verspätung";
            this.clmDelay.Width = 150;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grbTime);
            this.Controls.Add(this.grbLocation);
            this.Controls.Add(this.ltvConnections);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "Fahrplan ala ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.grbLocation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.RadioButton rdbArrival;
        private System.Windows.Forms.RadioButton rdbDeparture;
        private System.Windows.Forms.CheckBox chbSpecifyTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.GroupBox grbLocation;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.Label lblDestinationLocation;
        private System.Windows.Forms.ComboBox cmbStartLocation;
        private System.Windows.Forms.ComboBox cmbDestinationLocation;
        private System.Windows.Forms.ListView ltvConnections;
        private System.Windows.Forms.ColumnHeader clmStartStation;
        private System.Windows.Forms.ColumnHeader clmDepartureTime;
        private System.Windows.Forms.ColumnHeader clmDestinationStation;
        private System.Windows.Forms.ColumnHeader clmArrivalTime;
        private System.Windows.Forms.ColumnHeader clmDuration;
        private System.Windows.Forms.ColumnHeader clmDelay;
    }
}