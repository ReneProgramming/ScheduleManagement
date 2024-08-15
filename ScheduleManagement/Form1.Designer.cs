namespace ScheduleManagement
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDisplay = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            lblTitle = new Label();
            listViewSchedule = new ListView();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(98, 344);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(165, 107);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display Schedule";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(333, 344);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(165, 107);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add to schedule";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(555, 344);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 107);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Event";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(304, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 15);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Welcome to the schedule  manager";
            // 
            // listViewSchedule
            // 
            listViewSchedule.Location = new Point(98, 81);
            listViewSchedule.Name = "listViewSchedule";
            listViewSchedule.Size = new Size(632, 212);
            listViewSchedule.TabIndex = 5;
            listViewSchedule.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 511);
            Controls.Add(listViewSchedule);
            Controls.Add(lblTitle);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDisplay;
		private Button btnAdd;
		private Button btnDelete;
		private Label lblTitle;
		private ListView listViewSchedule;
	}
}
