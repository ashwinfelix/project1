using System;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class assignment1Revsamp : Form
    {
        String stdDetails = "{0,-15}{1,-30}{2,-45}{3,-60}{4,-75}{5,-90}";

        public assignment1Revsamp()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.assignment1Revsamp_Load);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to Exit.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtYear.Text = "Select Year";
            txtCourse.Text = "Select Course";
            txtPartTime.SelectedIndex = 0;
            listBox1.Items.Clear();
            listBox1.Items.Add(String.Format(stdDetails, "ID", "First Name", "Last Name", "Course", "Year", "Full/Part Time"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtYear.Text = "Select Year";
            txtCourse.Text = "Select Course";
            txtPartTime.Text = "Select Type";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = txtId.Text.Trim();
                string FirstName = txtFirstName.Text.Trim();
                string LastName = txtLastName.Text.Trim();
                string Course = txtCourse.Text;
                string Year = txtYear.Text;
                string FullPart = txtPartTime.Text;

                
                if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) ||
                    string.IsNullOrEmpty(Course) || string.IsNullOrEmpty(Year) || string.IsNullOrEmpty(FullPart) ||
                        Course == "Select Course" || Year == "Select Type" || FullPart == "Select Year") 
                {
                    throw new Exception("Please fill in all fields.");
                }

                listBox1.Items.Add(String.Format(stdDetails, ID, FirstName, LastName, Course, Year, FullPart));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            // Handle key up event
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
