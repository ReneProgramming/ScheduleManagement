namespace ScheduleManagement
{
	partial class DeleteEventForm
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
            btnDeleteExit = new Button();
            listViewEvents = new ListView();
            btnDeleteEvent = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDeleteExit
            // 
            btnDeleteExit.Location = new Point(436, 291);
            btnDeleteExit.Name = "btnDeleteExit";
            btnDeleteExit.Size = new Size(204, 116);
            btnDeleteExit.TabIndex = 0;
            btnDeleteExit.Text = "Exit";
            btnDeleteExit.UseVisualStyleBackColor = true;
            // 
            // listViewEvents
            // 
            listViewEvents.Location = new Point(104, 35);
            listViewEvents.Name = "listViewEvents";
            listViewEvents.Size = new Size(563, 228);
            listViewEvents.TabIndex = 1;
            listViewEvents.UseCompatibleStateImageBehavior = false;
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.Location = new Point(104, 291);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(234, 116);
            btnDeleteEvent.TabIndex = 2;
            btnDeleteEvent.Text = "Delete Event";
            btnDeleteEvent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 17);
            label1.Name = "label1";
            label1.Size = new Size(185, 15);
            label1.TabIndex = 3;
            label1.Text = "Click on a Date to Select an Event!";
            // 
            // DeleteEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDeleteEvent);
            Controls.Add(listViewEvents);
            Controls.Add(btnDeleteExit);
            Name = "DeleteEventForm";
            Text = "DeleteEventForm";
            Load += DeleteEventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteExit;
        private ListView listViewEvents;
        private Button btnDeleteEvent;
        private Label label1;
    }
}