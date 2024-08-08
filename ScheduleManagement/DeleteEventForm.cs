using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleManagement
{
	public partial class DeleteEventForm : Form
	{
		public DeleteEventForm()
		{
			InitializeComponent();
			btnDeleteExit.Click += btnDeleteExit_Click;
		}

		private void btnDeleteExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DeleteEventForm_Load(object sender, EventArgs e)
		{

		}
	}
}
