using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtUsername.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FirstApp(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider.SetError(txtUsername, "Please enter your username!");
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
