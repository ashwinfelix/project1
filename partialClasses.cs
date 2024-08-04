using System;
using System.Windows.Forms;

namespace FirstApp
{

    public enum Course
    {
        Mathematics,
        English,
        Physics,
        Chemistry,
        Biology,
        Businessstudies
    }

    public enum PartTime
    {
        PartTime,
        FullTime,
        SandwichCourse
    }

    public enum Year
    {
        FirstYear,
        SecondYear,
        ThirdYear,
        FourthYear
    }
    public partial class assignment1Revsamp : Form
    {
        private void assignment1Revsamp_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(String.Format(stdDetails, "ID", "First Name", "Last Name", "Course", "Year", "Full/Part Time"));
            txtCourse.Items.AddRange(Enum.GetNames(typeof(Course)));

            txtPartTime.Items.AddRange(Enum.GetNames(typeof(PartTime)));

            txtYear.Items.AddRange(Enum.GetNames(typeof(Year)));
        }
    }
}
