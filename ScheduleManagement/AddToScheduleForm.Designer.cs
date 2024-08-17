namespace ScheduleManagement
{
	partial class AddToScheduleForm
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
            btnScheduleExit = new Button();
            txtEventName = new TextBox();
            dtEventDate = new DateTimePicker();
            txtEventLocation = new TextBox();
            lblEventName = new Label();
            lblEventLocation = new Label();
            lblEventDate = new Label();
            btnAddEvent = new Button();
            SuspendLayout();
            // 
            // btnScheduleExit
            // 
            btnScheduleExit.Location = new Point(419, 299);
            btnScheduleExit.Name = "btnScheduleExit";
            btnScheduleExit.Size = new Size(166, 106);
            btnScheduleExit.TabIndex = 0;
            btnScheduleExit.Text = "Exit";
            btnScheduleExit.UseVisualStyleBackColor = true;
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(288, 74);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(200, 23);
            txtEventName.TabIndex = 1;
            // 
            // dtEventDate
            // 
            dtEventDate.Location = new Point(288, 242);
            dtEventDate.Name = "dtEventDate";
            dtEventDate.Size = new Size(200, 23);
            dtEventDate.TabIndex = 2;
            dtEventDate.ValueChanged += dtEventDate_ValueChanged;
            // 
            // txtEventLocation
            // 
            txtEventLocation.Location = new Point(288, 157);
            txtEventLocation.Name = "txtEventLocation";
            txtEventLocation.Size = new Size(200, 23);
            txtEventLocation.TabIndex = 3;
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.Location = new Point(348, 36);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(71, 15);
            lblEventName.TabIndex = 4;
            lblEventName.Text = "Event Name";
            // 
            // lblEventLocation
            // 
            lblEventLocation.AutoSize = true;
            lblEventLocation.Location = new Point(348, 124);
            lblEventLocation.Name = "lblEventLocation";
            lblEventLocation.Size = new Size(85, 15);
            lblEventLocation.TabIndex = 5;
            lblEventLocation.Text = "Event Location";
            // 
            // lblEventDate
            // 
            lblEventDate.AutoSize = true;
            lblEventDate.Location = new Point(356, 200);
            lblEventDate.Name = "lblEventDate";
            lblEventDate.Size = new Size(63, 15);
            lblEventDate.TabIndex = 6;
            lblEventDate.Text = "Event Date";
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(205, 299);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(166, 106);
            btnAddEvent.TabIndex = 7;
            btnAddEvent.Text = "Add Event to Schedule";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // AddToScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddEvent);
            Controls.Add(lblEventDate);
            Controls.Add(lblEventLocation);
            Controls.Add(lblEventName);
            Controls.Add(txtEventLocation);
            Controls.Add(dtEventDate);
            Controls.Add(txtEventName);
            Controls.Add(btnScheduleExit);
            Name = "AddToScheduleForm";
            Text = "AddToSchedule";
            Load += AddToSchedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnScheduleExit;
		private TextBox txtEventName;
		private DateTimePicker dtEventDate;
		private TextBox txtEventLocation;
		private Label lblEventName;
		private Label lblEventLocation;
		private Label lblEventDate;
		private Button btnAddEvent;
	}
}