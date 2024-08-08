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
			SuspendLayout();
			// 
			// btnDeleteExit
			// 
			btnDeleteExit.Location = new Point(263, 283);
			btnDeleteExit.Name = "btnDeleteExit";
			btnDeleteExit.Size = new Size(204, 116);
			btnDeleteExit.TabIndex = 0;
			btnDeleteExit.Text = "Exit";
			btnDeleteExit.UseVisualStyleBackColor = true;
			// 
			// DeleteEventForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnDeleteExit);
			Name = "DeleteEventForm";
			Text = "DeleteEventForm";
			Load += DeleteEventForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnDeleteExit;
	}
}