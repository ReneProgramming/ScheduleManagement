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
        // Creates the list view with all needed components for displaying events
        private void CreateListView()
        {
            listViewEvents.View = View.Details;
            listViewEvents.Columns.Add("Event Date", 150, HorizontalAlignment.Left);
            listViewEvents.Columns.Add("Event Name", 150, HorizontalAlignment.Left);
            listViewEvents.Columns.Add("Event Location", -2, HorizontalAlignment.Left);
        }

        public DeleteEventForm()
       {
           InitializeComponent();
           CreateListView();
           btnDeleteExit.Click += btnDeleteExit_Click;
           btnDeleteEvent.Click += btnDeleteEvent_Click;
       }

       private void DeleteEventForm_Load(object sender, EventArgs e)
       {
           using ScheduleContext dbContext = new ScheduleContext();

           // Fetch all tasks from the database
           var tasks = dbContext.Events.ToList();

           // Clear the ListView 
           listViewEvents.Items.Clear();

           foreach (var task in tasks)
           {
               var item = new ListViewItem(new[]
               { 
                   task.EventDate.ToString("g"), // General date/time
                   task.EventName,
                   task.EventLocation 
               });

               item.Tag = task.Id; // Store the task ID for retrieval
               listViewEvents.Items.Add(item);
           }
       }

       private void btnDeleteExit_Click(object sender, EventArgs e)
       {
           this.Close();
       }

       private void btnDeleteEvent_Click(object sender, EventArgs e)
       {
           if (listViewEvents.SelectedItems.Count > 0)
           {
               // Get the selected item
               var selectedItem = listViewEvents.SelectedItems[0];
               int taskId = (int)selectedItem.Tag;

               using ScheduleContext dbContext = new ScheduleContext();

               // Find the task by its ID
               var task = dbContext.Events.Find(taskId);
               if (task != null)
               {
                   // Remove the task from the database
                   dbContext.Events.Remove(task);
                   dbContext.SaveChanges();

                   // Inform the user and remove the item from the ListView
                   MessageBox.Show("Event deleted successfully!");
                   listViewEvents.Items.Remove(selectedItem);
               }
               else
               {
                   MessageBox.Show("Event not found.");
               }
           }
           else
           {
               MessageBox.Show("Please select an event to delete.");
           }
       }
   }
}
