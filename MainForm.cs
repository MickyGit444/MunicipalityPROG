using System;
using System.Windows.Forms;

namespace Municipality
{
    // this is the mainform application main menu window  
    
    public partial class MainForm : Form
    {
        // Constructor
        public MainForm()
        {
            InitializeComponent();
           this.WindowState = FormWindowState.Maximized;
             this.BTReportIssue.Click += BTReportIssue_Click;
           this.BTlocalEA.Click += BTlocalEA_Click; 
        }

        // to show the reporttissues 
        private void BTReportIssue_Click(object sender, EventArgs e)
        {
           var reportForm = new ReportIssuesForm();
            reportForm.Show();
        }
        // to show localevents 
        private void BTlocalEA_Click(object sender, EventArgs e)
        {
         var eventsForm = new LocalEventsForm();
             eventsForm.Show(); 
        }
        // placeholder for service request status button
        private void BtSRS_Click(object sender, EventArgs e)
        {
          MessageBox.Show("service request status coming soon ");
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        // form load events 
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender,EventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}