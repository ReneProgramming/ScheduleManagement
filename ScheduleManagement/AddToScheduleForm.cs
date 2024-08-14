using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

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

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            // Upon click, retrieve all of the input from
            // the form and add a new ScheduleTask object
            // to the database, notify the user the task
            // has been added, then close the Add form

            using ScheduleContext dbContext = new ScheduleContext();

            // Used to pass the currently displayed
            // information to ScheduleTask constructor
            string tempName = txtEventName.Text.ToString();
            string tempLocation = txtEventLocation.Text.ToString();
            DateTime tempDate = dtEventDate.Value;

            ScheduleTask newTask = new ScheduleTask(tempName, tempLocation, tempDate);

            dbContext.Add(newTask);
            dbContext.SaveChanges();
            this.Close();
        }

        private void dtEventDate_ValueChanged(object sender, EventArgs e)
        {
            // Might be used for something later
        }
    }
}
