using Microsoft.EntityFrameworkCore;

namespace ScheduleManagement
{
    public partial class Form1 : Form
    {
        // Creates the list view with all needed components for displaying events
        private void CreateListView()
        {
            listViewSchedule.View = View.Details;
            listViewSchedule.Columns.Add("Event Date", 150, HorizontalAlignment.Left);
            listViewSchedule.Columns.Add("Event Name", 150, HorizontalAlignment.Left);
            listViewSchedule.Columns.Add("Event Location", -2, HorizontalAlignment.Left);
        }

        public Form1()
        {
            InitializeComponent();
            CreateListView();
            btnAdd.Click += btnAdd_Click; //Add schedule form
            btnDelete.Click += btnDelete_Click; //Delete event form

        }

        // This is the button, when pressed will bring you
        // to the Add schedule form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var AddToScheduleForm = new AddToScheduleForm();
            AddToScheduleForm.Show();
        }

        // This button, when pressed will bring you 
        // to the delete event form
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var DeleteEventForm = new DeleteEventForm();
            DeleteEventForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using ScheduleContext dbContext = new ScheduleContext();

            // Fetch all tasks from the database
            var tasks = dbContext.Events.ToList();

            // Clear the ListView 
            listViewSchedule.Items.Clear();

            foreach (var task in tasks)
            {
                var item = new ListViewItem(new[]
                {
                   task.EventDate.ToString("g"), // General date/time
                   task.EventName,
                   task.EventLocation
               });

                item.Tag = task.Id; // Store the task ID for retrieval
                listViewSchedule.Items.Add(item);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
