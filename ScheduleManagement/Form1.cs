namespace ScheduleManagement
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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

		}
	}
}
