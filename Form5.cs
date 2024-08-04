using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FirstApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[cC][oO][mM]$");


            bool result = reg.IsMatch(textBox1.Text);
            if (result)
            {
                string message = "You're email is validated.";
                string title = "Validation";
                MessageBox.Show(message, title);
            }
            else
            {
                String message = "You're email is invalid.";
                string title = "Validation";
                MessageBox.Show(message, title);
                this.Close();


            }

        }
    }
}
