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
	public partial class AddToScheduleForm : Form
	{
		public AddToScheduleForm()
		{
			InitializeComponent();
			btnScheduleExit.Click += btnScheduleExit_Click;
		}

		private void btnScheduleExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void AddToSchedule_Load(object sender, EventArgs e)
		{

		}
	}
}
